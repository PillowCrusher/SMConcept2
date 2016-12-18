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
    public partial class Profile : Form
    {
        private string profileName;
        private RatingLogic ratingLogic;
        private DatabaseLogin login;
        private ProfileLogic profileLogic;
        public Profile(DatabaseLogin login, string profileName)
        {
            InitializeComponent();
            this.profileName = profileName;
            this.login = login;

            if(login.Username != profileName)
            {
                btn_Vaardigheden.Visible = false;
                btn_Verantwoordelijkheden.Visible = false;
            }

            lb_Naam.Text = profileName;
            ratingLogic = new RatingLogic();
            profileLogic = new ProfileLogic();
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            PaintRating(pb_Rating, ratingLogic.getRating(profileName), 30);
            PaintRating(pb_Inzet, ratingLogic.getRating(profileName, CategoryType.Inzet), 15);
            PaintRating(pb_Samenwerking, ratingLogic.getRating(profileName, CategoryType.Samenwerken), 15);
            PaintRating(pb_Programmeren, ratingLogic.getRating(profileName, CategoryType.Programmeren), 15);
            PaintRating(pb_Concepting, ratingLogic.getRating(profileName, CategoryType.Concepten), 15);
            PaintRating(pb_Onderzoeken, ratingLogic.getRating(profileName, CategoryType.Onderzoek), 15);

            UpdateSkills();
        }

        private void UpdateSkills()
        {
            List<PictureBox> pb_Skills = new List<PictureBox>(){pb_Vaardigheid_1, pb_Vaardigheid_2, pb_Vaardigheid_3, pb_Vaardigheid_4, pb_Vaardigheid_5};
            List<DatabaseSkill> skills = profileLogic.GetSkills(profileName).ToList();
            Skill skillEnum;
            for (int i = 0; i < 5; i++)
            {
                if (i > skills.Count - 1)
                {
                    pb_Skills[i].Image = Properties.Resources.Blauw_vierkant;
                }
                else
                { 
                    Enum.TryParse(skills[i].Skill, out skillEnum);
                    pb_Skills[i].Image = GetSkillImage(skillEnum);
                }
            }
        }
        private Bitmap GetSkillImage(Skill skill)
        {
            switch (skill)
            {
                case Skill.C:
                    return Properties.Resources.C;
                case Skill.CSharp:
                    return Properties.Resources.c_;
                case Skill.Java:
                    return Properties.Resources.java;
                case Skill.Web:
                    return Properties.Resources.web;
                case Skill.Concept:
                    return Properties.Resources.concepting;
                case Skill.Database:
                    return Properties.Resources.database;
                case Skill.Research:
                    return Properties.Resources.research;
                case Skill.UI:
                    return Properties.Resources.UX;
                default:
                    return null;
            }
        }

        private void PaintRating(PictureBox pb, string text, int fontSize)
        {
            pb.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                Font newFont = new Font(Font.FontFamily.Name, fontSize);

                SizeF textSize = e.Graphics.MeasureString(text, newFont);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pb.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pb.Height / 2) - (textSize.Height / 2);

                e.Graphics.DrawString(text, newFont, Brushes.Black, locationToDraw);
            });
        }



        private void btn_Verantwoordelijkheden_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vaardigheden_Click(object sender, EventArgs e)
        {
            SelecteerVaardigheden svForm = new SelecteerVaardigheden(profileName);
            svForm.FormClosed += SkillFormClosed;
            svForm.ShowDialog();         
        }

        private void SkillFormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateSkills();
        }

        private void btn_Statistieken_Click(object sender, EventArgs e)
        {

        }
    }
}
