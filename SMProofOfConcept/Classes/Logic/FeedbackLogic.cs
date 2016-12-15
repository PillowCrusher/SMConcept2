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
    }

    public class DatabaseRequereFeedback
    {
        public string AskedFrom { get; set; }
        public string AskedTo { get; set; }
        public string Category { get; set; }
    }
}
