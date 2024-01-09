using Domain.Commands;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces
{
    internal interface IveiculoRepository
    {
        Task<string> postAsync(Veiculo command);
        void postAsync();
        void GetAsync();
    }
}
