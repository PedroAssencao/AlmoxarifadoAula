using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        protected readonly FuncionaiosRepository _context;

        public FuncionariosController(FuncionaiosRepository context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/Funcionarios")]
        public async Task<List<Funcionario>> BuscarTodosFuncionarios() => await _context.GetAll();

        [HttpGet]
        [Route("/Funcionarios/{id}")]
        public async Task<Funcionario> BuscarPorId(int id) => await _context.GetPorId(id);

        [HttpPost]
        [Route("/Funcionarios/Create")]
        public async Task<IActionResult> CriarFuncinario(Funcionario Model) => Ok(await _context.Adicionar(Model));
        [HttpPut]
        [Route("/Funcionario/Update")]
        public async Task<Funcionario> AtualizarFuncionario(Funcionario Model) => await _context.Update(Model); 

        [HttpDelete]
        [Route("/Funcionarios/Delete/{id}")]
        public async Task<bool> DeletarFuncionario(int id) => await _context.Delete(id);


    }
}
