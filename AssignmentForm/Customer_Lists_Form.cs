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
    public partial class Customer_Lists_Form : Form
    {
        CustomerManager printList;
        Customer c2;
        public Customer_Lists_Form()
        {
            InitializeComponent();
            // step 1 to made form transparent
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent;
        }

        public Customer_Lists_Form(CustomerManager am)
        {
            InitializeComponent();
            printList = am;
        }

        // step 2 to made form transparent
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Transparent, e.ClipRectangle);
        }
        
        public Customer_Lists_Form(Customer c)
        {
            InitializeComponent();
            c2 = c;
        }
       
        
        private void btnCancelCustList_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customer_Lists_Form_Load(object sender, EventArgs e)
        {

            IEnumerable<string> print = File.ReadLines(@"CustomerList.txt");
            txtList.Text = (String.Join(Environment.NewLine, print));

        }
    }
}
