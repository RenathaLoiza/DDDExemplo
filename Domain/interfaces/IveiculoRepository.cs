using Domain.Commands;
using Domain.Enum;

namespace Domain.interfaces
{

    public interface IveiculoRepository
    {
        Task<string> PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
        Task<IEnumerable<VeiculoCommand>> GetVeiculosDisponiveis();
        Task<VeiculoPrecoCommand> GetPrecoDiaria(Etiposdeveiculos tipoVeiculo);
    }
}
