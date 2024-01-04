using Domain.Commands;
using Domain.interfaces;
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
        public IActionResult PostAsync([FromBody] VeiculoCommand command)
        {
            _veiculoservice.postAsync(command);
            
            return Ok();
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
    }
}