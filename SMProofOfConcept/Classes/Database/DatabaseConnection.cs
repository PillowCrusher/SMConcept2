using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using SMProofOfConcept.Classes.Model;
using System.Globalization;

namespace SMProofOfConcept.Classes.Database
{ 
    class DatabaseConnection
    {
        private static string token = "AngjR7v{za-N*7T}";
        private string queryBuilder(string var)
        {
            //http://i291343.iris.fhict.nl/database.php?query=SELECT*FROM%20SMRatings
            return var.Replace(" ", "%20");
        }

        public string sendQuery(string query)
        {
            string querySend = "http://i291343.iris.fhict.nl/database.php?token=" + token + "&query=" + queryBuilder(query);
            string jsonString = "";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonString = wc.DownloadString(querySend);
                }
            }
            catch(Exception)
            {
                
            }
            return jsonString;
        }

        public List<Rating> sendRatingQuery(string query)
        {
            string querySend = "http://i291343.iris.fhict.nl/database.php?token=" + token + "&query=" + queryBuilder(query);
            string jsonString = "";
            List<Rating> result = new List<Rating>();
            try
            {
                using (WebClient wc = new WebClient())
                {
                    jsonString = wc.DownloadString(querySend);
                    result = convertJson(jsonString);
                }
            }
            catch (Exception e)
            {
                string aa = e.ToString();
            }
            return result;
        }

        private List<Rating> convertJson(string jsonString)
        {
            List<Rating> result = new List<Rating>();
            DatabaseRating[] dbRating = JsonConvert.DeserializeObject<DatabaseRating[]>(jsonString);
            CategoryType type;

            foreach (DatabaseRating r in dbRating)
            {
                Enum.TryParse(r.Category, out type);
                string convertedRating;
                // convert voor het geval user een nederlands keyboard layout gebruikt.
                CultureInfo ci = CultureInfo.InstalledUICulture;
                if (ci.Name == "nl-NL") {
                   convertedRating = r.Rating.Replace(".", ",");
                }
                else {
                   convertedRating = r.Rating.Replace(",", ".");
                }
                result.Add(new Rating(type, Convert.ToDouble(convertedRating), DateTime.Parse(r.DateTime)));
            }

            return result;
        }
        public bool dbCheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

    }


    public class DatabaseRating
    {
        public string Name { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }
        public string DateTime { get; set; }

        public DatabaseRating()
        {
        }

        public DatabaseRating(string Name, string Rating, string Category, string DateTime)
        {
            this.Name = Name;
            this.Rating = Rating;
            this.Category = Category;
            this.DateTime = DateTime;
        }
    }
}