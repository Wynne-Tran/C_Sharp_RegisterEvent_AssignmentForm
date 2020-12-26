namespace AssignmentForm
{
    partial class Event_Detail
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnCancelEventDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(131, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter event ID:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtID.Location = new System.Drawing.Point(352, 347);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(151, 20);
            this.txtID.TabIndex = 5;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDetail.Location = new System.Drawing.Point(201, 391);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(118, 35);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnCancelEventDetail
            // 
            this.btnCancelEventDetail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelEventDetail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEventDetail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelEventDetail.Location = new System.Drawing.Point(352, 391);
            this.btnCancelEventDetail.Name = "btnCancelEventDetail";
            this.btnCancelEventDetail.Size = new System.Drawing.Size(118, 35);
            this.btnCancelEventDetail.TabIndex = 7;
            this.btnCancelEventDetail.Text = "Cancel";
            this.btnCancelEventDetail.UseVisualStyleBackColor = false;
            this.btnCancelEventDetail.Click += new System.EventHandler(this.btnCancelEventDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event Lists: ";
            // 
            // txtEList
            // 
            this.txtEList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtEList.Location = new System.Drawing.Point(84, 65);
            this.txtEList.Multiline = true;
            this.txtEList.Name = "txtEList";
            this.txtEList.Size = new System.Drawing.Size(438, 237);
            this.txtEList.TabIndex = 9;
            // 
            // Event_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(606, 443);
            this.Controls.Add(this.txtEList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelEventDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDetail);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Event_Detail";
            this.Text = "Event_Detail";
            this.Load += new System.EventHandler(this.Event_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnCancelEventDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEList;
    }
}