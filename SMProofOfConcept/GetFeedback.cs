using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes.Database;
using Newtonsoft.Json;

namespace SMProofOfConcept
{
    public partial class GetFeedback : Form
    {
        private DatabaseLogin login;
        public GetFeedback(DatabaseLogin login)
        {
            InitializeComponent();
            this.login = login;
            lb_From.Text = "";
            lb_Date.Text = "";
            lb_Category.Text = "";

            GetFeedbackFromDatabase();

        }

        private void GetFeedbackFromDatabase()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            string query = "SELECT * FROM SMFeedback WHERE SendTo = '";
            query += login.Username + "'";

            string jsonString = dbCon.sendQuery(query);
            DatabaseFeedback[] dbFeedback = JsonConvert.DeserializeObject<DatabaseFeedback[]>(jsonString);

            UpdateListBox(dbFeedback);
        }

        private void UpdateListBox(DatabaseFeedback[] dbFeedback)
        {
            lbx_Feedback.Items.Clear();
            List<DatabaseFeedback> feedbackList = dbFeedback.ToList();

            feedbackList.Sort((x, y) => x.ToString().CompareTo(y.ToString()));

            for (int i = feedbackList.Count; i>0; i--)
            {
                lbx_Feedback.Items.Add(feedbackList[i - 1]);
            }

        }

        private void lbx_Feedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseFeedback dbFeedback = (DatabaseFeedback)lbx_Feedback.SelectedItem;
            lb_From.Text = dbFeedback.SendFrom;
            lb_Date.Text = dbFeedback.DateTime;
            lb_Category.Text = dbFeedback.Category;
            tb_Details.Text = dbFeedback.Feedback;
        }

        private void btn_Verwijder_Click(object sender, EventArgs e)
        {

        }
    }

    public class DatabaseFeedback
    {
        public string SendTo { get; set; }
        public string SendFrom { get; set; }
        public string Feedback { get; set; }
        public string Category { get; set; }
        public string DateTime { get; set; }

        public override string ToString()
        {
            return DateTime + ", " + SendFrom + ", " + Category;
        }
    }
}
