using Domain.Enum;

namespace Domain.Entidades
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }
        public string Placa { get; set; }
        public int AnoFabricacao { get; set; }
        public Etiposdeveiculos  TipoVeiculos { get; set; }
        public string Estado { get; set; }
        public Emontadora montadora { get; set; }
        public bool Alugado { get; set; } = false;
    }
}