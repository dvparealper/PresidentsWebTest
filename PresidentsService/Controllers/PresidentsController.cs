using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PresidentsService.Data;
using PresidentsService.Models;

namespace PresidentsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresidentsController : ControllerBase
    {
        private IEnumerable<President> PresidentsList { get; set; }

        public PresidentsController()
        {
            PresidentsList = PresidentsData.GetList();
        }
            
        // GET: api/Presidents
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Presidents/1
        [HttpGet("{sort}", Name = nameof(Get))]
        public IEnumerable<President> Get(int sort)
        {
            if (sort == 1)
            {
                return PresidentsList.OrderByDescending(p => p.Name);
            }
            else
            {
                return PresidentsList.OrderBy(p => p.Name);
            }
        }

        // POST: api/Presidents
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Presidents/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
