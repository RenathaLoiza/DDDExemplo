using Dapper;
using Domain.Entidades;
using Domain.interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class VeiculoRepository : IveiculoRepository
    {
        private string stringconnection = "";
        public async Task<string> postAsync(Veiculo command)
        {
            string queryInsert = @"insert into veiculo(Placa,AnoFabricacao,TipoVeiculoID,Estado,montadoraID)
values(@Placa, @AnoFabricacao, @TipoVeiculoID, @Estado, @montadoraID)";
            using (var conn = new SqlConnection()) 
            {
                conn.Execute(queryInsert, new
                {
                    Placa = command.Placa,
                    AnoFabricacao = command.AnoFabricacao,
                    TipoVeiculoID = command.TipoVeiculos,
                    Estado = command.Estado,
                    montadoraID = command.montadora,


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

    }
}
