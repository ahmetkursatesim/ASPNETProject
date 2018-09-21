using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Myproject.MultiTenancy.Dto;

namespace Myproject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
