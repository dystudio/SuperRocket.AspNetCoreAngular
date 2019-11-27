using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SuperRocket.AspNetCoreAngular.Authorization.Roles;
using SuperRocket.AspNetCoreAngular.Authorization.Users;
using SuperRocket.AspNetCoreAngular.MultiTenancy;

namespace SuperRocket.AspNetCoreAngular.EntityFrameworkCore
{
    public class AspNetCoreAngularDbContext : AbpZeroDbContext<Tenant, Role, User, AspNetCoreAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AspNetCoreAngularDbContext(DbContextOptions<AspNetCoreAngularDbContext> options)
            : base(options)
        {
        }
    }
}
