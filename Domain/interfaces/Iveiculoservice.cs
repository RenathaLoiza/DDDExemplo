using Domain.Commands;
using Domain.Enum;
using Domain.ViewModel;

namespace Domain.interfaces
{
    public interface Iveiculoservice
    {
        //A interface é um contrato, apenas usamos para adicionar
        //metodos,
        //não é feita implementação de nada

        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        Task<SimularVeiculoAluguelViewModel> SimularVeiculoAluguel(int TotalDiasSimulado,Etiposdeveiculos tipoVeiculo);
        Task AlugarVeiculo(AlugarVeiculoViewModelInput input);
    }
}
