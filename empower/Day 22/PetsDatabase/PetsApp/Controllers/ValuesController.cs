using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetsDatabase;

namespace PetsApp.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDatabase database;
        public ValuesController(IDatabase database)
        {
            this.database = database;
        }
        
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return database.ReadAll();
            

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return database.Read(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Pet creator)
        {
            database.Create(creator);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Pet value)
        {
            database.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            database.Delete(id);
        }
    }
}
