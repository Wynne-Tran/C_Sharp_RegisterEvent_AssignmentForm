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
    
    public partial class Customer_Details_Form : Form
    {
        CustomerManager printDetail;
        Customer c3;
        public Customer_Details_Form()
        {
            InitializeComponent();
            // step 1 to made form transparent
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            
        }
        // step 2 to made form transparent
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        public Customer_Details_Form(Customer c)
        {
            InitializeComponent();
            c3 = c;
        }

        public Customer_Details_Form(CustomerManager am)
        {
            InitializeComponent();
            printDetail = am;
        }
        private void btnCancelCustDetail_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Details_Form_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"CustomerList.txt"))
            {
                File.CreateText(@"CustomerList.txt");
            }
            IEnumerable<string> print = File.ReadLines(@"CustomerList.txt");
            txtList.Text = (String.Join(Environment.NewLine, print));
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            printDetail = FileCustomer.loadFromFile();
            txtList.Text = "";
            int id = Convert.ToInt32(txtID.Text);
            txtList.Text = Convert.ToString(printDetail.getCustomerInfo(id));
        }
    }
}
