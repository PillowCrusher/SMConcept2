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
using SMProofOfConcept.Classes.Database;

namespace SMProofOfConcept
{
    public partial class SelectToGiveFeedbackToForm : Form
    {
        private DatabaseLogin login;
        private RatingLogic ratingLogic;
        private FeedbackLogic feedbackLogic;
        private Form1 loginForm;
        private string contextMenuName = "";
        private static int fontSize = 9;
        private PictureBox pb_FeedbackCount;

        public SelectToGiveFeedbackToForm(DatabaseLogin login, Form1 loginForm)
        {
            InitializeComponent();
            this.login = login;
            ratingLogic = new RatingLogic();
            feedbackLogic = new FeedbackLogic(login);
            InitializeScreen();
            this.loginForm = loginForm;
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



            InitializeFeedbackCount();
            UpdateRatings();
            //UpdateFeedbackCount();
            timer1.Start();
        }

        private void InitializeFeedbackCount()
        {
            pb_Cas_Feedback.Visible = false;
            pb_Dennis_Feedback.Visible = false;
            pb_Jeroen_Feedback.Visible = false;
            pb_John_Feedback.Visible = false;
            pb_Mark_Feedback.Visible = false;
            pb_Ricky_Feedback.Visible = false;

            switch (login.Username)
            {
                case "Cas":
                    pb_Cas_Feedback.Visible = true;
                    pb_Cas_Feedback.Parent = pb_Cas;
                    pb_Cas_Feedback.Location = new Point(pb_Cas_Feedback.Location.X - pb_Cas.Location.X, pb_Cas_Feedback.Location.Y - pb_Cas.Location.Y);
                    pb_FeedbackCount = pb_Cas_Feedback;
                    break;
                case "Dennis":
                    pb_Dennis_Feedback.Visible = true;
                    pb_Dennis_Feedback.Parent = pb_Dennis;
                    pb_Dennis_Feedback.Location = new Point(pb_Dennis_Feedback.Location.X - pb_Dennis.Location.X, pb_Dennis_Feedback.Location.Y - pb_Dennis.Location.Y);
                    pb_FeedbackCount = pb_Dennis_Feedback;
                    break;
                case "Jeroen":
                    pb_Jeroen_Feedback.Visible = true;
                    pb_Jeroen_Feedback.Parent = pb_Jeroen;
                    pb_Jeroen_Feedback.Location = new Point(pb_Jeroen_Feedback.Location.X - pb_Jeroen.Location.X, pb_Jeroen_Feedback.Location.Y - pb_Jeroen.Location.Y);
                    pb_FeedbackCount = pb_Jeroen_Feedback;
                    break;
                case "John":
                    pb_John_Feedback.Visible = true;
                    pb_John_Feedback.Parent = pb_John;
                    pb_John_Feedback.Location = new Point(pb_John_Feedback.Location.X - pb_John.Location.X, pb_John_Feedback.Location.Y - pb_John.Location.Y);
                    pb_FeedbackCount = pb_John_Feedback;
                    break;
                case "Mark":
                    pb_Mark_Feedback.Visible = true;
                    pb_Mark_Feedback.Parent = pb_Mark;
                    pb_Mark_Feedback.Location = new Point(pb_Mark_Feedback.Location.X - pb_Mark.Location.X, pb_Mark_Feedback.Location.Y - pb_Mark.Location.Y);
                    pb_FeedbackCount = pb_Mark_Feedback;
                    break;
                case "Ricky":
                    pb_Ricky_Feedback.Visible = true;
                    pb_Ricky_Feedback.Parent = pb_Ricky;
                    pb_Ricky_Feedback.Location = new Point(pb_Ricky_Feedback.Location.X - pb_Ricky.Location.X, pb_Ricky_Feedback.Location.Y - pb_Ricky.Location.Y);
                    pb_FeedbackCount = pb_Ricky_Feedback;
                    break;
                default:
                    break;
            }
        }

        private void UpdateRatings()
        {
            pb_Cas_Rating.Invalidate();
            pb_Dennis_Rating.Invalidate();
            pb_Jeroen_Rating.Invalidate();
            pb_John_Rating.Invalidate();
            pb_Mark_Rating.Invalidate();
            pb_Ricky_Rating.Invalidate();
        }

        private void UpdateFeedbackCount()
        {
            pb_FeedbackCount.Invalidate();
        }
               

        private void btn_askFeedback_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            if (dbCon.dbCheckConnection() == true)
            {
                RequireFeedback requireFeedbackForm = new RequireFeedback(login);
                requireFeedbackForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("please check your internet connection");
            }
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
            contextMenuName = "Cas";

