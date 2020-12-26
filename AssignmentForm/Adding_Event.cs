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
    public partial class Adding_Event : Form
    {
        EventManager em;
        Event e1;
        public Adding_Event()
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
        public Adding_Event(Event e)
        {
            InitializeComponent();
            e1 = e;
            em = new EventManager(1, 100);
        }

        private void btnCancelAddEvent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            lblout.Text = "";
            string name = txtEName.Text;
            string venue = txtVenue.Text;
            
            int day = Convert.ToInt32(txtday.Text);
            int month = Convert.ToInt32(txtMon.Text);
            int year = Convert.ToInt32(txtYear.Text);
            int hour = Convert.ToInt32(txthour.Text);
            int minus = Convert.ToInt32(txtMin.Text);
            int max = Convert.ToInt32(txtMax.Text);

            Date edate = new Date(day, month, year, hour, minus);
            em.addEvent(name, venue, edate, max);
            FileCustomer.writeToTXTFile(em);
            lblout.Text = "Event added...";
            txtEName.Text = "";
            txtVenue.Text = "";
            (txtday.Text) = "";
            (txtMon.Text) = "";
            (txtYear.Text) = "";
            (txthour.Text) = "";
            (txtMin.Text) = "";
            (txtMax.Text) = "";
        }
        
    }
}
