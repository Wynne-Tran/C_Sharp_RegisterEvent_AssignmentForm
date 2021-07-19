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
    public partial class Customer_Delete : Form
    {
        CustomerManager printList;
        Customer c4;
        public Customer_Delete()
        {
            InitializeComponent();
            // step 1 to made form transparent
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }
        // step 2 to made form transparent
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        public Customer_Delete(Customer c)
        {
            InitializeComponent();
            c4 = c;
            printList = new CustomerManager(1, 100);
        }

        private void Customer_Delete_Load(object sender, EventArgs e)
        {
            if (!File.Exists(@"CustomerList.txt"))
            {
                File.CreateText(@"CustomerList.txt");
            }
            IEnumerable<string> printD = File.ReadLines(@"CustomerList.txt");
            txtListC.Text = (String.Join(Environment.NewLine, printD));
        }

        private void btnCancelCustDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            printList = FileCustomer.loadFromFile();
            txtListC.Text = "";
            int id = Convert.ToInt32(txtID.Text);
            printList.deleteCustomer(id);
            txtListC.Text = "Customer deleted...";
            FileCustomer.writeToFile(printList);

        }
    }
}
