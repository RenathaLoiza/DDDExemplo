using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces
{
    public interface Iveiculoservice
    {
        Task<string> postAsync(VeiculoCommand command);
        Task<IEnumerable<VeiculoCommand>> GetVeiculoCommands();
        void postAsync();
        void GetAsync();

    }
}
