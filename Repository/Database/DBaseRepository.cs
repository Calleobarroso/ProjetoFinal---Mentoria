
using Dapper;
using MySql.Data.MySqlClient;

namespace MentoriaProjFinal.Repository.DataBase
{
    public abstract class BaseRepository
    {
        public readonly MySqlConnection _sqlConnection;

        protected BaseRepository(MySqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        protected async Task<bool> MySqlExecuted(string sql)
        {
            try
            {
                using (var connection = _sqlConnection)
                {
                    var linhas = await connection.ExecuteAsync(sql);
                    return linhas > 0;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}