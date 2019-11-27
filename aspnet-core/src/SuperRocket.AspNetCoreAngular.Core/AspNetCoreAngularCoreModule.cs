using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using SuperRocket.AspNetCoreAngular.Authorization.Roles;
using SuperRocket.AspNetCoreAngular.Authorization.Users;
using SuperRocket.AspNetCoreAngular.Configuration;
using SuperRocket.AspNetCoreAngular.Localization;
using SuperRocket.AspNetCoreAngular.MultiTenancy;
using SuperRocket.AspNetCoreAngular.Timing;

namespace SuperRocket.AspNetCoreAngular
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AspNetCoreAngularCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AspNetCoreAngularLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AspNetCoreAngularConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreAngularCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
