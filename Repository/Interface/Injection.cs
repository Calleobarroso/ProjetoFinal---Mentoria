
using Mentoria.Repository;
using MentoriaProjFinal.Repository.Interface;

namespace MentoriaProjFinal.Repository
{
    public static class InjectionExtention
    {
        public static void InjectionRepository(this IServiceCollection service)
        {
            service.AddScoped<IPessoaRepository, RepositoryPessoa>();
            
        }
    }
}