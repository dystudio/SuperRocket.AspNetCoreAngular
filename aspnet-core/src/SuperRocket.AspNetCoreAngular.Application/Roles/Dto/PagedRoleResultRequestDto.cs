using Abp.Application.Services.Dto;

namespace SuperRocket.AspNetCoreAngular.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

