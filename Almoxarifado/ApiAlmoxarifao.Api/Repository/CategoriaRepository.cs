using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public CategoriaRepository(AlmoxarifadoContext context) : base(context)
        {
        }

        public async Task<Categoria> GetCategoriaPorId(int id) => await _context.Set<Categoria>().FindAsync(id);
    

    
    }
}
