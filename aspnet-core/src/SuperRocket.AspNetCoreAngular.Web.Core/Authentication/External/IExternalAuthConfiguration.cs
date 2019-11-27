using System.Collections.Generic;

namespace SuperRocket.AspNetCoreAngular.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
