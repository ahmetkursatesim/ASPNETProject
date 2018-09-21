using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myproject.UserPhotos.DTO;
using AutoMapper;
using Myproject.UserPhotos.Manager;

namespace Myproject.UserPhotos
{
    public class UserPhotoAppService : ApplicationService, IUserPhotoAppService
    {


        private readonly IUserPhotoManager _userPhotoManager;

        public UserPhotoAppService(IUserPhotoManager userPhotoManager)
        {

            _userPhotoManager = userPhotoManager;
        }
        public async Task CreateAsync(CreateUserPhotoInput input)
        {
            input.user_Id = 7;
            UserImage output = Mapper.Map<CreateUserPhotoInput, UserImage>(input);
            await _userPhotoManager.Create(output);
        }

        public void Delete(DeleteUserPhotoInput input)
        {
            _userPhotoManager.Delete(input.Id);
        }

        public GetUserPhotoOutput GetBookByID(GetUserPhotoInput input)
        {
            var getUserPhoto = _userPhotoManager.GetBookByID(input.Id);
            GetUserPhotoOutput output = Mapper.Map<UserImage, GetUserPhotoOutput>(getUserPhoto);
            return output;
        }

        public IEnumerable<GetUserPhotoOutput> ListAll()
        {
            var getAll = _userPhotoManager.GetAllList().ToList();
            List<GetUserPhotoOutput> output = Mapper.Map<List<UserImage>, List<GetUserPhotoOutput>>(getAll);
            return output;
        }

        public void Update(UpdateUserPhotoInput input)
        {
            UserImage output = Mapper.Map<UpdateUserPhotoInput, UserImage>(input);
            _userPhotoManager.Update(output);
        }
    }
}
