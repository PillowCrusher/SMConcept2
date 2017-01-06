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
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept
{
    public partial class RequireFeedback : Form
    {
        private string username;
        public RequireFeedback(DatabaseLogin login)
        {
            InitializeComponent();
            username = login.Username;
            UpdateScreen(login.Username);
        }

        private void UpdateScreen(string name)
        {
            List<Names> listNames = new List<Names>();
            if (Names.Cas.ToString() != name) listNames.Add(Names.Cas);
            if (Names.Dennis.ToString() != name) listNames.Add(Names.Dennis);
            if (Names.Mark.ToString() != name) listNames.Add(Names.Mark);
            if (Names.Ricky.ToString() != name) listNames.Add(Names.Ricky);
            if (Names.Jeroen.ToString() != name) listNames.Add(Names.Jeroen);
            if (Names.John.ToString() != name) listNames.Add(Names.John);

            cb_Name1.Text = listNames[0].ToString();
            cb_Name2.Text = listNames[1].ToString();
            cb_Name3.Text = listNames[2].ToString();
            cb_Name4.Text = listNames[3].ToString();
            cb_Name5.Text = listNames[4].ToString();
        }

        private void btn_Aanvragen_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            string query = "INSERT INTO SMRequireFeedback (RequireFeedbackId, AskedFrom, AskedTo, Category, Question, IsShown) VALUES (NULL, '";

            List<string> names = GetNames();
            List<string> categories = GetCategories();

            bool isFirst = true;

            foreach(string name in names)
            {
                if (categories.Count == 0)
                {
                    MessageBox.Show("Please choose at least one category");
                    return;
                }
                foreach (string categorie in categories)
                {
                    if(isFirst)
                    {
                        query += username + "', '";
                        query += name + "', '";
                        query += categorie + "', '";
                        query += "" + "', '";
                        query += "False" + "')";
                        isFirst = false;
                    }
                    else
                    {
                        query += ", (NULL, '";
                        query += username + "', '";
                        query += name + "', '";
                        query += categorie + "', '";
                        query += "" + "', '";
                        query += "False" + "')";
                    }                
                }
            }

            dbCon.sendQuery(query);
            Close();

        }

        private List<string> GetNames()
        {
            List<string> result = new List<string>();
            if (cb_Name1.Checked)
            {
                result.Add(cb_Name1.Text);
            }
            if (cb_Name2.Checked)
            {
                result.Add(cb_Name2.Text);
            }
            if (cb_Name3.Checked)
            {
                result.Add(cb_Name3.Text);
            }
            if (cb_Name4.Checked)
            {
                result.Add(cb_Name4.Text);
            }
            if (cb_Name5.Checked)
            {
                result.Add(cb_Name5.Text);
            }
            return result;
        }

        private List<string> GetCategories()
        {
            List<string> result = new List<string>();
            if (cb_Inzet.Checked)
            {
                result.Add(cb_Inzet.Text);
            }
            if (cb_Samenwerking.Checked)
            {
                result.Add(cb_Samenwerking.Text);
            }
            if (cb_Programmeren.Checked)
            {
                result.Add(cb_Programmeren.Text);
            }
            if (cb_Concepting.Checked)
            {
                result.Add(cb_Concepting.Text);
            }
            if (cb_Onderzoek.Checked)
            {
                result.Add(cb_Onderzoek.Text);
            }
            return result;
        }
    }
}
