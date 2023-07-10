using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Imovelix.Api.Data;
using Imovelix.Dominio.Entidades.Anuncios;
using Imovelix.Api.Dto;

namespace Imovelix.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnunciosController : ControllerBase
    {
        private readonly DataContext _context;

        public AnunciosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Anuncios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anuncio>>> GetAnuncios()
        {
          if (_context.Anuncios == null)
          {
              return NotFound();
          }
            return await _context.Anuncios.Include(a => a.Imovel).ThenInclude(i => i.Endereco).ToListAsync();
        }

        // GET: api/Anuncios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Anuncio>> GetAnuncio(Guid id)
        {
          if (_context.Anuncios == null)
          {
              return NotFound();
          }
            var anuncio = await _context.Anuncios
                .Include(a => a.Imovel)
                    .ThenInclude(i => i.Endereco)
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if (anuncio == null)
            {
                return NotFound();
            }

            return anuncio;
        }

        // PUT: api/Anuncios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnuncio(Guid id, AnuncioEditarDto anuncioEditar)
        {
            
            var anuncio = await _context.Anuncios
                .Include(a => a.Imovel)
                    .ThenInclude(i => i.Endereco)
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if (id != anuncio.Id)
            {
                return BadRequest();
            }

            anuncio.Titulo = anuncioEditar.Titulo;
            anuncio.Descricao = anuncioEditar.Descricao;
            anuncio.Imovel = new Imovel
            {
                QuantBanheiros = anuncioEditar.QuantBanheiros,
                TipoImovel = anuncioEditar.TipoImovel,
                QuantQuartos = anuncioEditar.QuantQuartos,
                Vagas = anuncioEditar.Vagas,
                Endereco = new Endereco
                {
                    Cep = anuncioEditar.Cep,
                    Bairro = anuncioEditar.Bairro,
                    Cidade = anuncioEditar.Cidade,
                    Numero = anuncioEditar.Numero,
                    Complemento = anuncioEditar.Complemento,
                    Referencia = anuncioEditar.Referencia
                }
            };

            _context.Anuncios.Update(anuncio);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnuncioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Anuncios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Anuncio>> PostAnuncio(Anuncio anuncio)
        {
          if (_context.Anuncios == null)
          {
              return Problem("Entity set 'DataContext.Anuncios'  is null.");
          }
            _context.Anuncios.Add(anuncio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnuncio", new { id = anuncio.Id }, anuncio);
        }

        // DELETE: api/Anuncios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnuncio(Guid id)
        {
            if (_context.Anuncios == null)
            {
                return NotFound();
            }
            var anuncio = await _context.Anuncios.Include(a => a.Imovel).ThenInclude(i => i.Endereco).Where(a=>a.Id==id).FirstOrDefaultAsync();
            if (anuncio == null)
            {
                return NotFound();
            }

            _context.Anuncios.Remove(anuncio);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnuncioExists(Guid id)
        {
            return (_context.Anuncios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
