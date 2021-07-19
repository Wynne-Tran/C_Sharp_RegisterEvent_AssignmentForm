namespace AssignmentForm
{
    partial class Adding_Event
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtday = new System.Windows.Forms.TextBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txthour = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.btnCancelAddEvent = new System.Windows.Forms.Button();
            this.lblout = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddEvent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddEvent.Location = new System.Drawing.Point(144, 373);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(132, 41);
            this.btnAddEvent.TabIndex = 1;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // txtEName
            // 
            this.txtEName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtEName.Location = new System.Drawing.Point(193, 40);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(318, 20);
            this.txtEName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(80, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Venue: ";
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVenue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtVenue.Location = new System.Drawing.Point(193, 75);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(318, 20);
            this.txtVenue.TabIndex = 14;
            this.txtVenue.TextChanged += new System.EventHandler(this.txtVenue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(355, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Year (2021-2025): ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(189, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Month: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(39, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Day: ";
            // 
            // txtday
            // 
            this.txtday.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtday.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtday.Location = new System.Drawing.Point(100, 131);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(49, 20);
            this.txtday.TabIndex = 18;
            // 
            // txtMon
            // 
            this.txtMon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtMon.Location = new System.Drawing.Point(276, 132);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(49, 20);
            this.txtMon.TabIndex = 19;
            this.txtMon.TextChanged += new System.EventHandler(this.txtMon_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtYear.Location = new System.Drawing.Point(550, 132);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(63, 20);
            this.txtYear.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(33, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Hour: ";
            // 
            // txthour
            // 
            this.txthour.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txthour.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txthour.Location = new System.Drawing.Point(100, 339);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(49, 20);
            this.txthour.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(189, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 23;
            this.label10.Text = "Minute: ";
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtMin.Location = new System.Drawing.Point(276, 335);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(49, 20);
            this.txtMin.TabIndex = 24;
            // 
            // btnCancelAddEvent
            // 
            this.btnCancelAddEvent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelAddEvent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddEvent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelAddEvent.Location = new System.Drawing.Point(359, 373);
            this.btnCancelAddEvent.Name = "btnCancelAddEvent";
            this.btnCancelAddEvent.Size = new System.Drawing.Size(132, 41);
            this.btnCancelAddEvent.TabIndex = 25;
            this.btnCancelAddEvent.Text = "Cancel";
            this.btnCancelAddEvent.UseVisualStyleBackColor = false;
            this.btnCancelAddEvent.Click += new System.EventHandler(this.btnCancelAddEvent_Click);
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblout.Location = new System.Drawing.Point(382, 296);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(0, 23);
            this.lblout.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(355, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "Max attendee";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMax.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtMax.Location = new System.Drawing.Point(518, 338);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(49, 20);
            this.txtMax.TabIndex = 28;
            // 
            // Adding_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.btnCancelAddEvent);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adding_Event";
            this.Text = "Adding_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnCancelAddEvent;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMax;
    }
}