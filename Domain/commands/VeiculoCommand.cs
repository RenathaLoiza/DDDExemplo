using Domain.Enum;


namespace Domain.Commands
{
    public class VeiculoCommand
    {
        public int VeiculoID { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public Etiposdeveiculos Tiposdeveiculos { get; set; }
        public string Estado { get; set; }
        public Emontadora montadora { get; set; }
        public bool Alugado { get; set; }
        public object TipoVeiculos { get; set; }
    }
}