using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMProofOfConcept.Classes.Database;
using Newtonsoft.Json;

namespace SMProofOfConcept.Classes.Logic
{
    public class FeedbackLogic
    {
        private DatabaseConnection dbCon;
        private DatabaseLogin login; 

        public FeedbackLogic(DatabaseLogin login)
        {
            this.login = login;
            dbCon = new DatabaseConnection();
        }


        public FeedbackLogic()
        {
            dbCon = new DatabaseConnection();
        }
        public bool DoPeopleWantFeedback()
        {
            string query = "SELECT * FROM SMRequireFeedback WHERE AskedTo = '";
            query += login.Username + "'";

            string jsonString = dbCon.sendQuery(query);
            DatabaseRequireFeedback[] dbRequireFb = JsonConvert.DeserializeObject<DatabaseRequireFeedback[]>(jsonString);

            if(dbRequireFb.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DatabaseRequireFeedback[] GetRequireFeedback(string name)
        {
            string query = "SELECT * FROM SMRequireFeedback WHERE AskedTo = '";
            query += name + "'";

            string jsonString = dbCon.sendQuery(query);
            return JsonConvert.DeserializeObject<DatabaseRequireFeedback[]>(jsonString);   
        }

        public void SetRequireFeedbackIsShown(DatabaseRequireFeedback[] list, bool isShown)
        {
            if (list.Count() == 0) return;
            string query = "UPDATE SMRequireFeedback SET IsShown = '" + isShown.ToString() + "' WHERE ";
            bool isFirst = true;
            foreach (DatabaseRequireFeedback dbRequire in list)
            {
                if(isFirst)
                {
                    query += "RequireFeedbackId = '" + dbRequire.RequireFeedbackId + "'";
                    isFirst = false;
                }
                else
                {
                    query += " OR RequireFeedbackId = '" + dbRequire.RequireFeedbackId + "'";
                }
            }
            dbCon.sendQuery(query);
        }

        public void DeleteRequireFeedback(DatabaseRequireFeedback requireFB)
        {
            string query = "DELETE FROM SMRequireFeedback WHERE AskedFrom = '";
            query += requireFB.AskedFrom + "' AND AskedTo = '";
            query += requireFB.AskedTo + "' AND Category = '";
            query += requireFB.Category + "' AND Question = '";
            query += requireFB.Question + "' AND IsShown = '";
            query += requireFB.IsShown + "'";

            string jsonString = dbCon.sendQuery(query);
        }

        public void SendRatings(List<DatabaseRating> ratings)
        {
            int countdown = ratings.Count;
            string query = "INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (";

            foreach (DatabaseRating rating in ratings)
            {
                countdown--;
                if (countdown == 0)
                {
                    query += "NULL, '" + rating.Name + "', '" + rating.Rating + "', '" + rating.Category + "', '" +
                        DateTime.Now.ToString() + "')";
                }
                else
                {
                    query += "NULL, '" + rating.Name + "', '" + rating.Rating + "', '" + rating.Category + "', '" +
                        DateTime.Now.ToString() + "'), (";
                }
            }
            dbCon.sendQuery(query);
        }
    


    public void SendTestRatings(List<DatabaseRating> ratings)
    {
        int countdown = ratings.Count;
        string query = "INSERT INTO SMRatings (RatingId, Name, Rating, Category, DateTime) VALUES (";
            DateTime current = new DateTime();
        current = DateTime.Now;
        foreach (DatabaseRating rating in ratings)
        {
            current = current.AddDays(-8);
            countdown--;
            if (countdown == 0)
            {
                query += "NULL, '" + rating.Name + "', '" + rating.Rating + "', '" + rating.Category + "', '" +
                    current + "')";
            }
            else
            {
                query += "NULL, '" + rating.Name + "', '" + rating.Rating + "', '" + rating.Category + "', '" +
                   current + "'), (";
            }
        }
        dbCon.sendQuery(query);
    }
}

public class DatabaseRequireFeedback
    {
        public string RequireFeedbackId { get; set; }
        public string AskedFrom { get; set; }
        public string AskedTo { get; set; }
        public string Category { get; set; }
        public string Question { get; set; }
        public string IsShown { get; set; }

        public override string ToString()
        {
            return AskedFrom + " wil graag feedback in de categorie " + Category;
        }
    }
}
