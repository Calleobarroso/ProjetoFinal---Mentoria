using MentoriaProjFinal.Models;
using MentoriaProjFinal.Repository.Interface;
using MentoriaProjFinal.Service.Interface;

namespace MentoriaProjFinal.Service
{
    public class ServicePessoa : IServicePessoa 
    {
        public ServicePessoa(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
        private readonly IPessoaRepository _pessoaRepository;
        
        public async Task<List<Pessoa>> GetUsers ()  => await _pessoaRepository.GetUsers();
        public async Task<bool> AddUser (Pessoa pessoa)  => await _pessoaRepository.AddUser(pessoa);
        public async Task<bool> UpdateUser (Pessoa pessoa)  => await _pessoaRepository.UpdateUser(pessoa);
        public async Task<bool> DeleteUser (int id)  => await _pessoaRepository.DeleteUser(id);

    }
}