using ApiAlmoxarifao.Api.Models;
using ApiAlmoxarifao.Api.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAlmoxarifao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotivoController : ControllerBase
    {
        protected readonly MotivoRepository _motivoRepository;

        public MotivoController(MotivoRepository motivoRepository)
        {
            _motivoRepository = motivoRepository;
        }

        [HttpGet]
        [Route("/Motivo")]
        public async Task<List<MotivoSaidum>> GetTodosMotivos() => await _motivoRepository.GetAll();

        [HttpGet]
        [Route("/Motivo/{id}")]
        public async Task<MotivoSaidum> GetMotivoPorId(int id) => await _motivoRepository.GetPorId(id);

        [HttpPost]
        [Route("/Motivo/Create")]
        public async Task<IActionResult> CreateMotivo(MotivoSaidum Model) => Ok(await _motivoRepository.Adicionar(Model));

        [HttpPut]
        [Route("/Motivo/Update")]
        public async Task<MotivoSaidum> AtualizarMotivo(MotivoSaidum Model) => await _motivoRepository.Update(Model);

        [HttpDelete]
        [Route("/Motivo/Delete/{id}")]
        public async Task<bool> DeletarMotivo(int id) => await _motivoRepository.Delete(id);
    }
}
