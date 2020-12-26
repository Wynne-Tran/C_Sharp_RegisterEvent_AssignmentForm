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
    public partial class Event : Form
    {
        Form1 f2;
        public Event()
        {
            InitializeComponent();
        }


        public Event(Form1 f)
        {
            f2 = f;
            InitializeComponent();
        }

       
        private void Event_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Close();
        }
        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adding_Event addEvent = new Adding_Event(this);
            //code: child form show in the center of parent form
            addEvent.StartPosition = FormStartPosition.CenterParent;
            addEvent.ShowDialog(); // show addcustomer form
        }

        private void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventLists viewAllEvents = new EventLists(this);
            //code: child form show in the center of parent form
            viewAllEvents.StartPosition = FormStartPosition.CenterParent;
            viewAllEvents.ShowDialog(); // show addcustomer form
        }

        private void viewEventDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Event_Detail viewDetailEvents = new Event_Detail(this);
            //code: child form show in the center of parent form
            viewDetailEvents.StartPosition = FormStartPosition.CenterParent;
            viewDetailEvents.ShowDialog(); // show addcustomer form
        }

        
    }
}
