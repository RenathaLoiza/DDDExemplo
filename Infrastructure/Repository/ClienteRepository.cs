using Dapper;
using Domain.Commands;
using Domain.Entidades;
using Domain.interfaces;
using Infrastructure.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClienteRepository : IclienteRepository
{
    //colocar o nume do database
    private string conexao = @"Server=(localdb)\mssqllocaldb;Database=AluguelVeiculos;Trusted_Connection=True;MultipleActiveResultSets=True"; 
    public async Task<string> postAsync(ClienteCommand command)
    {
        string queryInsert = @"insert into veiculo(PessoaId,Nome,DataNascimento ,Habilitação,Estado)
                               values(@PessoaId,@Nome,@DataNascimento ,@Habilitação,@Estado)";
        using (SqlConnection conn = new SqlConnection(conexao))
        {
            conn.Execute(queryInsert, new
            {
                Nome = command.Nome,
                DataNascimento = command.dataNascimento,
                Habilitação = command.habilitação,
                Estado = command.Estado,


            });
            return "veiculos cadastrados com sucesso!";
        }



    }
   

    public async Task<IEnumerable<ClienteCommand>> GetClienteCommands()
    {
        //query significa consulta
        string queryBuscarVeiculo = @"SELECT * FROM CLIENTE WHERE ESTADO";
        using (SqlConnection conn = new SqlConnection(conexao))
        {

            return conn.QueryAsync<ClienteCommand>(queryBuscarVeiculo).Result.ToList();

        }


    }


}