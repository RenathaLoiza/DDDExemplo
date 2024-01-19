using Domain.commands;

namespace Domain.interfaces
{
    public interface IclienteRepository
    {
        Task<string> PostAsync(ClienteCommand command);
        Task GetAsync(ClienteCommand command);

    }
}
