namespace AssignmentForm
{
    partial class Customer_Delete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelCustDel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Lists: ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(87, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtID.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Location = new System.Drawing.Point(326, 329);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(110, 28);
            this.txtID.TabIndex = 2;
            // 
            // btnCancelCustDel
            // 
            this.btnCancelCustDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelCustDel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCustDel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelCustDel.Location = new System.Drawing.Point(278, 374);
            this.btnCancelCustDel.Name = "btnCancelCustDel";
            this.btnCancelCustDel.Size = new System.Drawing.Size(115, 38);
            this.btnCancelCustDel.TabIndex = 3;
            this.btnCancelCustDel.Text = "Cancel";
            this.btnCancelCustDel.UseVisualStyleBackColor = false;
            this.btnCancelCustDel.Click += new System.EventHandler(this.btnCancelCustDel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(48, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter customer\'s ID: ";
            // 
            // txtListC
            // 
            this.txtListC.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtListC.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtListC.Location = new System.Drawing.Point(43, 45);
            this.txtListC.Multiline = true;
            this.txtListC.Name = "txtListC";
            this.txtListC.Size = new System.Drawing.Size(464, 264);
            this.txtListC.TabIndex = 5;
            // 
            // Customer_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(537, 441);
            this.Controls.Add(this.txtListC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelCustDel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Delete";
            this.Text = "Customer_Delete";
            this.Load += new System.EventHandler(this.Customer_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancelCustDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListC;
    }
}