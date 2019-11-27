using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SuperRocket.AspNetCoreAngular.Roles.Dto;
using SuperRocket.AspNetCoreAngular.Users.Dto;

namespace SuperRocket.AspNetCoreAngular.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
