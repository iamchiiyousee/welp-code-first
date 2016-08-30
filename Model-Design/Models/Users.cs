using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Design.Models
{
    public class Users
    {
        //references column name in table
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }

        //users can create multiple ratings, needs to access Ratings model
        public virtual ICollection<Rating> Ratings { get; set; }

        //users can rate and review multiple businesses, needs to access Business model
        public virtual ICollection<Business> Businesses { get; set; }

    }
}