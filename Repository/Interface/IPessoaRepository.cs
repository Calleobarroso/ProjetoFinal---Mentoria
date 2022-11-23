using MentoriaProjFinal.Models;
namespace MentoriaProjFinal.Repository.Interface
{
    public interface IPessoaRepository
    {
        Task<List<Pessoa>> GetUsers();
        Task<bool> AddUser(Pessoa pessoa);
        Task<bool> UpdateUser(Pessoa pessoa);
        Task<bool> DeleteUser(int id);
    }
}