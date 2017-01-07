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
    public partial class GetRequireFeedback : Form
    {
        private DatabaseLogin login;
        private FeedbackLogic feedbackLogic;
        public GetRequireFeedback(DatabaseLogin login)
        {
            InitializeComponent();
            this.login = login;
            feedbackLogic = new FeedbackLogic(login);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbx_RequireFeedback.Items.Clear();
            DatabaseRequireFeedback[] dbRequireFB = feedbackLogic.GetRequireFeedback(login.Username);
            foreach (DatabaseRequireFeedback requireFB in dbRequireFB)
            {
                lbx_RequireFeedback.Items.Add(requireFB);
            }
        }

        private void btn_Give_Feedback_Click(object sender, EventArgs e)
        {
            if(lbx_RequireFeedback.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteer feedback");
                return;
            }

            DatabaseRequireFeedback requireFB = (DatabaseRequireFeedback)lbx_RequireFeedback.SelectedItem;
            CategoryType category;
            Enum.TryParse(requireFB.Category, out category);
            GiveFeedback giveFeedbackForm = new GiveFeedback(login, requireFB.AskedFrom, category);
            giveFeedbackForm.isConfirmed += GiveFeedbackForm_isConfirmed;
            giveFeedbackForm.ShowDialog();
        }

        private void GiveFeedbackForm_isConfirmed(object sender, EventArgs e)
        {
            feedbackLogic.DeleteRequireFeedback((DatabaseRequireFeedback)lbx_RequireFeedback.SelectedItem);
            UpdateListBox();
        }
    }
}
