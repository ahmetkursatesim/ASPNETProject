using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos.Manager
{
    public interface IUserPhotoManager:IDomainService
    {

        IEnumerable<UserImage> GetAllList();
        UserImage GetBookByID(int id);
        Task<UserImage> Create(UserImage entity);
        void Update(UserImage entity);
        void Delete(int id);
    }
}
