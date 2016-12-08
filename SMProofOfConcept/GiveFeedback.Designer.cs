namespace SMProofOfConcept
{
    partial class GiveFeedback
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
            this.rdb_Inzet = new System.Windows.Forms.RadioButton();
            this.rdb_Concepten = new System.Windows.Forms.RadioButton();
            this.rdb_Samenwerken = new System.Windows.Forms.RadioButton();
            this.rdb_Programmeren = new System.Windows.Forms.RadioButton();
            this.rdb_Research = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Inzet
            // 
            this.rdb_Inzet.AutoSize = true;
            this.rdb_Inzet.Location = new System.Drawing.Point(46, 46);
            this.rdb_Inzet.Name = "rdb_Inzet";
            this.rdb_Inzet.Size = new System.Drawing.Size(59, 21);
            this.rdb_Inzet.TabIndex = 0;
            this.rdb_Inzet.TabStop = true;
            this.rdb_Inzet.Text = "Inzet";
            this.rdb_Inzet.UseVisualStyleBackColor = true;
            this.rdb_Inzet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_Concepten
            // 
            this.rdb_Concepten.AutoSize = true;
            this.rdb_Concepten.Location = new System.Drawing.Point(256, 46);
            this.rdb_Concepten.Name = "rdb_Concepten";
            this.rdb_Concepten.Size = new System.Drawing.Size(97, 21);
            this.rdb_Concepten.TabIndex = 1;
            this.rdb_Concepten.TabStop = true;
            this.rdb_Concepten.Text = "Concepten";
            this.rdb_Concepten.UseVisualStyleBackColor = true;
            // 
            // rdb_Samenwerken
            // 
            this.rdb_Samenwerken.AutoSize = true;
            this.rdb_Samenwerken.Location = new System.Drawing.Point(132, 46);
            this.rdb_Samenwerken.Name = "rdb_Samenwerken";
            this.rdb_Samenwerken.Size = new System.Drawing.Size(118, 21);
            this.rdb_Samenwerken.TabIndex = 2;
            this.rdb_Samenwerken.TabStop = true;
            this.rdb_Samenwerken.Text = "Samenwerken";
            this.rdb_Samenwerken.UseVisualStyleBackColor = true;
            // 
            // rdb_Programmeren
            // 
            this.rdb_Programmeren.AutoSize = true;
            this.rdb_Programmeren.Location = new System.Drawing.Point(359, 46);
            this.rdb_Programmeren.Name = "rdb_Programmeren";
            this.rdb_Programmeren.Size = new System.Drawing.Size(123, 21);
            this.rdb_Programmeren.TabIndex = 3;
            this.rdb_Programmeren.TabStop = true;
            this.rdb_Programmeren.Text = "Programmeren";
            this.rdb_Programmeren.UseVisualStyleBackColor = true;
            this.rdb_Programmeren.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdb_Research
            // 
            this.rdb_Research.AutoSize = true;
            this.rdb_Research.Location = new System.Drawing.Point(488, 46);
            this.rdb_Research.Name = "rdb_Research";
            this.rdb_Research.Size = new System.Drawing.Size(99, 21);
            this.rdb_Research.TabIndex = 4;
            this.rdb_Research.TabStop = true;
            this.rdb_Research.Text = "Onderzoek";
            this.rdb_Research.UseVisualStyleBackColor = true;
            this.rdb_Research.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(541, 118);
            this.textBox1.TabIndex = 5;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(278, 245);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // GiveFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 291);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdb_Research);
            this.Controls.Add(this.rdb_Programmeren);
            this.Controls.Add(this.rdb_Samenwerken);
            this.Controls.Add(this.rdb_Concepten);
            this.Controls.Add(this.rdb_Inzet);
            this.Name = "GiveFeedback";
            this.Text = "GiveFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Inzet;
        private System.Windows.Forms.RadioButton rdb_Concepten;
        private System.Windows.Forms.RadioButton rdb_Samenwerken;
        private System.Windows.Forms.RadioButton rdb_Programmeren;
        private System.Windows.Forms.RadioButton rdb_Research;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Confirm;
    }
}