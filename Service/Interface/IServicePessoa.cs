using MentoriaProjFinal.Models;

namespace MentoriaProjFinal.Service.Interface
{
    public interface IServicePessoa
    {
        Task<List<Pessoa>> GetUsers();
        Task<bool> AddUser(Pessoa pessoa);
        Task<bool> UpdateUser(Pessoa pessoa);
        Task<bool> DeleteUser(int id);

    }
}