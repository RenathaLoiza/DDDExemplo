using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.interfaces;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IveiculoRepository
    {
        //colocar o nume do database
        private string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True";
        public async Task<string> postAsync(VeiculoCommand command)
        {
            string queryInsert = @"insert into veiculo(Placa,AnoFabricacao,TipoVeiculoID,Estado,montadoraID)
                                   values(@Placa, @AnoFabricacao, @TipoVeiculoID, @Estado, @montadoraID)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoID = (int)command.TipoVeiculos,
                    Estado = command.Estado,
                    montadoraID = (int)command.montadora,


                });
                return "veiculos cadastrados com sucesso!";
            }



        }
        public void postAsync()
        {
        }
        public void GetAsync()
        {
        }

        public Task<string> postAsync(Veiculo command)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculoCommands()
        {
            //query significa consulta
            string queryBuscarVeiculo = @"SELECT * FROM Veiculo WHERE Alugado = 0";
            using (SqlConnection conn = new SqlConnection(conexao))
            {

                return conn.QueryAsync<VeiculoCommand>(queryBuscarVeiculo).Result.ToList();

            }


        }
        public async Task<IEnumerable<VeiculoCommand>> GetVeiculosIndispiniveis()
        {
            string queryBucarIdisponiveis = @"SELECT * FROM veiculo WHERE alugado = 1";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                {
                    return conn.QueryAsync<VeiculoCommand>(queryBucarIdisponiveis).Result.ToList();
                }
            }
        }
    }
}

