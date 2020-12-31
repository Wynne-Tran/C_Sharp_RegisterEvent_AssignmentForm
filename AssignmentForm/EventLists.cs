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
    public partial class EventLists : Form
    {
        EventManager em;
        Event e2;
        public EventLists()
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
        public EventLists(Event e)
        {
            InitializeComponent();
            e2 = e;
            em = new EventManager(1, 100);
        }
        
        private void EventLists_Load(object sender, EventArgs e)

        {
            if (!File.Exists(@"EventList.txt"))
            {
                File.CreateText(@"EventList.txt");
            }
            IEnumerable<string> printEvent = File.ReadLines(@"EventList.txt");
            txtEList.Text = (String.Join(Environment.NewLine, printEvent));
            
        }

        private void btnCancelViewELists_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
