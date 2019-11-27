using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using SuperRocket.AspNetCoreAngular.EntityFrameworkCore.Seed;

namespace SuperRocket.AspNetCoreAngular.EntityFrameworkCore
{
    [DependsOn(
        typeof(AspNetCoreAngularCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AspNetCoreAngularEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AspNetCoreAngularDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AspNetCoreAngularDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AspNetCoreAngularDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreAngularEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
