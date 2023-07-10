//using Microsoft.EntityFrameworkCore;
//using Imovelix.Api.Data;

//namespace Imovelix.Aplicacao.AnuncioAplicacao
//{
//    private readonly DataContext _context;
//    public class ListarAnuncio
//    {
//        if (_context.Anuncios == null)
//        { 
//              return NotFound();
//        }
//        return await _context.Anuncios.Include(a => a.Imovel).ThenInclude(i => i.Endereco).ToListAsync();

//    }
//}

