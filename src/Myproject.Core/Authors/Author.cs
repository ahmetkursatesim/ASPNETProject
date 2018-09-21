using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors
{
    [Table("AbpAuthor")]
    public class Author : Entity
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [MaxLength(MaxTitleLength)]
        public string AuthorName{ get; set; }


        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }


        



        public Author()
        {

        }

        public Author(string Authorname,DateTime created_at,DateTime modified_at)
            : this()
        {
            AuthorName = Authorname;
            Created_at = created_at;
            Modified_at = modified_at;
           
        }




    }
}
