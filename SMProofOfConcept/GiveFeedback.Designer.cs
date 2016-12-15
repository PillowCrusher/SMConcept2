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
            this.lb_Name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdb_Inzet
            // 
            this.rdb_Inzet.AutoSize = true;
            this.rdb_Inzet.Location = new System.Drawing.Point(34, 37);
            this.rdb_Inzet.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Inzet.Name = "rdb_Inzet";
            this.rdb_Inzet.Size = new System.Drawing.Size(48, 17);
            this.rdb_Inzet.TabIndex = 0;
            this.rdb_Inzet.TabStop = true;
            this.rdb_Inzet.Text = "Inzet";
            this.rdb_Inzet.UseVisualStyleBackColor = true;
            this.rdb_Inzet.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_Concepten
            // 
            this.rdb_Concepten.AutoSize = true;
            this.rdb_Concepten.Location = new System.Drawing.Point(192, 37);
            this.rdb_Concepten.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Concepten.Name = "rdb_Concepten";
            this.rdb_Concepten.Size = new System.Drawing.Size(77, 17);
            this.rdb_Concepten.TabIndex = 1;
            this.rdb_Concepten.TabStop = true;
            this.rdb_Concepten.Text = "Concepten";
            this.rdb_Concepten.UseVisualStyleBackColor = true;
            // 
            // rdb_Samenwerken
            // 
            this.rdb_Samenwerken.AutoSize = true;
            this.rdb_Samenwerken.Location = new System.Drawing.Point(99, 37);
            this.rdb_Samenwerken.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Samenwerken.Name = "rdb_Samenwerken";
            this.rdb_Samenwerken.Size = new System.Drawing.Size(93, 17);
            this.rdb_Samenwerken.TabIndex = 2;
            this.rdb_Samenwerken.TabStop = true;
            this.rdb_Samenwerken.Text = "Samenwerken";
            this.rdb_Samenwerken.UseVisualStyleBackColor = true;
            // 
            // rdb_Programmeren
            // 
            this.rdb_Programmeren.AutoSize = true;
            this.rdb_Programmeren.Location = new System.Drawing.Point(269, 37);
            this.rdb_Programmeren.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Programmeren.Name = "rdb_Programmeren";
            this.rdb_Programmeren.Size = new System.Drawing.Size(93, 17);
            this.rdb_Programmeren.TabIndex = 3;
            this.rdb_Programmeren.TabStop = true;
            this.rdb_Programmeren.Text = "Programmeren";
            this.rdb_Programmeren.UseVisualStyleBackColor = true;
            this.rdb_Programmeren.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdb_Research
            // 
            this.rdb_Research.AutoSize = true;
            this.rdb_Research.Location = new System.Drawing.Point(366, 37);
            this.rdb_Research.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_Research.Name = "rdb_Research";
            this.rdb_Research.Size = new System.Drawing.Size(77, 17);
            this.rdb_Research.TabIndex = 4;
            this.rdb_Research.TabStop = true;
            this.rdb_Research.Text = "Onderzoek";
            this.rdb_Research.UseVisualStyleBackColor = true;
            this.rdb_Research.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 97);
            this.textBox1.TabIndex = 5;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(208, 199);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(56, 19);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(183, 9);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(102, 13);
            this.lb_Name.TabIndex = 7;
            this.lb_Name.Text = "Geef feedback aan ";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GiveFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 236);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdb_Research);
            this.Controls.Add(this.rdb_Programmeren);
            this.Controls.Add(this.rdb_Samenwerken);
            this.Controls.Add(this.rdb_Concepten);
            this.Controls.Add(this.rdb_Inzet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "GiveFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lb_Name;
    }
}