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
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer soundXmast = new System.Media.SoundPlayer();
        EventCoordinator ec;
        public Form1()
        {

            InitializeComponent();
            ec = new EventCoordinator(200, 1000, 101, 5000, 100, 10000); // add data
            soundXmast.SoundLocation = "Bell.wav";
            soundXmast.Load();
            //soundXmast.Play();
            soundXmast.PlayLooping();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code for transparent button btnExit
            // first, go to properties->FlatApperence->FlatStyle->Flat
            this.btnExit.Parent = this.pictureBox1;
            this.btnExit.BackColor = Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //code for transparent button btnCustomer
            this.btnCustomer.Parent = this.pictureBox1;
            this.btnCustomer.BackColor = Color.Transparent;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //code for transparent button btnEvent
            this.btnEvent.Parent = this.pictureBox1;
            this.btnEvent.BackColor = Color.Transparent;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //code for transparent button btnRSVP
            this.btnRSVP.Parent = this.pictureBox1;
            this.btnRSVP.BackColor = Color.Transparent;
            this.btnRSVP.FlatAppearance.BorderSize = 0;
            this.btnRSVP.FlatAppearance.MouseOverBackColor = Color.Transparent;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitForm e1 = new ExitForm(this);
            e1.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            e1.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(this);
            cust.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            this.soundXmast.Stop();
            cust.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Event newEvent = new Event(this);
            newEvent.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            this.soundXmast.Stop();
            newEvent.Show();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            RSVP_Form newRegister = new RSVP_Form(this);
            newRegister.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            this.soundXmast.Stop();
            newRegister.Show();
        }

    }


}
