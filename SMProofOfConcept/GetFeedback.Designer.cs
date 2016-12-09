namespace SMProofOfConcept
{
    partial class GetFeedback
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
            this.lbx_Feedback = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_From = new System.Windows.Forms.Label();
            this.lb_Date = new System.Windows.Forms.Label();
            this.lb_Category = new System.Windows.Forms.Label();
            this.tb_Details = new System.Windows.Forms.TextBox();
            this.btn_Verwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_Feedback
            // 
            this.lbx_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Feedback.FormattingEnabled = true;
            this.lbx_Feedback.ItemHeight = 16;
            this.lbx_Feedback.Location = new System.Drawing.Point(0, -1);
            this.lbx_Feedback.Name = "lbx_Feedback";
            this.lbx_Feedback.Size = new System.Drawing.Size(281, 644);
            this.lbx_Feedback.TabIndex = 0;
            this.lbx_Feedback.SelectedIndexChanged += new System.EventHandler(this.lbx_Feedback_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Details:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_From
            // 
            this.lb_From.AutoSize = true;
            this.lb_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(466, 20);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(85, 31);
            this.lb_From.TabIndex = 5;
            this.lb_From.Text = "From:";
            this.lb_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.Location = new System.Drawing.Point(466, 60);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(85, 31);
            this.lb_Date.TabIndex = 6;
            this.lb_Date.Text = "From:";
            this.lb_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Category
            // 
            this.lb_Category.AutoSize = true;
            this.lb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Category.Location = new System.Drawing.Point(466, 100);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(85, 31);
            this.lb_Category.TabIndex = 7;
            this.lb_Category.Text = "From:";
            this.lb_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Details
            // 
            this.tb_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Details.Location = new System.Drawing.Point(304, 180);
            this.tb_Details.Multiline = true;
            this.tb_Details.Name = "tb_Details";
            this.tb_Details.ReadOnly = true;
            this.tb_Details.Size = new System.Drawing.Size(686, 463);
            this.tb_Details.TabIndex = 8;
            // 
            // btn_Verwijder
            // 
            this.btn_Verwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Verwijder.Location = new System.Drawing.Point(801, 20);
            this.btn_Verwijder.Name = "btn_Verwijder";
            this.btn_Verwijder.Size = new System.Drawing.Size(189, 151);
            this.btn_Verwijder.TabIndex = 9;
            this.btn_Verwijder.Text = "Verwijder";
            this.btn_Verwijder.UseVisualStyleBackColor = true;
            this.btn_Verwijder.Click += new System.EventHandler(this.btn_Verwijder_Click);
            // 
            // GetFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 643);
            this.Controls.Add(this.btn_Verwijder);
            this.Controls.Add(this.tb_Details);
            this.Controls.Add(this.lb_Category);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_From);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_Feedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GetFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_Feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.TextBox tb_Details;
        private System.Windows.Forms.Button btn_Verwijder;
    }
}