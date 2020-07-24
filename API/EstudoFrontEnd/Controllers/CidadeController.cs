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
    public class CidadeController : ControllerBase
    {
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Estado>> Get(int id)
        {
            var JSON = System.IO.File.ReadAllText("C:\\Users\\Lucas\\source\\repos\\EstudoFrontEnd\\EstudoFrontEnd\\Json\\Cidades.json");

            var cidades = JsonConvert.DeserializeObject<IEnumerable<Cidade>>(JSON);

            var cidadesPorEstado = cidades.Where(v => v.Estado == id).Select(c => new { id = c.Id, text = c.Nome });


            return Ok(JsonConvert.SerializeObject(cidadesPorEstado));
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

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
