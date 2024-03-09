using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        protected readonly CategoriaRepository _repository;

        public CategoriaController(CategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("/Categorias")]
        public async Task<List<Categoria>> GetTodasCategorias() => await _repository.GetAll();

        [HttpGet]
        [Route("/Categorias/{id}")]
        public async Task<Categoria> GetPorId(int id) => await _repository.GetPorId(id);

        [HttpPost]
        [Route("/Categorias/Create")]
        public async Task<IActionResult> CreateCategorias(Categoria Model) => Ok(await _repository.Adicionar(Model));

        [HttpDelete]
        [Route("/Categorias/Delete/{id}")]
        public async Task<bool> DeletarCategoria(int id) => await _repository.Delete(id);

        [HttpPut]
        [Route("/Categorias/Update")]
        public async Task<IActionResult> AtualizarCategoria(Categoria Model) => Ok(await _repository.Update(Model));
    }
}
