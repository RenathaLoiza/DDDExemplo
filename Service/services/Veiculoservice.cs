using Domain.Commands;
using Domain.Enum;
using Domain.interfaces;

namespace Service.services
{
    public class Veiculoservice : Iveiculoservice
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }
        /*incluir validação,só podem cadastrar veiculos com 
        ate 5 anos de uso
        incluir somente carros do tipo SUV,HATCH, Sedan*/
        public Task postAsync(VeiculoCommand command)
        {
            if (command == null)
                    throw new ArgumentNullException();

            if (command.Tiposdeveiculos != Etiposdeveiculos.SUV
                    || command.Tiposdeveiculos != Etiposdeveiculos.hatch
                    || command.Tiposdeveiculos != Etiposdeveiculos.Sedan)

                Console.WriteLine("não foi cadastrado o seu veiculo");
                    throw new NotImplementedException();
        }
         
        

        public void postAsync()
        {
            throw new NotImplementedException();
        }
    }
}
