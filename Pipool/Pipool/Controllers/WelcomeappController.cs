using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pipool.Model;
using MongoDB.Driver;

namespace Pipool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeappController : ControllerBase
    {
        DBConnection database;
         public WelcomeappController (DBConnection dB)
         {
            database = dB;

         }
       
        [HttpGet("dbtest")]
        public IActionResult dbtest()
        {
            IMongoCollection<User> Usercollection=  database.GetCollection<User>("Pipool", "User");


            List<User> UserList = Usercollection.Find(FilterDefinition<User>.Empty).ToList<User>();

            return Ok();



        }


    }

    
}
