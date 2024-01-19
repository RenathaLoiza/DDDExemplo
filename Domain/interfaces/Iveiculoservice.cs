using Domain.Commands;
using Domain.Enum;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Task<bool> VeiculoEstaAlugado(string placaVeiculo);
    }
}
