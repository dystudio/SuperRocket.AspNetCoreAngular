using Abp.Application.Services.Dto;
using System;

namespace SuperRocket.AspNetCoreAngular.Users.Dto
{
    //custom PagedResultRequestDto
    public class PagedUserResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
