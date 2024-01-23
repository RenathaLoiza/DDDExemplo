using Dapper;
using Domain.commands;
using Domain.interfaces;
using System.Data.SqlClient;

namespace Infrastructure.Repository
{
    public class ClienteRepository : IclienteRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Task GetAsync(ClienteCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ClienteCommand command)
        {
            string queryInsertCliente = @"
            INSERT INTO CLIENTE(Nome, Datanascimento, Habilitacao, ESTADO)
            VALUES(@NOME, @DATANASCIMENTO, @Hablitacao, @ESTADO)
            ";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Execute(queryInsertCliente, new 
                {
                    Nome = command.Nome,
                    dataNascimento = command.dataNascimento,
                    habilitacao = command.habilitacao,
                    Estado = command.Estado
                });

                return "Cadastro realizado com sucesso";
            }
        }

      
    }
}

