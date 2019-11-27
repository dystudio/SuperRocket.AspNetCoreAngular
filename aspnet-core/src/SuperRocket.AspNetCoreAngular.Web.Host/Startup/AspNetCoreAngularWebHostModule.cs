using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SuperRocket.AspNetCoreAngular.Configuration;

namespace SuperRocket.AspNetCoreAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(AspNetCoreAngularWebCoreModule))]
    public class AspNetCoreAngularWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetCoreAngularWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreAngularWebHostModule).GetAssembly());
        }
    }
}
