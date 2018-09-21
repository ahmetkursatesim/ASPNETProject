using Abp.Domain.Entities;
using Myproject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.UserPhotos
{
    
    [Table("AbpUserPhoto")]
    public class UserImage:Entity
    {


        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB


        public string Image { get; set; }


        public Int64 user_Id { get; set; }



        [ForeignKey("user_Id")]
        public virtual User user { get; set; }


        public UserImage()
        {

        }

        public UserImage(string image,Int64 user_id)
            : this()
        {
            Image = image;

            user_Id = user_id;

        }

    }
}
