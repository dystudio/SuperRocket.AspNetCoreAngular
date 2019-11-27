using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SuperRocket.AspNetCoreAngular.Authorization;
using SuperRocket.AspNetCoreAngular.Authorization.Roles;
using SuperRocket.AspNetCoreAngular.Authorization.Users;
using SuperRocket.AspNetCoreAngular.Editions;
using SuperRocket.AspNetCoreAngular.MultiTenancy;

namespace SuperRocket.AspNetCoreAngular.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
