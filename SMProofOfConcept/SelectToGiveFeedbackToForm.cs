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

namespace SMProofOfConcept
{
    public partial class SelectToGiveFeedbackToForm : Form
    {
        private DatabaseLogin login;
        private RatingLogic ratingLogic;
        private FeedbackLogic feedbackLogic;
        public SelectToGiveFeedbackToForm(DatabaseLogin login)
        {
            InitializeComponent();
            this.login = login;
            ratingLogic = new RatingLogic();
            feedbackLogic = new FeedbackLogic(login);
            InitializeScreen();
        }

        private void InitializeScreen()
        {
            pb_Cas_Rating.Parent = pb_Cas;
            pb_Cas_Rating.Location = new Point(pb_Cas_Rating.Location.X - pb_Cas.Location.X, pb_Cas_Rating.Location.Y - pb_Cas.Location.Y);
            pb_Dennis_Rating.Parent = pb_Dennis;
            pb_Dennis_Rating.Location = new Point(pb_Dennis_Rating.Location.X - pb_Dennis.Location.X, pb_Dennis_Rating.Location.Y - pb_Dennis.Location.Y);
            pb_Jeroen_Rating.Parent = pb_Jeroen;
            pb_Jeroen_Rating.Location = new Point(pb_Jeroen_Rating.Location.X - pb_Jeroen.Location.X, pb_Jeroen_Rating.Location.Y - pb_Jeroen.Location.Y);
            pb_John_Rating.Parent = pb_John;
            pb_John_Rating.Location = new Point(pb_John_Rating.Location.X - pb_John.Location.X, pb_John_Rating.Location.Y - pb_John.Location.Y);
            pb_Mark_Rating.Parent = pb_Mark;
            pb_Mark_Rating.Location = new Point(pb_Mark_Rating.Location.X - pb_Mark.Location.X, pb_Mark_Rating.Location.Y - pb_Mark.Location.Y);
            pb_Ricky_Rating.Parent = pb_Ricky;
            pb_Ricky_Rating.Location = new Point(pb_Ricky_Rating.Location.X - pb_Ricky.Location.X, pb_Ricky_Rating.Location.Y - pb_Ricky.Location.Y);

            UpdateRatings();
            timer1.Start();
        }

        private void UpdateRatings()
        {
            PaintRating(pb_Cas_Rating, ratingLogic.getRating("Cas"));
            PaintRating(pb_Dennis_Rating, ratingLogic.getRating("Dennis"));
            PaintRating(pb_Jeroen_Rating, ratingLogic.getRating("Jeroen"));
            PaintRating(pb_John_Rating, ratingLogic.getRating("John"));
            PaintRating(pb_Mark_Rating, ratingLogic.getRating("Mark"));
            PaintRating(pb_Ricky_Rating, ratingLogic.getRating("Ricky"));
        }

        private void PaintRating(PictureBox pb, string text)
        {
            pb.Paint += new PaintEventHandler((sender, e) =>
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                SizeF textSize = e.Graphics.MeasureString(text, Font);
                PointF locationToDraw = new PointF();
                locationToDraw.X = (pb.Width / 2) - (textSize.Width / 2);
                locationToDraw.Y = (pb.Height / 2) - (textSize.Height / 2);

                e.Graphics.DrawString(text, Font, Brushes.Black, locationToDraw);
            });
        }

        private void btn_askFeedback_Click(object sender, EventArgs e)
        {
            RequireFeedback requireFeedbackForm = new RequireFeedback(login);
            requireFeedbackForm.ShowDialog();
        }

        private void SelectToGiveFeedbackToForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }          
        }

        private void tsmi_Open_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void tsmi_Afsluiten_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                notifyIcon1.Dispose();
                return;
            }

            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void pb_Cas_Click(object sender, EventArgs e)
        {
            if (login.Username == "Cas")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "Cas");
                feedbackForm.ShowDialog();
            }
        }

        private void pb_Dennis_Click(object sender, EventArgs e)
        {
            if (login.Username == "Dennis")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "Dennis");
                feedbackForm.ShowDialog();
            }
        }

        private void pb_Jeroen_Click(object sender, EventArgs e)
        {
            if (login.Username == "Jeroen")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "Jeroen");
                feedbackForm.ShowDialog();
            }
        }

        private void pb_John_Click(object sender, EventArgs e)
        {
            if (login.Username == "John")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "John");
                feedbackForm.ShowDialog();
            }
        }

        private void pb_Mark_Click(object sender, EventArgs e)
        {
            if (login.Username == "Mark")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "Mark");
                feedbackForm.ShowDialog();
            }
        }

        private void pb_Ricky_Click(object sender, EventArgs e)
        {
            if (login.Username == "Ricky")
            {

                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();

            }
            else
            {
                GiveFeedback feedbackForm = new GiveFeedback(login, "Ricky");
                feedbackForm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(feedbackLogic.DoPeopleWantFeedback())
            {
                DatabaseRequereFeedback[] dbRequireFb = feedbackLogic.GetRequireFeedback();
                string message = "";
                foreach(DatabaseRequereFeedback dbReqFb in dbRequireFb)
                {
                    message += dbReqFb.AskedFrom;
                    message += " wil graag feedback in de categorie ";
                    message += dbReqFb.Category;
                    message += "\n";
                }
                feedbackLogic.DeleteRequireFeedback();

                MessageBox.Show(new Form { TopMost = true }, message, "Feedback aanvragen", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void pb_Cas_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "Cas") return;
            AddRating addRatingFrom = new AddRating(login, "Cas");
            addRatingFrom.ShowDialog();
        }

        private void pb_Dennis_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "Dennis") return;
            AddRating addRatingFrom = new AddRating(login, "Dennis");
            addRatingFrom.ShowDialog();
        }

        private void pb_Jeroen_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "Jeroen") return;
            AddRating addRatingFrom = new AddRating(login, "Jeroen");
            addRatingFrom.ShowDialog();
        }

        private void pb_John_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "John") return;
            AddRating addRatingFrom = new AddRating(login, "John");
            addRatingFrom.ShowDialog();
        }

        private void pb_Mark_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "Mark") return;
            AddRating addRatingFrom = new AddRating(login, "Mark");
            addRatingFrom.ShowDialog();
        }

        private void pb_Ricky_Rating_Click(object sender, EventArgs e)
        {
            if (login.Username == "Ricky") return;
            AddRating addRatingFrom = new AddRating(login, "Ricky");
            addRatingFrom.ShowDialog();
        }
    }
}
