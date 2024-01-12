using Domain.Commands;
using Domain.Enum;
using Domain.interfaces;
using Infrastructure.Repository;

namespace Service.services
{
    public class Veiculoservice : Iveiculoservice
    {
        private readonly IveiculoRepository _repository;
        public Veiculoservice(IveiculoRepository repository)
        {
            _repository = repository;
        }

        public void GetAsync()
        {
            throw new NotImplementedException();
        }
        /*incluir validação,só podem cadastrar veiculos com 
        ate 5 anos de uso
        incluir somente carros do tipo SUV,HATCH, Sedan*/
        public async Task <string> postAsync(VeiculoCommand command)
        {

            if (command == null)
                return "todos os campos são obrigatorios";

            if (command.Tiposdeveiculos != Etiposdeveiculos.SUV
                    && command.Tiposdeveiculos != Etiposdeveiculos.hatch
                    && command.Tiposdeveiculos != Etiposdeveiculos.Sedan
                    )
                return "o veiculo não e permitido";
            { 
             /*foi realizado o calculo do ano atual menos o ano de fabrição do modelo
              * a subtração dos mesmos for maior que 5 ele tera mais de 5 anos de uso.*/
             
            }
            int anoAtual = DateTime.Now.Year;

            if (anoAtual - command.AnoFabricacao > 5 || command.AnoFabricacao > anoAtual )
                return "O ano do veiculo tem o ano de fabricação incorreto do permitido";

            
            return await _repository.postAsync(command);
        }
        
        public void postAsync()
        {
            throw new NotImplementedException();
        }
        //buscar veiculos alugados e retornar false.
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculoCommands()
        {
           return await _repository.GetVeiculoCommands();
        }
    }
}