            if(login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Dennis_Click(object sender, EventArgs e)
        {
            contextMenuName = "Dennis";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Jeroen_Click(object sender, EventArgs e)
        {
            contextMenuName = "Jeroen";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_John_Click(object sender, EventArgs e)
        {
            contextMenuName = "John";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Mark_Click(object sender, EventArgs e)
        {
            contextMenuName = "Mark";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Ricky_Click(object sender, EventArgs e)
        {
            contextMenuName = "Ricky";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshRequireFeedback();
        }

        private void pb_Cas_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "Cas";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Dennis_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "Dennis";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Jeroen_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "Jeroen";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_John_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "John";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Mark_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "Mark";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void pb_Ricky_Rating_Click(object sender, EventArgs e)
        {
            contextMenuName = "Ricky";

            if (login.Username == contextMenuName)
            {
                tsmi_Geef_Feedback.Text = "Jouw feedback";
            }
            else
            {
                tsmi_Geef_Feedback.Text = "Geef feedback";
            }

            cms_Profile_Menu.Show(Cursor.Position);
        }

        private void tsmi_Log_Uit_Click(object sender, EventArgs e)
        {
            loginForm.PeopleForm = this;        
            loginForm.Closed += (s, args) => Close();
            loginForm.Show();
            notifyIcon1.Dispose();

            this.Close();
        }

        private void tsmi_Profiel_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(login, contextMenuName);
            profileForm.ShowDialog();
        }

        private void tsmi_Geef_Feedback_Click(object sender, EventArgs e)
        {
            if (login.Username == contextMenuName)
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                if (dbCon.dbCheckConnection() == true)
                {
                    GetFeedback feedbackForm = new GetFeedback(login);
                    feedbackForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("check internet connection");
                }

            }
            else
            {
                DatabaseConnection dbCon = new DatabaseConnection();
                if (dbCon.dbCheckConnection() == true)
                {
                    GiveFeedback feedbackForm = new GiveFeedback(login, contextMenuName);
                    feedbackForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("please check your internet connection");
                }
            }
        }

        private void tsmi_Ververs_Click(object sender, EventArgs e)
        {
            RefreshRequireFeedback();
            UpdateRatings();
            UpdateFeedbackCount();
        }

        private void RefreshRequireFeedback()
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            if (dbCon.dbCheckConnection() == true)
            {
                if (feedbackLogic.DoPeopleWantFeedback())
                {
                    DatabaseRequireFeedback[] dbRequireFb = feedbackLogic.GetRequireFeedback(login.Username);
                    string message = "";
                    foreach (DatabaseRequireFeedback dbReqFb in dbRequireFb)
                    {
                        if (dbReqFb.IsShown == false.ToString())
                        {
                            message += dbReqFb.AskedFrom;
                            message += " wil graag feedback in de categorie ";
                            message += dbReqFb.Category;
                            message += "\n";
                        }
                    }
                    feedbackLogic.SetRequireFeedbackIsShown(dbRequireFb, true);

                    if (message != "")
                    {
                        UpdateFeedbackCount();
                        MessageBox.Show(new Form { TopMost = true }, message, "Feedback aanvragen", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
        }

        private void tsmi_Geef_Rating_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            if (dbCon.dbCheckConnection() == true)
            {
                AddRating addRatingFrom = new AddRating(login, contextMenuName);
                addRatingFrom.FormClosed += AddRatingFormClosed;
                addRatingFrom.ShowDialog();           
            }
            else
            {
                MessageBox.Show("please check your internet connection");
            }
        }

        private void AddRatingFormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateRatings();
        }

        private void PaintRating(PictureBox pb, string text, int fSize, PaintEventArgs e)
        {
            Font f = Font;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            Font newFont = new Font(Font.FontFamily.Name, fSize);
            SizeF textSize = e.Graphics.MeasureString(text, newFont);
            PointF locationToDraw = new PointF();
            locationToDraw.X = (pb.Width / 2) - (textSize.Width / 2);
            locationToDraw.Y = (pb.Height / 2) - (textSize.Height / 2);
            e.Graphics.DrawString(text, newFont, Brushes.Black, locationToDraw);
        }

        private void pb_Cas_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Cas_Rating, ratingLogic.getRating("Cas"), fontSize, e);
        }

        private void pb_Dennis_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Dennis_Rating, ratingLogic.getRating("Dennis"), fontSize, e);
        }

        private void pb_Jeroen_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Jeroen_Rating, ratingLogic.getRating("Jeroen"), fontSize, e);
        }

        private void pb_John_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Jeroen_Rating, ratingLogic.getRating("John"), fontSize, e);
        }

        private void pb_Mark_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Mark_Rating, ratingLogic.getRating("Mark"), fontSize, e);
        }

        private void pb_Ricky_Rating_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Ricky_Rating, ratingLogic.getRating("Ricky"), fontSize, e);
        }

        private void pb_Cas_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Cas_Feedback, feedbackLogic.GetRequireFeedback("Cas").Count().ToString(), fontSize, e);
        }

        private void pb_Dennis_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Dennis_Feedback, feedbackLogic.GetRequireFeedback("Dennis").Count().ToString(), fontSize, e);
        }

        private void pb_Jeroen_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Jeroen_Feedback, feedbackLogic.GetRequireFeedback("Jeroen").Count().ToString(), fontSize, e);
        }

        private void pb_John_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_John_Feedback, feedbackLogic.GetRequireFeedback("John").Count().ToString(), fontSize, e);
        }

        private void pb_Mark_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Mark_Feedback, feedbackLogic.GetRequireFeedback("Mark").Count().ToString(), fontSize, e);
        }

        private void pb_Ricky_Feedback_Paint(object sender, PaintEventArgs e)
        {
            PaintRating(pb_Ricky_Feedback, feedbackLogic.GetRequireFeedback("Ricky").Count().ToString(), fontSize, e);
        }

        private void pb_Cas_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void pb_Dennis_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void pb_Jeroen_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void pb_John_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void pb_Mark_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void pb_Ricky_Feedback_Click(object sender, EventArgs e)
        {
            GetRequireFeedback getRequireFeedbackForm = new GetRequireFeedback(login);
            getRequireFeedbackForm.FormClosed += GetRequireFeedbackForm_FormClosed;
            getRequireFeedbackForm.ShowDialog();
        }

        private void GetRequireFeedbackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateFeedbackCount();
        }
    }
}
