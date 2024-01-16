using Domain.commands;
using Domain.Commands;
using Domain.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces
{
    public interface Iclienteservice
    {
        Task<string> postAsync(ClienteCommand command);
        Task<IEnumerable<ClienteCommand>> GetClienteCommands();


    }
}
