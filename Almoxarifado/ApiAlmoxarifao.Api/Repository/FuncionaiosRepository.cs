using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class FuncionaiosRepository : BaseRepository<Funcionario>
    {
        public FuncionaiosRepository(AlmoxarifadoContext context) : base(context)
        {
        }
    }
}
