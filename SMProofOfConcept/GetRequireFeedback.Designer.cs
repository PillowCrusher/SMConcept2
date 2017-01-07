namespace SMProofOfConcept
{
    partial class GetRequireFeedback
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
            this.lbx_RequireFeedback = new System.Windows.Forms.ListBox();
            this.btn_Give_Feedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_RequireFeedback
            // 
            this.lbx_RequireFeedback.FormattingEnabled = true;
            this.lbx_RequireFeedback.Location = new System.Drawing.Point(12, 12);
            this.lbx_RequireFeedback.Name = "lbx_RequireFeedback";
            this.lbx_RequireFeedback.Size = new System.Drawing.Size(396, 355);
            this.lbx_RequireFeedback.TabIndex = 0;
            // 
            // btn_Give_Feedback
            // 
            this.btn_Give_Feedback.Location = new System.Drawing.Point(118, 373);
            this.btn_Give_Feedback.Name = "btn_Give_Feedback";
            this.btn_Give_Feedback.Size = new System.Drawing.Size(181, 47);
            this.btn_Give_Feedback.TabIndex = 1;
            this.btn_Give_Feedback.Text = "Geef feedback";
            this.btn_Give_Feedback.UseVisualStyleBackColor = true;
            this.btn_Give_Feedback.Click += new System.EventHandler(this.btn_Give_Feedback_Click);
            // 
            // GetRequireFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 427);
            this.Controls.Add(this.btn_Give_Feedback);
            this.Controls.Add(this.lbx_RequireFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GetRequireFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetRequireFeedback";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_RequireFeedback;
        private System.Windows.Forms.Button btn_Give_Feedback;
    }
}