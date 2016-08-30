using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Design.Models
{
    public class Business
    {
        //references column name in table
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Hours { get; set; }
        public string Menu { get; set; }
        public int UserID { get; set; }

        //Businesses can be different types, needs a foreign key to access BusinessType Model
        public int BusinessTypeID { get; set; }

        //business can contain multiple ratings, allows access to Ratings model
        public virtual ICollection<Rating> Ratings { get; set; }
        
        //BusinessTypeID needs to access BusinessType Model
        public virtual BusinessType BusinessType { get; set; }

        //Users are a foreign key in table, needs a way to access Users model
        public virtual Users Users { get; set; }

    }
}