using Abp.MultiTenancy;
using SuperRocket.AspNetCoreAngular.Authorization.Users;

namespace SuperRocket.AspNetCoreAngular.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
