using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SuperRocket.AspNetCoreAngular.Configuration;
using SuperRocket.AspNetCoreAngular.Web;

namespace SuperRocket.AspNetCoreAngular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspNetCoreAngularDbContextFactory : IDesignTimeDbContextFactory<AspNetCoreAngularDbContext>
    {
        public AspNetCoreAngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspNetCoreAngularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspNetCoreAngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspNetCoreAngularConsts.ConnectionStringName));

            return new AspNetCoreAngularDbContext(builder.Options);
        }
    }
}
