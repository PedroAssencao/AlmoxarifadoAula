using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        protected readonly DepartamentoRepository _departamentoRepository;

        public DepartamentoController(DepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }

        [HttpGet]
        [Route("/Departamento")]
        public async Task<List<Departamento>> GetTodosDepartamentos() => await _departamentoRepository.GetAll();

        [HttpGet]
        [Route("/Departamento/{id}")]
        public async Task<Departamento> GetDepartamentoPorId(int id) => await _departamentoRepository.GetPorId(id);

        [HttpPost]
        [Route("/Departamento/Create")]
        public async Task<IActionResult> CreateDepartamento(Departamento Model) => Ok(await _departamentoRepository.Adicionar(Model));

        [HttpPut]
        [Route("/Departamento/Update")]
        public async Task<Departamento> AtualizarDepartamento(Departamento Model) => await _departamentoRepository.Update(Model);

        [HttpDelete]
        [Route("/Departamento/Delete/{id}")]
        public async Task<bool> DeletarDepartamento(int id) => await _departamentoRepository.Delete(id);
    }
}
