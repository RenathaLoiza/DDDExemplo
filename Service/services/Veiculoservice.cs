using CreditCardValidator;
using Domain.Commands;
using Domain.Enum;
using Domain.interfaces;
using Domain.ViewModel;

namespace Service.Services
{
    public class VeiculoService : Iveiculoservice
    {
        //Injeção de dependencia

        private readonly IveiculoRepository _repository;

        public VeiculoService(IveiculoRepository repository)
        {
            _repository = repository;
        }
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os Campos são Obrigatórios";

            int anoAtual = DateTime.Now.Year;
            if (anoAtual - command.AnoFabricacao > 5)
                return "O Ano do veículo é menor que o permitido";

            if (command.Tiposdeveiculos != Etiposdeveiculos.SUV
               && command.Tiposdeveiculos != Etiposdeveiculos.Hatch
               && command.Tiposdeveiculos != Etiposdeveiculos.Sedan
            )
                return "O Tipo de Veículo não pe permitido";

            return await _repository.PostAsync(command);
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis()
        {
            return await _repository.GetVeiculosDisponiveis();
        }

        public async Task<SimularVeiculoAluguelViewModel> SimularVeiculoAluguel(int totalDiasSimulado, Etiposdeveiculos tipoVeiculo)
        {
            var veiculoPreco = await _repository.GetPrecoDiaria(tipoVeiculo);
            double taxaEstadual = 10.50;
            double taxaFederal = 3.5;
            double taxaMunicipal = 13.5;

            var simulacao = new SimularVeiculoAluguelViewModel();
            simulacao.TotalDiasSimulado = totalDiasSimulado;
            simulacao.Taxas = (decimal)(taxaMunicipal + taxaEstadual + taxaFederal);
            simulacao.TipoVeiculo = tipoVeiculo;
            simulacao.ValorDaria = veiculoPreco.Preco;
            simulacao.ValorTotal = (totalDiasSimulado * veiculoPreco.Preco) + simulacao.Taxas;

            return simulacao;
        }

        public async Task AlugarVeiculo(AlugarVeiculoViewModelInput input)
        {
            //todo.. chama medoto para validar disponibilidade de veiculo.
            var veiculoAlugado = await VeiculoEstaAlugado(input.PlacaVeiculo);
            if (veiculoAlugado)

                
            //todo.. chamar medoto para validar datas.
           
            if (input.DataRetirada < input.DataDevolucao ) 
            {
               
            }
              var dataHoje = DateTime.Now;
            if (input.DataRetirada < dataHoje || input.DataDevolucao < dataHoje) 
            {
                
            }
            // if (input.DataDevolucao < dataAtual)
            //todo.. chamar medoto para validar cartao.
            CreditCardDetector detector = new CreditCardDetector(Convert.ToString(input.Cartao.numero));
            var bandeira = detector.Brand;
            if (detector.IsValid()) 
            { 
            }

           //todo.. chamar medoto para validar habilitacao.
            
        }
        private Task<bool> VeiculoEstaAlugado(string placaVeiculo)
        {
            return _repository.VeiculoEstaAlugado(placaVeiculo);
        }

    }
}
 