using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuperRocket.AspNetCoreAngular.Configuration;
using SuperRocket.AspNetCoreAngular.EntityFrameworkCore;
using SuperRocket.AspNetCoreAngular.Migrator.DependencyInjection;

namespace SuperRocket.AspNetCoreAngular.Migrator
{
    [DependsOn(typeof(AspNetCoreAngularEntityFrameworkModule))]
    public class AspNetCoreAngularMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetCoreAngularMigratorModule(AspNetCoreAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AspNetCoreAngularMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AspNetCoreAngularConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreAngularMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
