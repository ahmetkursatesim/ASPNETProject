using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Myproject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos.DTO
{
    [AutoMapFrom(typeof(UserImage))]
    public class CreateUserPhotoInput:EntityDto
    {


        public string Image;
        public int user_Id { get; set; }
        [ForeignKey("user_Id")]
        public virtual User user { get; set; }

    }
}
