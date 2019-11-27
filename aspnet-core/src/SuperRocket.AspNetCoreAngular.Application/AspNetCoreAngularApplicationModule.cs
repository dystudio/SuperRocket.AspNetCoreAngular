using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuperRocket.AspNetCoreAngular.Authorization;

namespace SuperRocket.AspNetCoreAngular
{
    [DependsOn(
        typeof(AspNetCoreAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspNetCoreAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspNetCoreAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AspNetCoreAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
