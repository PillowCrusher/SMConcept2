using System;
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
        CategoryType cat;
        DatabaseConnection db;
        String User;
        String Receiver;
        String Query;
        
        public GiveFeedback()
        {
            InitializeComponent();
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
            if(rdb_Concepten.Checked == true)
            {
                cat = CategoryType.Concepten;
            }
            else if(rdb_Inzet.Checked == true)
            {
                cat = CategoryType.Inzet;
            }
            else if(rdb_Programmeren.Checked == true)
            {
                cat = CategoryType.Programmeren;
            }
            else if(rdb_Research.Checked == true)
            {
                cat = CategoryType.Onderzoek;
            }
            else if(rdb_Samenwerken.Checked == true)
            {
                cat = CategoryType.Samenwerken;
            }
            String feedbacktext = textBox1.Text;
            // SMFeedback
            // SendTo / SendFrom
            // FeedBack
            // DateTime
            Query = "Insert Into SMFeedback (FeedbackId,SendTo, SendFrom,FeedBack,DateTime) VALUES(NULL, '";
            Query += Receiver + "','";
            Query += User + "','";
            Query += feedbacktext + "','";
            Query += DateTime.Now.ToString() + "')";
            db.sendQuery(Query);
            Form.ActiveForm.Close();
        }
    }
}
