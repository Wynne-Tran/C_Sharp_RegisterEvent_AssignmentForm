namespace AssignmentForm
{
    partial class Customer_Lists_Form
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
            this.btnCancelCustList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelCustList
            // 
            this.btnCancelCustList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelCustList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCustList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelCustList.Location = new System.Drawing.Point(196, 350);
            this.btnCancelCustList.Name = "btnCancelCustList";
            this.btnCancelCustList.Size = new System.Drawing.Size(107, 40);
            this.btnCancelCustList.TabIndex = 0;
            this.btnCancelCustList.Text = "Cancel";
            this.btnCancelCustList.UseVisualStyleBackColor = false;
            this.btnCancelCustList.Click += new System.EventHandler(this.btnCancelCustList_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Lists: ";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(35, 62);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(432, 265);
            this.txtList.TabIndex = 2;
            // 
            // Customer_Lists_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(513, 442);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelCustList);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Lists_Form";
            this.Text = "Customer_Lists_Form";
            this.Load += new System.EventHandler(this.Customer_Lists_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelCustList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtList;
    }
}