using Domain.commands;
using Domain.interfaces;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace Application2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly Iclienteservice _clienteservice;
        

        public ClienteController(Iclienteservice clienteservice)
        {
            _clienteservice = clienteservice;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult>PostAsync(ClienteCommand command)
        {
            return Ok(await _clienteservice.PostAsync(command));
        }
       




    }
}
