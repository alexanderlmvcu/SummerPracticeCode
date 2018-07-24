using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetsDatabase;

namespace PetsApp.Controllers
{
    [Produces("application/json")]
    [Route("api/PetsAPI")]
    public class PetsAPIController : Controller
    {
        private readonly IDatabase database;
        public PetsAPIController(IDatabase database)
        {
            this.database = database;
        }

        [HttpPost]
        public void Create([FromBody]Pet pets)
        {
            //return "This your your pet";
        }

        [HttpGet]
        public int Read(int petId)
        {
            //return 2;
            return 0;
        }
        [HttpGet]
        //public IEnumerable<string> ReadAll()
        //{
        //    return new string[] { "PetId", "Name", "Age", "IsSpotted", "Color" };
        //}
        [HttpPut]
        public void Update([FromBody]Pet pets)
        {
            //return "You updated this document";
        }
        [HttpDelete]
        public void Delete(int petId)
        {
            //who knows
        }
    }
}