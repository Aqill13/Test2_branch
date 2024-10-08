﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test2Branch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AqilController : ControllerBase
    {
       
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AqilController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AqilController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AqilController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
