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
            pb_Check_C.Parent = pb_C;
            pb_Check_C.Location = new Point(pb_Check_C.Location.X - pb_C.Location.X, pb_Check_C.Location.Y - pb_C.Location.Y);
            pb_Check_C.Visible = false;

            pb_Check_Csharp.Parent = pb_csharp;
            pb_Check_Csharp.Location = new Point(pb_Check_Csharp.Location.X - pb_csharp.Location.X, pb_Check_Csharp.Location.Y - pb_csharp.Location.Y);
            pb_Check_Csharp.Visible = false;

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
                }
            }
        }

        private void HandlePictureBoxClick(PictureBox pbCheck, Skill skill)
        {
            if (dbSkills.Count == 5)
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

        }

        private void pb_Web_Click(object sender, EventArgs e)
        {

        }

        private void pb_Concepting_Click(object sender, EventArgs e)
        {

        }

        private void pb_Database_Click(object sender, EventArgs e)
        {

        }

        private void pb_Research_Click(object sender, EventArgs e)
        {

        }

        private void pb_UI_Click(object sender, EventArgs e)
        {

        }
    }
}
