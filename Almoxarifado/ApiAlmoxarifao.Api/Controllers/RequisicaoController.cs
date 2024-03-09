using APIAlmoxarifado.ViewModel;
using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisicaoController : ControllerBase
    {

        protected readonly RequisicaoRepository _requisicaoRepository;

        public RequisicaoController(RequisicaoRepository requisicaoRepository)
        {
            _requisicaoRepository = requisicaoRepository;
        }

        [HttpPost]
        [Route("/AdicionarRequisicaoWithList")]
        public async Task<IActionResult> AdicionarRequisicao(RequisicaoViewModel carrinho)
        {

            try
            {
                List<ItemRequisicao> lista = new List<ItemRequisicao>();
                foreach (var item in carrinho.itens)
                {

                    lista.Add(
                          new ItemRequisicao()
                          {
                              ProId = item.CodigoProduto,
                              ItemPreco = item.Preco,
                              ItemQuantidade = item.quantidade
                          }
                   );
                }

                Requisicao requisicaoNova = new Requisicao()
                {
                    ReqDate = carrinho.DataRequisicao,
                    ItemRequisicaos = lista

                };

                await _requisicaoRepository.Adicionar(requisicaoNova);

                return Ok("Cadastrado com sucesso");

            }
            catch (Exception ex)
            {

                return Ok("Não cadastro" + ex.Message);
            }

        }

        //[HttpGet]
        //[Route("/GetRequisicaoWithList")]
        //public async Task<IActionResult> GetWithList()
        //{
        //    return Ok(await _requisicaoRepository.Getrequisicao());
        //}


        [HttpGet]
        [Route("/requisicao")]
        public async Task<List<Requisicao>> GetTodosRequiscao() => await _requisicaoRepository.GetAll();

        [HttpGet]
        [Route("/requisicao/{id}")]
        public async Task<Requisicao> GetRequisicaoPorId(int id) => await _requisicaoRepository.GetPorId(id);

        [HttpPost]
        [Route("/requisicao/Create")]
        public async Task<IActionResult> CreateRequisicao(Requisicao Model) => Ok(await _requisicaoRepository.Adicionar(Model));

        [HttpPut]
        [Route("/requisicao/Update")]
        public async Task<Requisicao> AtualizarRequisicao(Requisicao Model) => await _requisicaoRepository.Update(Model);

        [HttpDelete]
        [Route("/requisicao/Delete/{id}")]
        public async Task<bool> DeletarRequisicao(int id) => await _requisicaoRepository.Delete(id);
    }
}
