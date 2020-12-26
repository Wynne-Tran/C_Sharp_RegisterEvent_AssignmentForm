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
            txtout.Text = "";
            lblAtt.Text = "";
            /*
            int cusId = 0, eId = 0, num;
            
            if(int.TryParse(txtcus.Text, out num)) { cusId = num; }
            if (int.TryParse(txtev.Text, out num)) { eId = num; }
            */
            int cusId = Convert.ToInt32(txtcus.Text);
            int eId = Convert.ToInt32(txtev.Text);
            Customer1 newReg = cm.getCustomer(cusId);
            ec.addRegister(cusId, newReg.getFirstName(), newReg.getLastName(), eId);
            FileCustomer.writeRSVPFile(ec);
            coord.addRegister(cusId, eId);
            coord.addAttendee(cusId, eId);
            FileCustomer.writeCoordFile(coord);
            lblAtt.Text = "Attendee added...";
            txtout.Text = "Thank you for registation!";
            txtcus.Text = "";
            txtev.Text = "";



        }
    }
}
