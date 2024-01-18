using Domain.commands;
using Domain.interfaces;

namespace Service.Services
{
    public class ClienteService : Iclienteservice
    {
        private readonly IclienteRepository _repository;
        public ClienteService(IclienteRepository clienteRepository)
        {
            _repository = clienteRepository;
        }
        public async Task<string> PostAsync(ClienteCommand command)
        {
            int idade = DateTime.Now.Year - command.dataNascimento.Year;
            if (idade < 18)
            {
                return "Cliente deve ter mais que 18 anos";
            }

            return await _repository.PostAsync(command);
        }

        public Task<string> postAsync(ClienteCommand command)
        {
            throw new NotImplementedException();
        }
    }
}