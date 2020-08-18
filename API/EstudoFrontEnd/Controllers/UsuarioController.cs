using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EstudoFrontEnd.Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EstudoFrontEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {        

        [HttpGet()]
        public ActionResult<IEnumerable<int>> Get()
        {
            Random rnd = new Random();
            
            return Ok(JsonConvert.SerializeObject(rnd.Next(1, 1000)));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
