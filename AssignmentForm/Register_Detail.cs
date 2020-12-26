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
    public partial class Register_Detail : Form
    {
        RSVPManager printList;
        RSVP_Form r2;
        public Register_Detail()
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
        public Register_Detail(RSVP_Form r)
        {
            InitializeComponent();
            r2 = r;
            printList = new RSVPManager(1,100);
        }

        private void Register_Detail_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"RSVPList.txt"))
            {
                File.CreateText(@"RSVPList.txt");
            }
            IEnumerable<string> printReg = File.ReadLines(@"RSVPList.txt");
            txtListR.Text = (String.Join(Environment.NewLine, printReg));
        }

        private void btnCancelEventDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            printList = FileCustomer.loadRSVPFile();
            txtListR.Text = "";
            int id = Convert.ToInt32(txtID.Text);
            txtListR.Text = printList.getRegisterInfo(id);
            
        }
    }
}
