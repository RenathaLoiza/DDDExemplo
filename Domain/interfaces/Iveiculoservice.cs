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
       Task <string> postAsync (VeiculoCommand command);
        void postAsync();
        void GetAsync();

    }
}
