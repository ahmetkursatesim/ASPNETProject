using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Myproject.Roles.Dto;
using Myproject.Users.Dto;

namespace Myproject.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}