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
            DatabaseRequereFeedback[] dbRequireFb = JsonConvert.DeserializeObject<DatabaseRequereFeedback[]>(jsonString);

            if(dbRequireFb.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DatabaseRequereFeedback[] GetRequireFeedback()
        {
            string query = "SELECT * FROM SMRequireFeedback WHERE AskedTo = '";
            query += login.Username + "'";

            string jsonString = dbCon.sendQuery(query);
            return JsonConvert.DeserializeObject<DatabaseRequereFeedback[]>(jsonString);   
        }

        public void DeleteRequireFeedback()
        {
            string query = "DELETE FROM SMRequireFeedback WHERE AskedTo = '";
            query += login.Username + "'";
            dbCon.sendQuery(query);
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

public class DatabaseRequereFeedback
    {
        public string AskedFrom { get; set; }
        public string AskedTo { get; set; }
        public string Category { get; set; }
    }
}
