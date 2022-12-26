using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Pipool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pipool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        DBConnection db;
        public AuthController( DBConnection database )
        {
            //connection 3al databse taba3 el kel shi   
             db = database;
        }
        [HttpPost("Signup")]
        public IActionResult SignUp([FromBody] UserDTO UserCedentiel)
        {
            //hone  3am jib collection 
           IMongoCollection<User> collection =db.GetCollection<User>("Pipool", "User");
            // hala2 badna nebze2a 3al mongo db database 
            collection.InsertOne(new User()
            {
                FirstName = UserCedentiel.FirstName,
                LastName = UserCedentiel.LastName,
                Email = UserCedentiel.Email,
                Password = UserCedentiel.Password,
                PhoneNumber = UserCedentiel.PhoneNumber,
            });
            return Ok();

        }

        public IActionResult Signin([FromBody] UserDTO UserCedentiel)
        {



        }

    }
}
