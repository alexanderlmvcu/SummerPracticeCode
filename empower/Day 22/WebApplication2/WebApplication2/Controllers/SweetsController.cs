using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Produces("application/json")]
    [Route("api/Sweets")]
    public class SweetsController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "You have found a sugary delight!";
        }
        [HttpPost]
        public string Post([FromBody] Desserts desserts)
        {
            //
            return "You've got sweets!";
        }
    }
}