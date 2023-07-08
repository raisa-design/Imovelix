using Imovelix.Api.Data;
using Imovelix.Api.Entidade;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Imovelix.Api.Controllers
{
    public class ImovelController: ControllerBase
    {
        private readonly DataContext _context;

        public ImovelController(DataContext context)
        {
            {
                _context = context;
            }
        }

        // GET: api/<ImovelController>
        [HttpGet]
        public List<Imovel> Get()
        {
            var im = _context.Imoveis.ToList();
            return im;
        }



        // GET api/<ImovelController>/5
        [HttpGet("{id}")]
        public Imovel Get(Guid id)
        {
            var im = _context.Imoveis.FirstOrDefault(x => x.Id == id);
            return im;
        }


        // POST api/<ImovelController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ImovelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImovelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
