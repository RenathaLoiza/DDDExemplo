namespace Domain.ViewModel
{
    public class AlugarVeiculoViewModelInput
    {
        public int ClienteID { get; set; }
        public string PlacaVeiculo { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public CartaoViewModel Cartao{ get; set; }


    }
   
}
