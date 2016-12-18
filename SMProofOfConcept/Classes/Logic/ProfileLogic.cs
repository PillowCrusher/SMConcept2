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

        public void SafeSkills(List<DatabaseSkill> skills, string name)
        {
            RemoveSkills(name);

            string query = "INSERT INTO SMSkills (SkillId, Name, Skill) VALUES (NULL, '";
            bool isFirst = true;

            foreach(DatabaseSkill skill in skills)
            {
                if(isFirst)
                {
                    query += name + "', '";
                    query += skill.Skill.ToString() + "')";
                    isFirst = false;
                }
                else
                {
                    query += ", (NULL, '";
                    query += name + "', '";
                    query += skill.Skill.ToString() + "')";
                }
            }

            dbCon.sendQuery(query);

        }

        private void RemoveSkills(string name)
        {
            string query = "DELETE FROM SMSkills WHERE Name = '";
            query += name + "'";
            dbCon.sendQuery(query);
        }

    }

    public class DatabaseSkill
    {
        public string Name { get; set; }
        public string Skill { get; set; }
    }

}

