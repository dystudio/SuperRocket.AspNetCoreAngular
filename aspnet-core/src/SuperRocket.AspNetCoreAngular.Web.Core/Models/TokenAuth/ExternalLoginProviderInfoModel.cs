using Abp.AutoMapper;
using SuperRocket.AspNetCoreAngular.Authentication.External;

namespace SuperRocket.AspNetCoreAngular.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
