namespace AssignmentForm
{
    partial class EventLists
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
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelViewELists = new System.Windows.Forms.Button();
            this.txtEList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(345, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(328, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(76, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Event Lists: ";
            // 
            // btnCancelViewELists
            // 
            this.btnCancelViewELists.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelViewELists.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelViewELists.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelViewELists.Location = new System.Drawing.Point(256, 356);
            this.btnCancelViewELists.Name = "btnCancelViewELists";
            this.btnCancelViewELists.Size = new System.Drawing.Size(132, 41);
            this.btnCancelViewELists.TabIndex = 23;
            this.btnCancelViewELists.Text = "Cancel";
            this.btnCancelViewELists.UseVisualStyleBackColor = false;
            this.btnCancelViewELists.Click += new System.EventHandler(this.btnCancelViewELists_Click);
            // 
            // txtEList
            // 
            this.txtEList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtEList.Location = new System.Drawing.Point(107, 63);
            this.txtEList.Multiline = true;
            this.txtEList.Name = "txtEList";
            this.txtEList.Size = new System.Drawing.Size(410, 247);
            this.txtEList.TabIndex = 25;
            // 
            // EventLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(589, 429);
            this.Controls.Add(this.txtEList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelViewELists);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventLists";
            this.Text = "EventLists";
            this.Load += new System.EventHandler(this.EventLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelViewELists;
        private System.Windows.Forms.TextBox txtEList;
    }
}