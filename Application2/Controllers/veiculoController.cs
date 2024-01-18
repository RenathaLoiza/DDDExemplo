using Domain.Commands;
using Domain.interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

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

            return Ok(await _veiculoservice.PostAsync(command));
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
        public IActionResult GetAlugado()
        {
            return Ok();
        }
        [HttpGet]
        [Route("Veiculos-Disponiveis")]
        public async Task<IActionResult> GetVeiculosDisponiveis()
        {
            return Ok(await _veiculoservice.GetVeiculosDisponiveis());
        }
    }
}