using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SuperRocket.AspNetCoreAngular.Controllers
{
    public abstract class AspNetCoreAngularControllerBase: AbpController
    {
        protected AspNetCoreAngularControllerBase()
        {
            LocalizationSourceName = AspNetCoreAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
