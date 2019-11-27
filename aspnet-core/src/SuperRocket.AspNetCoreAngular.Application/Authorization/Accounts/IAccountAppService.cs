using System.Threading.Tasks;
using Abp.Application.Services;
using SuperRocket.AspNetCoreAngular.Authorization.Accounts.Dto;

namespace SuperRocket.AspNetCoreAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
