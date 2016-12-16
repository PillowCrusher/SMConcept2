using System;
using System.Collections.Generic;
using SMProofOfConcept.Classes.Database;
using SMProofOfConcept.Classes.Model;

namespace SMProofOfConcept.Classes.Logic
{
    public class RatingLogic
    {
        private List<Rating> _ratingList;
        private DatabaseConnection dbConnection;
        public RatingLogic()
        {
            dbConnection = new DatabaseConnection();
            _ratingList = new List<Rating>();
          
        }

        private void RefreshRating(List<Rating> ratings)
        {
            _ratingList.Clear();
            _ratingList.AddRange(ratings);
        }

        public string getRating(string name)
        {
            RefreshRating(dbConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "'"));
            double avgRating = 0;

            foreach (Rating rating in _ratingList)
            {
                avgRating += rating.getRating();
            }
            avgRating = avgRating/_ratingList.Count;
            avgRating = Math.Round(avgRating, 2);
            string b = Convert.ToString(avgRating);

            return b;
        }

        public string getRating(string name, CategoryType category)
        {
            RefreshRating(dbConnection.sendRatingQuery("SELECT * FROM SMRatings WHERE Name = '" + name + "' AND Category = '" + category.ToString() + "'" ));

            if (_ratingList.Count == 0) return "";

            double avgRating = 0;
            List<Rating> avgRatings = new List<Rating>();
            foreach (Rating rating in _ratingList)
            {
                if (rating.getCategoryType() == category)
                {
                    avgRatings.Add(rating);
                }
            }

            if (avgRatings.Count == 0) return  "";

            foreach (Rating tempRating in avgRatings)
            {
                avgRating += tempRating.getRating();
            }

            avgRating = avgRating / avgRatings.Count;
            avgRating = Math.Round(avgRating, 2);            
            return Convert.ToString(avgRating);

        }
    }
}