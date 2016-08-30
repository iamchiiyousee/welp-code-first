using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Design.Models
{
    public class Rating
    {
        //references column name in table
        public int RatingID { get; set; }
        public int StarRating { get; set; }
        public string Review { get; set; }
        public int BusinessID { get; set; }
        public int UserID { get; set; }

        //UserID is a foreign key in Ratings class, needs a way to access Users model
        public virtual Users Users { get; set; }

        //BusinessId is a foreign key in Ratings class, needs a way to access Business model
        public virtual Business Business { get; set; }
        }
    }
}