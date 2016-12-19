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
using SMProofOfConcept.Classes.Logic;

namespace SMProofOfConcept
{
    public partial class SelecteerVerantwoordelijkheden : Form
    {
        private List<DatabaseResponsibility> dbResponsibilities;
        private ProfileLogic profileLogic;
        private string name;
        public SelecteerVerantwoordelijkheden(string name)
        {
            InitializeComponent();
            this.name = name;
            profileLogic = new ProfileLogic();
            dbResponsibilities = profileLogic.GetResponsibilities(name).ToList();
            InitializeScreen();
        }

        private void InitializeScreen()
        {
            SetCheckLocationAndVisability(pb_Database, pb_Check_Database);
            SetCheckLocationAndVisability(pb_File, pb_Check_File);
            SetCheckLocationAndVisability(pb_Git, pb_Check_Git);
            SetCheckLocationAndVisability(pb_ICT, pb_Check_ICT);
            SetCheckLocationAndVisability(pb_Scrum, pb_Check_Scrum);
            SetCheckLocationAndVisability(pb_Schedule, pb_Check_Schedule);
            SetCheckLocationAndVisability(pb_Food, pb_Check_Food);
            SetCheckLocationAndVisability(pb_Mood, pb_Check_Mood);

            InitializeChecks();
        }

        private void InitializeChecks()
        {
            Responsibility respons;
            foreach (DatabaseResponsibility dbRespons in dbResponsibilities)
            {
                Enum.TryParse(dbRespons.Responsibility, out respons);
                switch (respons)
                {
                    case Responsibility.Database:
                        pb_Check_Database.Visible = true;
                        break;
                    case Responsibility.File:
                        pb_Check_File.Visible = true;
                        break;
                    case Responsibility.Git:
                        pb_Check_Git.Visible = true;
                        break;
                    case Responsibility.ICT:
                        pb_Check_ICT.Visible = true;
                        break;
                    case Responsibility.Scrum:
                        pb_Check_Scrum.Visible = true;
                        break;
                    case Responsibility.Schedule:
                        pb_Check_Schedule.Visible = true;
                        break;
                    case Responsibility.Food:
                        pb_Check_Food.Visible = true;
                        break;
                    case Responsibility.Mood:
                        pb_Check_Mood.Visible = true;
                        break;
                }
            }
        }

        private void SetCheckLocationAndVisability(PictureBox parent, PictureBox check)
        {
            check.Parent = parent;
            check.Location = new Point(check.Location.X - parent.Location.X, check.Location.Y - parent.Location.Y);
            check.Visible = false;
        }

        private void HandlePictureBoxClick(PictureBox pbCheck, Responsibility respons)
        {
            if (dbResponsibilities.Count == 5 && pbCheck.Visible == false)
            {
                MessageBox.Show("Je kunt maximaal 5 vaardigheden selecteren");
                return;
            }

            if (pbCheck.Visible)
            {
                DatabaseResponsibility dbRespons = new DatabaseResponsibility();
                foreach (DatabaseResponsibility s in dbResponsibilities)
                {
                    if (s.Responsibility == respons.ToString())
                    {
                        dbRespons = s;
                        break;
                    }
                }

                dbResponsibilities.Remove(dbRespons);
                pbCheck.Visible = false;
            }
            else
            {
                DatabaseResponsibility dbRespons = new DatabaseResponsibility();
                dbRespons.Name = name;
                dbRespons.Responsibility = respons.ToString();
                dbResponsibilities.Add(dbRespons);
                pbCheck.Visible = true;
            }
        }

        private void pb_Database_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Database, Responsibility.Database);
        }

        private void pb_File_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_File, Responsibility.File);
        }

        private void pb_Git_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Git, Responsibility.Git);
        }

        private void pb_ICT_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_ICT, Responsibility.ICT);
        }

        private void pb_Scrum_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Scrum, Responsibility.Scrum);
        }

        private void pb_Schedule_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Schedule, Responsibility.Schedule);
        }

        private void pb_Food_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Food, Responsibility.Food);
        }

        private void pb_Mood_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Mood, Responsibility.Mood);
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            profileLogic.SafeResponsibilities(dbResponsibilities, name);
            Close();
        }
    }
}
