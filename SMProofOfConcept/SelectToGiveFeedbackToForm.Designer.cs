namespace SMProofOfConcept
{
    partial class SelectToGiveFeedbackToForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectToGiveFeedbackToForm));
            this.lbl_cas = new System.Windows.Forms.Label();
            this.lbl_JohnSnow = new System.Windows.Forms.Label();
            this.lbl_Mark = new System.Windows.Forms.Label();
            this.lbl_Dennis = new System.Windows.Forms.Label();
            this.lbl_Ricky = new System.Windows.Forms.Label();
            this.lbl_Jeroen = new System.Windows.Forms.Label();
            this.btn_askFeedback = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lbl_cas
            // 
            this.lbl_cas.AutoSize = true;
            this.lbl_cas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_cas.Location = new System.Drawing.Point(127, 32);
            this.lbl_cas.Name = "lbl_cas";
            this.lbl_cas.Size = new System.Drawing.Size(114, 58);
            this.lbl_cas.TabIndex = 0;
            this.lbl_cas.Text = "Cas";
            this.lbl_cas.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_JohnSnow
            // 
            this.lbl_JohnSnow.AutoSize = true;
            this.lbl_JohnSnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_JohnSnow.Location = new System.Drawing.Point(274, 32);
            this.lbl_JohnSnow.Name = "lbl_JohnSnow";
            this.lbl_JohnSnow.Size = new System.Drawing.Size(134, 58);
            this.lbl_JohnSnow.TabIndex = 1;
            this.lbl_JohnSnow.Text = "John";
            this.lbl_JohnSnow.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_Mark
            // 
            this.lbl_Mark.AutoSize = true;
            this.lbl_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_Mark.Location = new System.Drawing.Point(353, 193);
            this.lbl_Mark.Name = "lbl_Mark";
            this.lbl_Mark.Size = new System.Drawing.Size(137, 58);
            this.lbl_Mark.TabIndex = 2;
            this.lbl_Mark.Text = "Mark";
            this.lbl_Mark.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Dennis
            // 
            this.lbl_Dennis.AutoSize = true;
            this.lbl_Dennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_Dennis.Location = new System.Drawing.Point(14, 193);
            this.lbl_Dennis.Name = "lbl_Dennis";
            this.lbl_Dennis.Size = new System.Drawing.Size(181, 58);
            this.lbl_Dennis.TabIndex = 3;
            this.lbl_Dennis.Text = "Dennis";
            this.lbl_Dennis.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Ricky
            // 
            this.lbl_Ricky.AutoSize = true;
            this.lbl_Ricky.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_Ricky.Location = new System.Drawing.Point(48, 109);
            this.lbl_Ricky.Name = "lbl_Ricky";
            this.lbl_Ricky.Size = new System.Drawing.Size(147, 58);
            this.lbl_Ricky.TabIndex = 4;
            this.lbl_Ricky.Text = "Ricky";
            this.lbl_Ricky.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_Jeroen
            // 
            this.lbl_Jeroen.AutoSize = true;
            this.lbl_Jeroen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbl_Jeroen.Location = new System.Drawing.Point(353, 109);
            this.lbl_Jeroen.Name = "lbl_Jeroen";
            this.lbl_Jeroen.Size = new System.Drawing.Size(179, 58);
            this.lbl_Jeroen.TabIndex = 5;
            this.lbl_Jeroen.Text = "Jeroen";
            this.lbl_Jeroen.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_askFeedback
            // 
            this.btn_askFeedback.Location = new System.Drawing.Point(191, 271);
            this.btn_askFeedback.Name = "btn_askFeedback";
            this.btn_askFeedback.Size = new System.Drawing.Size(147, 52);
            this.btn_askFeedback.TabIndex = 6;
            this.btn_askFeedback.Text = "Vraag feedback";
            this.btn_askFeedback.UseVisualStyleBackColor = true;
            this.btn_askFeedback.Click += new System.EventHandler(this.btn_askFeedback_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FeedbackApp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // SelectToGiveFeedbackToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 335);
            this.Controls.Add(this.btn_askFeedback);
            this.Controls.Add(this.lbl_Jeroen);
            this.Controls.Add(this.lbl_Ricky);
            this.Controls.Add(this.lbl_Dennis);
            this.Controls.Add(this.lbl_Mark);
            this.Controls.Add(this.lbl_JohnSnow);
            this.Controls.Add(this.lbl_cas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectToGiveFeedbackToForm";
            this.Text = "SelectToGiveFeedbackToForm";
            this.Resize += new System.EventHandler(this.SelectToGiveFeedbackToForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cas;
        private System.Windows.Forms.Label lbl_JohnSnow;
        private System.Windows.Forms.Label lbl_Mark;
        private System.Windows.Forms.Label lbl_Dennis;
        private System.Windows.Forms.Label lbl_Ricky;
        private System.Windows.Forms.Label lbl_Jeroen;
        private System.Windows.Forms.Button btn_askFeedback;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}