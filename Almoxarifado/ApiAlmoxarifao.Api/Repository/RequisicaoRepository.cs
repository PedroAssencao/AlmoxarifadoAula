using ApiAlmoxarifao.Api.DAL;
using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ApiAlmoxarifao.Api.Repository
{
    public class RequisicaoRepository : BaseRepository<Requisicao>
    {
        public RequisicaoRepository(AlmoxarifadoContext context) : base(context)
        {
        }

        //public async Task<List<Requisicao>> Teste()
        //{
        //    var lista = await GetAll();
        //    var a = await _context.Set<ItemRequisicao>().ToListAsync();
        //    foreach (var item in lista)
        //    {
        //        item.ItemRequisicaos = new List<ItemRequisicao>() 
        //        {
        //            a.Find(x => x.ReqId == item.ReqId) 
        //        };
        //    }

        //    return lista;
        //}

        //public async Task<List<Requisicao>> Teste()
        //{
        //    var a = await GetAll();
        //    foreach (var item in a)
        //    {
        //        var b = await _context.Set<ItemRequisicao>().ToListAsync();
        //        item.ItemRequisicaos = b;
        //    }
        //    return a;

        //}

    }
}
