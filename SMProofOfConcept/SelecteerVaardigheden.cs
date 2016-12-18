using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMProofOfConcept.Classes.Logic;
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept
{
    public partial class SelecteerVaardigheden : Form
    {
        private List<DatabaseSkill> dbSkills;
        private ProfileLogic profileLogic;
        private string name;
        public SelecteerVaardigheden(string name)
        {
            InitializeComponent();
            this.name = name;
            profileLogic = new ProfileLogic();
            dbSkills = profileLogic.GetSkills(name).ToList();
            InitializeScreen();
        }

        private void InitializeScreen()
        {
            SetCheckLocationAndVisability(pb_C, pb_Check_C);
            SetCheckLocationAndVisability(pb_csharp, pb_Check_Csharp);
            SetCheckLocationAndVisability(pb_Java, pb_Check_Java);
            SetCheckLocationAndVisability(pb_Web, pb_Check_Web);
            SetCheckLocationAndVisability(pb_Concepting, pb_Check_Concepting);
            SetCheckLocationAndVisability(pb_Database, pb_Check_Database);
            SetCheckLocationAndVisability(pb_Research, pb_Check_Research);
            SetCheckLocationAndVisability(pb_UI, pb_Check_UI);
            
            InitializeChecks();
        }

        private void InitializeChecks()
        {
            Skill skill;
            foreach(DatabaseSkill dbskill in dbSkills)
            {           
                Enum.TryParse(dbskill.Skill, out skill);
                switch (skill)
                {
                    case Skill.C:
                        pb_Check_C.Visible = true;
                        break;
                    case Skill.CSharp:
                        pb_Check_Csharp.Visible = true;
                        break;
                    case Skill.Java:
                        pb_Check_Java.Visible = true;
                        break;
                    case Skill.Web:
                        pb_Check_Web.Visible = true;
                        break;
                    case Skill.Concept:
                        pb_Check_Concepting.Visible = true;
                        break;
                    case Skill.Database:
                        pb_Check_Database.Visible = true;
                        break;
                    case Skill.Research:
                        pb_Check_Research.Visible = true;
                        break;
                    case Skill.UI:
                        pb_Check_UI.Visible = true;
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

        private void HandlePictureBoxClick(PictureBox pbCheck, Skill skill)
        {
            if (dbSkills.Count == 5 && pbCheck.Visible == false)
            {
                MessageBox.Show("Je kunt maximaal 5 vaardigheden selecteren");
                return;
            }

            if (pbCheck.Visible)
            {
                DatabaseSkill dbskill = new DatabaseSkill();
                foreach (DatabaseSkill s in dbSkills)
                {
                    if (s.Skill == skill.ToString())
                    {
                        dbskill = s;
                        break;
                    }
                }

                dbSkills.Remove(dbskill);
                pbCheck.Visible = false;
            }
            else
            {
                DatabaseSkill dbskill = new DatabaseSkill();
                dbskill.Name = name;
                dbskill.Skill = skill.ToString();
                dbSkills.Add(dbskill);
                pbCheck.Visible = true;
            }
        }

        private void pb_C_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_C, Skill.C);            
        }

        private void pb_csharp_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Csharp, Skill.CSharp);
        }

        private void pb_Java_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Java, Skill.Java);
        }

        private void pb_Web_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Web, Skill.Web);
        }

        private void pb_Concepting_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Concepting, Skill.Concept);
        }

        private void pb_Database_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Database, Skill.Database);
        }

        private void pb_Research_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_Research, Skill.Research);
        }

        private void pb_UI_Click(object sender, EventArgs e)
        {
            HandlePictureBoxClick(pb_Check_UI, Skill.UI);
        }

        private void btn_Opslaan_Click(object sender, EventArgs e)
        {
            profileLogic.SafeSkills(dbSkills, name);
            Close();
        }
    }
}
