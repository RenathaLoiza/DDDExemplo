using Domain.Enum;

namespace Domain.ViewModel
{
    public class SimularVeiculoAluguelViewModel
    {
        public decimal ValorTotal{ get; set; }    
        public decimal ValorDaria { get; set; }
        public Etiposdeveiculos TipoVeiculo { get; set;  }
        public decimal Taxas { get; set; }
        public int TotalDiasSimulado { get; set; }

    }
}
