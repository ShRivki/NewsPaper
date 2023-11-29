using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Writers")]
    [ApiController]
    public class WriterController : ControllerBase
    {
        private DataWirters Writers;
        // GET: api/<Worker>
        public WriterController(DataWirters dataWirters)
        {
            Writers=dataWirters;
        }
        [HttpGet]
        public IEnumerable<Writer> Get()
        {
            return Writers._Writers;
        }

        // GET api/<Worker>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Writer writer;
            writer = Writers._Writers.Find(i => i.Id== id);
            if (writer != null) {
                return Ok(writer);
            }
            return NotFound();
        }

        // POST api/<Worker>
        [HttpPost]
        public void Post([FromBody] Writer value)
        {
            Writers._Writers.Add(value);

        }

        // PUT api/<Worker>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Writer value)
        {
            Writer writer;
            writer = Writers._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
                writer.Adress=value.Adress; 
                writer.Name=value.Name;
                writer.Pon=value.Pon;
                writer.Salary=value.Salary;
                writer.TWriter=value.TWriter;  
                writer.Vetek=value.Vetek;
                return Ok(writer);  
            }
            return NotFound();
        }

        // DELETE api/<Worker>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Writer writer;
            writer = Writers._Writers.Find(i => i.Id == id);
            if (writer != null)
            {
               Writers._Writers.Remove(writer);
               return Ok(writer);

            }
            return NotFound();

        }
    }
}
