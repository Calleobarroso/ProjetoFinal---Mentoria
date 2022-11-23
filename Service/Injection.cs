using MentoriaProjFinal.Service.Interface;
using MentoriaProjFinal.Repository.DataBase;

namespace MentoriaProjFinal.Service
{
    public static class InjectionExtention
    {
        public static void InjectionServices (this IServiceCollection service, IConfigurationRoot configurationRoot)
        {
            service.InjectData(configurationRoot);
            service.AddScoped<IServicePessoa, ServicePessoa>();
        }
    }
}