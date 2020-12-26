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
    public partial class ExitForm : Form
    {
        Form1 f1;
        

        private void ExitForm_Load(object sender, EventArgs e) { }

        public ExitForm(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Close();
        }

        
    }
}
