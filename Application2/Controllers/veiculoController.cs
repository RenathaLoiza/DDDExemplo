using Domain.Commands;
using Domain.Enum;
using Domain.interfaces;
using Domain.ViewModel;
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
        public async Task <IActionResult> GetAsync(int DiasSimulacaoAluguel, Etiposdeveiculos tipoVeiculo)
        {
            return Ok(_veiculoservice.SimularVeiculoAluguel(DiasSimulacaoAluguel, tipoVeiculo));
        }
        [HttpPost]
        [Route("Alugar")]
        public async Task <IActionResult> PostAsync([FromBody] AlugarVeiculoViewModelInput input)
        {
            await _veiculoservice.AlugarVeiculo(input);
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