/* GROUP MEMBERS
 * 
 * Thi Hoang Tram Tran (Wynne) - 101161665
 * 
 * Forough Kiani - 101282711
 * 
 * Matias Herter - 101272358
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentForm
{
    public partial class Register_Event : Form
    {
        RSVPManager ec;
        CustomerManager cm;
        EventManager em;
        RSVP_Form r1;
        EventCoordinator coord;
        CustomerManager cm2 = new CustomerManager(1, 100);
        EventManager em2 = new EventManager(1, 100);
        public Register_Event()
        {
            InitializeComponent();
            // step 1 to made form transparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            CenterToParent();
        }
        // step 2 to made form transparent
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        public Register_Event(RSVP_Form r)
        {
            InitializeComponent();
            r1 = r;
            em = new EventManager(1, 100);
            cm = new CustomerManager(1, 100);
            ec = new RSVPManager(1, 100);
            coord = new EventCoordinator(1, 100, 1, 100, 1, 100);
            
        }

        private void Register_Event_Load(object sender, EventArgs e)
        {
            IEnumerable<string> print = File.ReadLines(@"CustomerList.txt");
            txtListC.Text = (String.Join(Environment.NewLine, print));

            IEnumerable<string> print1 = File.ReadLines(@"EventList.txt");
            txtListE.Text = (String.Join(Environment.NewLine, print1));
        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            cm = FileCustomer.loadFromFile();
            em = FileCustomer.loadFromTXTFile();
            txtout.Text = "";
            lblAtt.Text = "";
            
            int cusId = Convert.ToInt32(txtcus.Text);
            int eId = Convert.ToInt32(txtev.Text);

            Customer1 newReg = cm.getCustomer(cusId);
            Event1 newEve = em.getEvent(eId);

            ec.addRegister(cusId, newReg.getFirstName(), newReg.getLastName(), eId);
            FileCustomer.writeRSVPFile(ec);
            
            // code for update booking when customer register
            String[] arr = File.ReadAllLines(@"CustomerListDetail.txt");
            if (arr.Length != 0)
            {
                bool available = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == newReg.getPhone())
                    {
                        string current = arr[i + 1];
                        arr[i + 1] = arr[i + 1].Replace(current, (Convert.ToInt32(current) + 1).ToString());
                        available = true;
                        break;
                    }
                }

                File.WriteAllLines(@"CustomerListDetail.txt", arr);
                if (available == false)
                {
                    cm2.addCustomer(newReg.getFirstName(), newReg.getLastName(), newReg.getPhone());
                    FileCustomer.writeToFileDetail(cm2, newReg.updateBookings());
                }
            }
            else
            {
               cm2.addCustomer(newReg.getFirstName(), newReg.getLastName(), newReg.getPhone());
            FileCustomer.writeToFileDetail(cm2, newReg.updateBookings());

            }


            // code for update attendee when customer register

            String[] arrEvent = File.ReadAllLines(@"EventListDetail.txt");
            if (arrEvent.Length != 0)
            {
                bool available = false;
                for (int i = 0; i < arrEvent.Length; i++)
                {
                    if (arrEvent[i] == newEve.getEventName())
                    {
                        string current = arrEvent[i + 7];
                        arrEvent[i + 7] = arrEvent[i + 7].Replace(current, (Convert.ToInt32(current) + 1).ToString());
                        available = true;
                        break;
                    }
                }

                File.WriteAllLines(@"EventListDetail.txt", arrEvent);
                if (available == false)
                {
                    em2.addEvent(newEve.getEventName(), newEve.getVenue(), newEve.getEventDate(), newEve.getMaxAttendees());
                    FileCustomer.writeToTXTFileDetail(em2, newEve.updateAttendee(), cm.getCustomer(cusId));
                }
            }
            else
            {
                em2.addEvent(newEve.getEventName(), newEve.getVenue(), newEve.getEventDate(), newEve.getMaxAttendees());
                FileCustomer.writeToTXTFileDetail(em2, newEve.updateAttendee(), cm.getCustomer(cusId));

            }

            lblAtt.Text = "Attendee added...";
            txtout.Text = "Thank you for registation!";
            txtcus.Text = "";
            txtev.Text = "";

        }

        
    }
}
