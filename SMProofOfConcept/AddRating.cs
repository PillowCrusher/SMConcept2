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
    public partial class AddRating : Form
    {
        private DatabaseLogin login;
        private FeedbackLogic feedbackLogic;
        private string giveRatingTo;
        public AddRating(DatabaseLogin login, string giveRatingTo)
        {
            InitializeComponent();
            this.login = login;
            this.giveRatingTo = giveRatingTo;
            feedbackLogic = new FeedbackLogic(login);

            lb_Name.Text += " " + giveRatingTo;
        }

        private void btn_Geef_Rating_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbCon = new DatabaseConnection();
            if (dbCon.dbCheckConnection() == true)
            {
                List<DatabaseRating> ratings = GetRatings();
                if (ratings.Count == 0)
                {
                    MessageBox.Show("Geef tenminste op 1 categorie feedback");
                    return;
                }
                feedbackLogic.SendRatings(GetRatings());

                Close();
            }
            else
            {
                MessageBox.Show("please check your internet connection");
            }
        }

        private List<DatabaseRating> GetRatings()
        {
            List<DatabaseRating> ratings = new List<DatabaseRating>();
            if(nud_Inzet.Value >= 1)
            {
                DatabaseRating dbRating = new DatabaseRating();
                dbRating.Name = giveRatingTo;
                dbRating.Rating = nud_Inzet.Value.ToString();
                dbRating.Category = CategoryType.Inzet.ToString();
                dbRating.DateTime = DateTime.Now.ToString();
                ratings.Add(dbRating);
            }
            if (nud_Samenwerking.Value >= 1)
            {
                DatabaseRating dbRating = new DatabaseRating();
                dbRating.Name = giveRatingTo;
                dbRating.Rating = nud_Samenwerking.Value.ToString();
                dbRating.Category = CategoryType.Samenwerken.ToString();
                dbRating.DateTime = DateTime.Now.ToString();
                ratings.Add(dbRating);
            }
            if (nud_Programmeren.Value >= 1)
            {
                DatabaseRating dbRating = new DatabaseRating();
                dbRating.Name = giveRatingTo;
                dbRating.Rating = nud_Programmeren.Value.ToString();
                dbRating.Category = CategoryType.Programmeren.ToString();
                dbRating.DateTime = DateTime.Now.ToString();
                ratings.Add(dbRating);
            }
            if (nud_Concepting.Value >= 1)
            {
                DatabaseRating dbRating = new DatabaseRating();
                dbRating.Name = giveRatingTo;
                dbRating.Rating = nud_Concepting.Value.ToString();
                dbRating.Category = CategoryType.Concepten.ToString();
                dbRating.DateTime = DateTime.Now.ToString();
                ratings.Add(dbRating);
            }
            if (nud_Onderzoek.Value >= 1)
            {
                DatabaseRating dbRating = new DatabaseRating();
                dbRating.Name = giveRatingTo;
                dbRating.Rating = nud_Onderzoek.Value.ToString();
                dbRating.Category = CategoryType.Onderzoek.ToString();
                dbRating.DateTime = DateTime.Now.ToString();
                ratings.Add(dbRating);
            }
            return ratings;
        }
    }
}
