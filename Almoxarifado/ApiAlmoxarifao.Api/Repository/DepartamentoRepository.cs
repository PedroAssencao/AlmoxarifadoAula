using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class DepartamentoRepository : BaseRepository<Departamento>
    {
        public DepartamentoRepository(AlmoxarifadoContext context) : base(context)
        {
        }
    }
}
