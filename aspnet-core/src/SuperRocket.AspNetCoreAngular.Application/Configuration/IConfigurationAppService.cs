using System.Threading.Tasks;
using SuperRocket.AspNetCoreAngular.Configuration.Dto;

namespace SuperRocket.AspNetCoreAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
