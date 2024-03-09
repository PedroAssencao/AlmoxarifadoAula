using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;

namespace ApiAlmoxarifao.Api.Repository
{
    public class MotivoRepository : BaseRepository<MotivoSaidum>
    {
        public MotivoRepository(AlmoxarifadoContext context) : base(context)
        {
        }
    }
}
