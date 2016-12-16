using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMProofOfConcept.Classes.Model
{

   public class Rating
    {
        private DateTime dateTime;
        private CategoryType type;
        private double v;

        public Rating(CategoryType type, double v, DateTime dateTime)
        {
            this.type = type;
            this.v = v;
            this.dateTime = dateTime;
        }

        public double getRating()
        {
            return v;
        }

        public CategoryType getCategoryType()
        {
            return type;
        }

    }
}
