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
    public partial class Customer : Form
    {
        Form1 f1;
        public Customer()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        public Customer(Form1 f) // connect to form 1
        {
            f1 = f;
            InitializeComponent();
        }
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            f1.Show();
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adding_Customers addCustomer = new Adding_Customers(this);
            //code: child form show in the center of parent form
            addCustomer.StartPosition = FormStartPosition.CenterParent;
            addCustomer.ShowDialog(); // show addcustomer form
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Customer_Lists_Form viewCustomerLists = new Customer_Lists_Form(this);
            viewCustomerLists.StartPosition = FormStartPosition.CenterParent;
            viewCustomerLists.ShowDialog(); // show Customer_Lists_Form form


        }

        private void viewDetailCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details_Form viewCustomerDetail = new Customer_Details_Form(this);
            viewCustomerDetail.StartPosition = FormStartPosition.CenterParent;
            viewCustomerDetail.ShowDialog(); // show Customer_Details_Form form
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Delete deleteCustomer = new Customer_Delete(this);
            deleteCustomer.StartPosition = FormStartPosition.CenterParent;
            deleteCustomer.ShowDialog(); // show Customer_Delete form
        }

        private void clickMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    }
