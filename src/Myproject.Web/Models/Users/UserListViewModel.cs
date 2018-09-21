using System.Collections.Generic;
using Myproject.Roles.Dto;
using Myproject.Users.Dto;

namespace Myproject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}