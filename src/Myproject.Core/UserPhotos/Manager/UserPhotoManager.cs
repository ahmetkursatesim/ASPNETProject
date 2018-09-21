using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos.Manager
{
   public  class UserPhotoManager:IDomainService, IUserPhotoManager
    {
        private readonly IRepository<UserImage> _repositoryUserPhoto;



        public UserPhotoManager(IRepository<UserImage> repositoryUserpHOTOS)
        {

            _repositoryUserPhoto = repositoryUserpHOTOS;


        }

        public async Task<UserImage> Create(UserImage entity)
        {
            var UserPhoto = _repositoryUserPhoto.FirstOrDefault(x => x.Id == entity.Id);
            if (UserPhoto != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {

                return await _repositoryUserPhoto.InsertAsync(entity);
            }
        }

      
        public void Delete(int id)
        {
            var UserPhoto = _repositoryUserPhoto.FirstOrDefault(x => x.Id == id);

            if (UserPhoto == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {

                _repositoryUserPhoto.Delete(UserPhoto);
            }
        }

        public IEnumerable<UserImage> GetAllList()
        {
            return _repositoryUserPhoto.GetAll();
        }

        public UserImage GetBookByID(int id)
        {
            return _repositoryUserPhoto.Get(id);
        }

        public void Update(UserImage entity)
        {
            _repositoryUserPhoto.Update(entity);
        }
    }
}
