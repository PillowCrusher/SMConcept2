using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMProofOfConcept.Classes.Database;
using Newtonsoft.Json;

namespace SMProofOfConcept.Classes.Logic
{
    public class ProfileLogic
    {
        private DatabaseConnection dbCon;

        public ProfileLogic()
        {
            dbCon = new DatabaseConnection();
        }
        public DatabaseSkill[] GetSkills(string name)
        {
            string query = "SELECT * FROM SMSkills WHERE Name = '";
            query += name + "'";

            string jsonString = dbCon.sendQuery(query);
            return JsonConvert.DeserializeObject<DatabaseSkill[]>(jsonString);
        }
    }

    public class DatabaseSkill
    {
        public string Name { get; set; }
        public string Skill { get; set; }
    }

}

