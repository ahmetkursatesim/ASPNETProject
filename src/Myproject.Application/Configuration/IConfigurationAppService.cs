using System.Threading.Tasks;
using Abp.Application.Services;
using Myproject.Configuration.Dto;

namespace Myproject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}