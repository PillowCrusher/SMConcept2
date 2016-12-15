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
            this.btn_askFeedback = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Afsluiten = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Dennis = new System.Windows.Forms.PictureBox();
            this.pb_Jeroen = new System.Windows.Forms.PictureBox();
            this.pb_Ricky = new System.Windows.Forms.PictureBox();
            this.pb_Mark = new System.Windows.Forms.PictureBox();
            this.pb_John = new System.Windows.Forms.PictureBox();
            this.pb_Cas = new System.Windows.Forms.PictureBox();
            this.pb_Cas_Rating = new System.Windows.Forms.PictureBox();
            this.pb_Dennis_Rating = new System.Windows.Forms.PictureBox();
            this.pb_Jeroen_Rating = new System.Windows.Forms.PictureBox();
            this.pb_John_Rating = new System.Windows.Forms.PictureBox();
            this.pb_Mark_Rating = new System.Windows.Forms.PictureBox();
            this.pb_Ricky_Rating = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dennis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Jeroen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ricky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_John)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cas_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dennis_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Jeroen_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_John_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mark_Rating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ricky_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_askFeedback
            // 
            this.btn_askFeedback.Location = new System.Drawing.Point(202, 368);
            this.btn_askFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btn_askFeedback.Name = "btn_askFeedback";
            this.btn_askFeedback.Size = new System.Drawing.Size(185, 42);
            this.btn_askFeedback.TabIndex = 6;
            this.btn_askFeedback.Text = "Vraag feedback";
            this.btn_askFeedback.UseVisualStyleBackColor = true;
            this.btn_askFeedback.Click += new System.EventHandler(this.btn_askFeedback_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FeedbackApp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Open,
            this.tsmi_Afsluiten});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // tsmi_Open
            // 
            this.tsmi_Open.Name = "tsmi_Open";
            this.tsmi_Open.Size = new System.Drawing.Size(121, 22);
            this.tsmi_Open.Text = "Open";
            this.tsmi_Open.Click += new System.EventHandler(this.tsmi_Open_Click);
            // 
            // tsmi_Afsluiten
            // 
            this.tsmi_Afsluiten.Name = "tsmi_Afsluiten";
            this.tsmi_Afsluiten.Size = new System.Drawing.Size(121, 22);
            this.tsmi_Afsluiten.Text = "Afsluiten";
            this.tsmi_Afsluiten.Click += new System.EventHandler(this.tsmi_Afsluiten_Click_1);
            // 
            // pb_Dennis
            // 
            this.pb_Dennis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Dennis.Image = global::SMProofOfConcept.Properties.Resources.Dennis;
            this.pb_Dennis.Location = new System.Drawing.Point(202, 12);
            this.pb_Dennis.Name = "pb_Dennis";
            this.pb_Dennis.Size = new System.Drawing.Size(185, 165);
            this.pb_Dennis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Dennis.TabIndex = 12;
            this.pb_Dennis.TabStop = false;
            this.pb_Dennis.Click += new System.EventHandler(this.pb_Dennis_Click);
            // 
            // pb_Jeroen
            // 
            this.pb_Jeroen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Jeroen.Image = global::SMProofOfConcept.Properties.Resources.Jeroen;
            this.pb_Jeroen.Location = new System.Drawing.Point(393, 12);
            this.pb_Jeroen.Name = "pb_Jeroen";
            this.pb_Jeroen.Size = new System.Drawing.Size(185, 165);
            this.pb_Jeroen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Jeroen.TabIndex = 11;
            this.pb_Jeroen.TabStop = false;
            this.pb_Jeroen.Click += new System.EventHandler(this.pb_Jeroen_Click);
            // 
            // pb_Ricky
            // 
            this.pb_Ricky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Ricky.Image = global::SMProofOfConcept.Properties.Resources.Ricky;
            this.pb_Ricky.Location = new System.Drawing.Point(393, 183);
            this.pb_Ricky.Name = "pb_Ricky";
            this.pb_Ricky.Size = new System.Drawing.Size(185, 165);
            this.pb_Ricky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Ricky.TabIndex = 10;
            this.pb_Ricky.TabStop = false;
            this.pb_Ricky.Click += new System.EventHandler(this.pb_Ricky_Click);
            // 
            // pb_Mark
            // 
            this.pb_Mark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Mark.Image = global::SMProofOfConcept.Properties.Resources.Mark;
            this.pb_Mark.Location = new System.Drawing.Point(203, 183);
            this.pb_Mark.Name = "pb_Mark";
            this.pb_Mark.Size = new System.Drawing.Size(184, 165);
            this.pb_Mark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Mark.TabIndex = 9;
            this.pb_Mark.TabStop = false;
            this.pb_Mark.Click += new System.EventHandler(this.pb_Mark_Click);
            // 
            // pb_John
            // 
            this.pb_John.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_John.Image = global::SMProofOfConcept.Properties.Resources.John;
            this.pb_John.Location = new System.Drawing.Point(12, 183);
            this.pb_John.Name = "pb_John";
            this.pb_John.Size = new System.Drawing.Size(185, 165);
            this.pb_John.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_John.TabIndex = 8;
            this.pb_John.TabStop = false;
            this.pb_John.Click += new System.EventHandler(this.pb_John_Click);
            // 
            // pb_Cas
            // 
            this.pb_Cas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Cas.Image = global::SMProofOfConcept.Properties.Resources.Cas;
            this.pb_Cas.Location = new System.Drawing.Point(12, 12);
            this.pb_Cas.Name = "pb_Cas";
            this.pb_Cas.Size = new System.Drawing.Size(185, 165);
            this.pb_Cas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Cas.TabIndex = 7;
            this.pb_Cas.TabStop = false;
            this.pb_Cas.Click += new System.EventHandler(this.pb_Cas_Click);
            // 
            // pb_Cas_Rating
            // 
            this.pb_Cas_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_Cas_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_Cas_Rating.Location = new System.Drawing.Point(139, 12);
            this.pb_Cas_Rating.Name = "pb_Cas_Rating";
            this.pb_Cas_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_Cas_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Cas_Rating.TabIndex = 13;
            this.pb_Cas_Rating.TabStop = false;
            // 
            // pb_Dennis_Rating
            // 
            this.pb_Dennis_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_Dennis_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_Dennis_Rating.Location = new System.Drawing.Point(330, 12);
            this.pb_Dennis_Rating.Name = "pb_Dennis_Rating";
            this.pb_Dennis_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_Dennis_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Dennis_Rating.TabIndex = 14;
            this.pb_Dennis_Rating.TabStop = false;
            // 
            // pb_Jeroen_Rating
            // 
            this.pb_Jeroen_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_Jeroen_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_Jeroen_Rating.Location = new System.Drawing.Point(521, 12);
            this.pb_Jeroen_Rating.Name = "pb_Jeroen_Rating";
            this.pb_Jeroen_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_Jeroen_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Jeroen_Rating.TabIndex = 15;
            this.pb_Jeroen_Rating.TabStop = false;
            // 
            // pb_John_Rating
            // 
            this.pb_John_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_John_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_John_Rating.Location = new System.Drawing.Point(140, 183);
            this.pb_John_Rating.Name = "pb_John_Rating";
            this.pb_John_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_John_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_John_Rating.TabIndex = 16;
            this.pb_John_Rating.TabStop = false;
            // 
            // pb_Mark_Rating
            // 
            this.pb_Mark_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_Mark_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_Mark_Rating.Location = new System.Drawing.Point(330, 183);
            this.pb_Mark_Rating.Name = "pb_Mark_Rating";
            this.pb_Mark_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_Mark_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Mark_Rating.TabIndex = 17;
            this.pb_Mark_Rating.TabStop = false;
            // 
            // pb_Ricky_Rating
            // 
            this.pb_Ricky_Rating.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ricky_Rating.Image = global::SMProofOfConcept.Properties.Resources.Circle;
            this.pb_Ricky_Rating.Location = new System.Drawing.Point(521, 183);
            this.pb_Ricky_Rating.Name = "pb_Ricky_Rating";
            this.pb_Ricky_Rating.Size = new System.Drawing.Size(57, 57);
            this.pb_Ricky_Rating.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_Ricky_Rating.TabIndex = 18;
            this.pb_Ricky_Rating.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SelectToGiveFeedbackToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 430);
            this.Controls.Add(this.pb_Ricky_Rating);
            this.Controls.Add(this.pb_Mark_Rating);
            this.Controls.Add(this.pb_John_Rating);
            this.Controls.Add(this.pb_Jeroen_Rating);
            this.Controls.Add(this.pb_Dennis_Rating);
            this.Controls.Add(this.pb_Cas_Rating);
            this.Controls.Add(this.pb_Dennis);
            this.Controls.Add(this.pb_Jeroen);
            this.Controls.Add(this.pb_Ricky);
            this.Controls.Add(this.pb_Mark);
            this.Controls.Add(this.pb_John);
            this.Controls.Add(this.pb_Cas);
            this.Controls.Add(this.btn_askFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SelectToGiveFeedbackToForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectToGiveFeedbackToForm";
            this.Resize += new System.EventHandler(this.SelectToGiveFeedbackToForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dennis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Jeroen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ricky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_John)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Cas_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dennis_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Jeroen_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_John_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mark_Rating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ricky_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_askFeedback;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Open;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Afsluiten;
        private System.Windows.Forms.PictureBox pb_Cas;
        private System.Windows.Forms.PictureBox pb_John;
        private System.Windows.Forms.PictureBox pb_Mark;
        private System.Windows.Forms.PictureBox pb_Ricky;
        private System.Windows.Forms.PictureBox pb_Jeroen;
        private System.Windows.Forms.PictureBox pb_Dennis;
        private System.Windows.Forms.PictureBox pb_Cas_Rating;
        private System.Windows.Forms.PictureBox pb_Dennis_Rating;
        private System.Windows.Forms.PictureBox pb_Jeroen_Rating;
        private System.Windows.Forms.PictureBox pb_John_Rating;
        private System.Windows.Forms.PictureBox pb_Mark_Rating;
        private System.Windows.Forms.PictureBox pb_Ricky_Rating;
        private System.Windows.Forms.Timer timer1;
    }
}