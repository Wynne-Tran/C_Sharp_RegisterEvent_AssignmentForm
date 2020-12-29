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
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AssignmentForm
{
    public partial class Register_Event : Form
    {
        RSVPManager rsvpManager;
        CustomerManager customerManager;
        EventManager eventManager;
        RSVP_Form rsvpForm;
        EventCoordinator eventCoordinator;
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
            rsvpForm = r;
            eventManager = new EventManager(1, 100);
            customerManager = new CustomerManager(1, 100);
            rsvpManager = new RSVPManager(1, 100);
            eventCoordinator = new EventCoordinator(1, 100, 1, 100, 1, 100);
            
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
            customerManager = FileCustomer.loadFromFile();
            txtout.Text = "";
            lblAtt.Text = "";
            /*
            int cusId = 0, eId = 0, num;
            
            if(int.TryParse(txtcus.Text, out num)) { cusId = num; }
            if (int.TryParse(txtev.Text, out num)) { eId = num; }
            */
            int cusId = Convert.ToInt32(txtcus.Text);
            int eId = Convert.ToInt32(txtev.Text);
            Customer1 newReg = customerManager.getCustomer(cusId);
            
            rsvpManager.addRegister(cusId, newReg.getFirstName(), newReg.getLastName(), eId);
            FileCustomer.writeRSVPFile(rsvpManager);
            eventCoordinator.addRegister(cusId, eId);
            eventCoordinator.addAttendee(cusId, eId);
            FileCustomer.writeCoordFile(eventCoordinator);
            lblAtt.Text = "Attendee added...";
            txtout.Text = "Thank you for registation!";
            txtcus.Text = "";
            txtev.Text = "";



        }
    }
}
