using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.AspNetCoreAngular.Sessions.Dto;

namespace SuperRocket.AspNetCoreAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
