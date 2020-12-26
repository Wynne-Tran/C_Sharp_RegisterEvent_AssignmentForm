namespace AssignmentForm
{
    partial class Register_Detail
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
            this.btnCancelEventDetail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelEventDetail
            // 
            this.btnCancelEventDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelEventDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEventDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelEventDetail.Location = new System.Drawing.Point(241, 425);
            this.btnCancelEventDetail.Name = "btnCancelEventDetail";
            this.btnCancelEventDetail.Size = new System.Drawing.Size(118, 35);
            this.btnCancelEventDetail.TabIndex = 11;
            this.btnCancelEventDetail.Text = "Cancel";
            this.btnCancelEventDetail.UseVisualStyleBackColor = false;
            this.btnCancelEventDetail.Click += new System.EventHandler(this.btnCancelEventDetail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(44, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please enter register ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Location = new System.Drawing.Point(278, 381);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 9;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetail.Location = new System.Drawing.Point(97, 425);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(118, 35);
            this.btnDetail.TabIndex = 8;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(44, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Register Lists: ";
            // 
            // txtListR
            // 
            this.txtListR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtListR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtListR.Location = new System.Drawing.Point(64, 74);
            this.txtListR.Multiline = true;
            this.txtListR.Name = "txtListR";
            this.txtListR.Size = new System.Drawing.Size(376, 259);
            this.txtListR.TabIndex = 13;
            // 
            // Register_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(524, 485);
            this.Controls.Add(this.txtListR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelEventDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDetail);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register_Detail";
            this.Text = "Register_Detail";
            this.Load += new System.EventHandler(this.Register_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelEventDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListR;
    }
}