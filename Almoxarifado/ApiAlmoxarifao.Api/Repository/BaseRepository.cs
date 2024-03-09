using ApiAlmoxarifao.Api.DAL;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Repository
{
    public class BaseRepository<T> where T : class
    {
        protected readonly AlmoxarifadoContext _context;

        public BaseRepository(AlmoxarifadoContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAll() => await _context.Set<T>().ToListAsync();

        public async Task<T> Adicionar(T Model)
        {
            await _context.AddAsync(Model);
            await _context.SaveChangesAsync();
            return Model;
        }

        public async Task<T> GetPorId(int id) => await _context.Set<T>().FindAsync(id);

        public async Task<bool> Delete(int id)
        {
            
            var a = await GetPorId(id);
            _context.Remove(a);
            _context.SaveChanges();
            return true;
        }

        public async Task<T> Update(T model) 
        {
            _context.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

    }
}
