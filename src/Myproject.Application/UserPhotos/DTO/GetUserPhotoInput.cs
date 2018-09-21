using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos.DTO
{
    [AutoMapFrom(typeof(UserImage))]
    public class GetUserPhotoInput : EntityDto
    {


        public string Image;

        public int user_Id { get; set; }
    }
}
