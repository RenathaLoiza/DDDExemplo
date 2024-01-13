using Domain.Commands;
using Domain.interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly Iveiculoservice _veiculoservice;
        public VeiculoController(Iveiculoservice veiculoservice)
        {
            _veiculoservice = veiculoservice;
        }
        [HttpPost]
        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {

            return Ok(await _veiculoservice.postAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public IActionResult GetAsync()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }
        [HttpGet]
        [Route("VeiculosAlugados")]

        public async Task<IActionResult> GetVeiculosAlugadosAsync()
        {
            return Ok(await _veiculoservice.GetVeiculoCommands());
        }
        [HttpGet]
        [Route("veiculosIndisponiveis")]

        public async Task<IActionResult> GetVeiculosIndisponiveisAsync()
        {
            return Ok(await _veiculoservice.GetVeiculosIndispiniveis());
        }

        [HttpPost]
        [Route("tabelaClientes")]

        public async Task<IActionResult> PostTabelaClientesAsync([FromBody] VeiculoCommand)
        {
            return Ok(await _veiculoservice.postAsync(command));
        }
    }
}