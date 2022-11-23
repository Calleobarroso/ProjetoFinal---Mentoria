using Dapper;
using MentoriaProjFinal.Models;
using MentoriaProjFinal.Repository.DataBase;
using MentoriaProjFinal.Repository.Interface;
using MySql.Data.MySqlClient;

namespace Mentoria.Repository
{
    public class RepositoryPessoa : BaseRepository, IPessoaRepository
    {
        public RepositoryPessoa(MySqlConnection mySqlConnection): base(mySqlConnection)
        {

        }
        public async Task<List<Pessoa>> GetUsers()
        {
            try
            {
                using (var connection = _sqlConnection)
                {
                    string sql = "SELECT * FROM user";
                    List<Pessoa> pessoas = (await connection.QueryAsync<Pessoa>(sql)).ToList(); 
                    return pessoas;
                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
                throw;
            }
        }

        public async Task<bool> AddUser(Pessoa pessoa)
        {
                string query = $"INSERT INTO user (id, Nome, CPF, Nascimento, Endereço) VALUES ({pessoa.ID}, '{pessoa.Nome}', {pessoa.CPF}, {pessoa.Nascimento}, '{pessoa.Endereço}')";
                return await MySqlExecuted(query);

        }

        public async Task<bool> UpdateUser(Pessoa pessoa)
        {
                string query = $"UPDATE user set Nome = '{pessoa.Nome}', CPF = {pessoa.CPF}, Nascimento = {pessoa.Nascimento}, Endereço = '{pessoa.Endereço}' WHERE id = {pessoa.ID}";
                return await MySqlExecuted(query);
        }

        public async Task<bool> DeleteUser(int id)
        {
                string query = $"DELETE FROM user WHERE id = {id}";
                return await MySqlExecuted(query);
        }
        }
    }