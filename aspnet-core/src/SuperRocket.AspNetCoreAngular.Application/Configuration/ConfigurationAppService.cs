using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SuperRocket.AspNetCoreAngular.Configuration.Dto;

namespace SuperRocket.AspNetCoreAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AspNetCoreAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
