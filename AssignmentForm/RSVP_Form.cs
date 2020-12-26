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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentForm
{
    public partial class RSVP_Form : Form
    {
        Form1 f3;
        public RSVP_Form()
        {
            InitializeComponent();
        }

        public RSVP_Form(Form1 f)
        {
            f3 = f;
            InitializeComponent();
        }
        
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Close();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Event registerEvent = new Register_Event(this);
            //code: child form show in the center of parent form
            registerEvent.StartPosition = FormStartPosition.CenterParent;
            registerEvent.ShowDialog(); // show addcustomer form
        }

        private void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_Detail registerDtail = new Register_Detail(this);
            //code: child form show in the center of parent form
            registerDtail.StartPosition = FormStartPosition.CenterParent;
            registerDtail.ShowDialog(); // show addcustomer form
        }

    }
}
