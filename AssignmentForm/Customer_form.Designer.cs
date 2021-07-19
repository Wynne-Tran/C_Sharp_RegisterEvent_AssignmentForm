namespace AssignmentForm
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clickMenu = new System.Windows.Forms.MenuStrip();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::AssignmentForm.Properties.Resources.arrowsmall;
            this.pictureBox2.Location = new System.Drawing.Point(1117, 699);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::AssignmentForm.Properties.Resources.celebration_background_neon_style_1017_21126;
            this.pictureBox1.Location = new System.Drawing.Point(0, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1240, 971);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            //this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clickMenu
            // 
            this.clickMenu.BackColor = System.Drawing.Color.Transparent;
            this.clickMenu.BackgroundImage = global::AssignmentForm.Properties.Resources.light2;
            this.clickMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clickMenu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomerToolStripMenuItem,
            this.viewDetailCustomerToolStripMenuItem,
            this.deleteCustomerToolStripMenuItem});
            this.clickMenu.Location = new System.Drawing.Point(0, 0);
            this.clickMenu.Name = "clickMenu";
            this.clickMenu.Size = new System.Drawing.Size(1240, 44);
            this.clickMenu.TabIndex = 1;
            this.clickMenu.Text = "menuStrip1";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(234, 40);
            this.addCustomerToolStripMenuItem.Text = "Add Customer |";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(300, 40);
            this.viewCustomerToolStripMenuItem.Text = "View All Customers |";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // viewDetailCustomerToolStripMenuItem
            // 
            this.viewDetailCustomerToolStripMenuItem.Name = "viewDetailCustomerToolStripMenuItem";
            this.viewDetailCustomerToolStripMenuItem.Size = new System.Drawing.Size(328, 40);
            this.viewDetailCustomerToolStripMenuItem.Text = "View Detail Customer |";
            this.viewDetailCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewDetailCustomerToolStripMenuItem_Click);
            // 
            // deleteCustomerToolStripMenuItem
            // 
            this.deleteCustomerToolStripMenuItem.Name = "deleteCustomerToolStripMenuItem";
            this.deleteCustomerToolStripMenuItem.Size = new System.Drawing.Size(257, 40);
            this.deleteCustomerToolStripMenuItem.Text = "Delete Customer ";
            this.deleteCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerToolStripMenuItem_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1015);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clickMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.clickMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Customer";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clickMenu.ResumeLayout(false);
            this.clickMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip clickMenu;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}