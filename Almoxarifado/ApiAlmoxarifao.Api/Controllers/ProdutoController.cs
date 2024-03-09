using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        protected readonly ProdutoRepositroy _repo;

        public ProdutoController(ProdutoRepositroy repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("/produto")]
        public async Task<List<Produto>> GetTodosProdutos() => await _repo.GetProdutos();

        [HttpGet]
        [Route("/produto/{id}")]
        public async Task<Produto> GetProdutoPorId(int id) => await _repo.GetPorId(id);

        [HttpPost]
        [Route("/produto/Create")]
        public async Task<IActionResult> CriarNovoProdutos([FromForm] ProdutoView Model) => Ok(await _repo.AdicionarImagem(Model));

        [HttpPut]
        [Route("/produto/update")]
        public async Task<IActionResult> AtualizarProdutos([FromForm] ProdutoView model) => Ok(await _repo.AtualizarProduto(model));

        [HttpDelete]
        [Route("produto/delete")]
        public async Task<bool> DeletarProduto(int id) => await _repo.Delete(id);


    }
}
