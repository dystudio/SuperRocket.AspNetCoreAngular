using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SuperRocket.AspNetCoreAngular.MultiTenancy.Dto;

namespace SuperRocket.AspNetCoreAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

