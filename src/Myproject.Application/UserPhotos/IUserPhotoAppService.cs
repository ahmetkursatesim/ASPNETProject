using Abp.Application.Services;
using Myproject.UserPhotos.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos
{
    public interface IUserPhotoAppService : IApplicationService
    {

        IEnumerable<GetUserPhotoOutput> ListAll();
        Task CreateAsync(CreateUserPhotoInput input);
        void Update(UpdateUserPhotoInput input);
        void Delete(DeleteUserPhotoInput input);

        GetUserPhotoOutput GetBookByID(GetUserPhotoInput input);
    }
}
