using Domain.commands;

namespace Domain.interfaces
{
    public interface Iclienteservice
    {
        Task<string> postAsync(ClienteCommand command);
        Task GetAsync(ClienteCommand command);


    }
}
