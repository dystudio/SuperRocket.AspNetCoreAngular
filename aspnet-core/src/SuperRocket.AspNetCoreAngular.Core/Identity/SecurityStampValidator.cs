using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using SuperRocket.AspNetCoreAngular.Authorization.Roles;
using SuperRocket.AspNetCoreAngular.Authorization.Users;
using SuperRocket.AspNetCoreAngular.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace SuperRocket.AspNetCoreAngular.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
