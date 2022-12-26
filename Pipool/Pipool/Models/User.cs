using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Pipool.Model
{
    public class User
    {
      
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Password { get; set; }


    }


    //kif ha yejik el request men el front end 
    //class DTO fasel ben li rah yeb3ato el user ou tari2a li bede sayva bek databse 
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateofBirth { get; set; }

    }

    
}
