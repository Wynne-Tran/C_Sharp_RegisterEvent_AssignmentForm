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
    public partial class Event_Detail : Form
    {
        EventManager printList;
        Event e3;
        public Event_Detail()
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
        public Event_Detail(Event e)
        {
            InitializeComponent();
            e3 = e;
            printList = new EventManager(1, 100);
        }

        private void Event_Detail_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"EventList.txt"))
            {
                File.CreateText(@"EventList.txt");
            }
            IEnumerable<string> print = File.ReadLines(@"EventList.txt");
            txtEList.Text = (String.Join(Environment.NewLine, print));
        }

        private void btnCancelEventDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            EventManager printListB;
            printList = FileCustomer.loadFromTXTFile();
            printListB = FileCustomer.loadFromTXTFileDetail();
            txtEList.Text = "";
            int id = Convert.ToInt32(txtID.Text);
            //txtEList.Text = printList.getEventInfo(id).ToString();
            var lines = File.ReadLines(@"EventListDetail.txt");
            
            foreach (var line in lines)
            {
                if (line == txtID.Text)
                {
                    txtEList.Text = Convert.ToString(printListB.getEventInfo2(id));
                    break;
                }

            }
            if (txtEList.Text == "")
            {
                txtEList.Text = Convert.ToString(printList.getEventInfo(id));
            }
        }
    }
}
