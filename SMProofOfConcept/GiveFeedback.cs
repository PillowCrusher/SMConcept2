﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes.Model;
using SMProofOfConcept.Classes.Database;

namespace SMProofOfConcept
{
    public partial class GiveFeedback : Form
    {
        private DatabaseLogin login;
        private string sendTo;
        public event EventHandler isConfirmed;
        public GiveFeedback(DatabaseLogin login, string sendTo)
        {
            this.login = login;
            this.sendTo = sendTo;
            InitializeComponent();
            lb_Name.Text = "Geef feedback aan " + sendTo;
        }

        public GiveFeedback(DatabaseLogin login, string sendTo, CategoryType category)
        {
            this.login = login;
            this.sendTo = sendTo;
            InitializeComponent();
            lb_Name.Text = "Geef feedback aan " + sendTo;
            SetCategoryRadioButton(category);
        }

        private void SetCategoryRadioButton(CategoryType category)
        {
            switch(category)
            {
                case CategoryType.Inzet:
                    rdb_Inzet.Checked = true;
                    break;
                case CategoryType.Samenwerken:
                    rdb_Samenwerken.Checked = true;
                    break;
                case CategoryType.Programmeren:
                    rdb_Programmeren.Checked = true;
                    break;
                case CategoryType.Concepten:
                    rdb_Concepten.Checked = true;
                    break;
                case CategoryType.Onderzoek:
                    rdb_Research.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryType cat;
            string Query;
            DatabaseConnection db = new DatabaseConnection();

            if (db.dbCheckConnection() == true)
            {
                if (rdb_Concepten.Checked == true)
                {
                    cat = CategoryType.Concepten;
                }
                else if (rdb_Inzet.Checked == true)
                {
                    cat = CategoryType.Inzet;
                }
                else if (rdb_Programmeren.Checked == true)
                {
                    cat = CategoryType.Programmeren;
                }
                else if (rdb_Research.Checked == true)
                {
                    cat = CategoryType.Onderzoek;
                }
                else if (rdb_Samenwerken.Checked == true)
                {
                    cat = CategoryType.Samenwerken;
                }
                else
                {
                    //default
                    cat = CategoryType.Inzet;
                }
                String feedbacktext = textBox1.Text;
                // SMFeedback
                // SendTo 
                // SendFrom
                // FeedBack
                // Category
                // DateTime
                Query = "INSERT INTO SMFeedback (FeedbackId,SendTo, SendFrom,FeedBack,Category,DateTime) VALUES(NULL, '";
                Query += sendTo + "','";
                Query += login.Username + "','";
                Query += feedbacktext + "','";
                Query += cat.ToString() + "','";
                Query += DateTime.Now.ToString() + "')";
                db.sendQuery(Query);
                Close();
                OnConfirm(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("please check your internet connection");
            }
        }

        protected virtual void OnConfirm(EventArgs e)
        {
            isConfirmed?.Invoke(this, e);
        }
    }
}
