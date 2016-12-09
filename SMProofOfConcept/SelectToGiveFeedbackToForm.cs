using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMProofOfConcept
{
    public partial class SelectToGiveFeedbackToForm : Form
    {
        private DatabaseLogin login;

        public SelectToGiveFeedbackToForm(DatabaseLogin login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (login.Username == "Ricky")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "Ricky");
                feedbackForm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (login.Username == "Cas")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "Cas");
                feedbackForm.ShowDialog();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (login.Username == "Jeroen")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "Jeroen");
                feedbackForm.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (login.Username == "Mark")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "Mark");
                feedbackForm.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (login.Username == "John")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "John");
                feedbackForm.ShowDialog();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (login.Username == "Dennis")
            {
                GetFeedback feedbackForm = new GetFeedback(login);
                feedbackForm.ShowDialog();
            }
            else
            {
                SMProofOfConcept.GiveFeedback feedbackForm = new GiveFeedback(login, "Dennis");
                feedbackForm.ShowDialog();
            }
        }


        private void btn_askFeedback_Click(object sender, EventArgs e)
        {
            RequireFeedback requireFeedbackForm = new RequireFeedback(login);
            requireFeedbackForm.ShowDialog();
        }
    }
}
