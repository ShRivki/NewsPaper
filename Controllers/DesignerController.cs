using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ManagingANewspaper.Controllers
{
    [Route("api/Designers")]
    [ApiController]
    public class DesignerController : ControllerBase
    {
        // GET: api/<Customer>
        private DataDesigners Designers;
        public DesignerController(DataDesigners dataDesigners)
        {
            Designers = dataDesigners;
        }

        [HttpGet]
        public IEnumerable<Designer> Get()
        {
            return Designers._Designers;
        }

        // GET api/<Customer>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Designer designer = new Designer();
            designer = Designers._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                return Ok(designer);
            }
            return NotFound();
        }

        // POST api/<Customer>
        [HttpPost]
        public void Post([FromBody] Designer value)
        {
            Designers._Designers.Add(value);
        }

        // PUT api/<Customer>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Designer value)
        {
            Designer designer;
            designer = Designers._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                designer.Name = value.Name;
                designer.Pon= value.Pon;
                designer.Adress= value.Adress;
                designer.IsDesigningAi= value.IsDesigningAi;
                designer.Vetek= value.Vetek;
                return Ok(designer);

            }
            return NotFound();

        }

        // DELETE api/<Customer>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Designer designer;
            designer = Designers._Designers.Find(i => i.Id == id);
            if (designer != null)
            {
                Designers._Designers.Remove(designer);
                return Ok(designer);

            }
            return NotFound();
        }
    }
}
