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
    

    public partial class Adding_Customers : Form
    {
        CustomerManager cm;
        Customer c1;

        public Adding_Customers()
        {
            InitializeComponent();
            // step 1 to made form transparent
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
            CenterToParent();
        }
        // step 2 to made form transparent
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        public Adding_Customers(Customer c)
        {
            InitializeComponent();
            
            c1 = c;
            cm = new CustomerManager(1, 100);
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            lblNo.Text = "";
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string phone = txtPhone.Text;
            cm.addCustomer(fname, lname, phone);
            lblMes.Text = "Customer added..";
            FileCustomer.writeToFile(cm) ;
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtPhone.Text = string.Empty;

        }

    }





    
}
