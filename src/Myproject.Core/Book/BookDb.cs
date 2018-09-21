using Abp.Domain.Entities;
using Myproject.Authors;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Book
{
    [Table("AbpBook")]
    public class BookDb:Entity
    {


        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [MaxLength(MaxTitleLength)]
        public string BookName { get; set; }

        public int Author_Id { get; set; }

        
        [ForeignKey("Author_Id")]
        public virtual Author Author { get; set; }

        public BookDb()
        {

        }

        public BookDb(string Bookname, int Authorid)
            : this()
        {
            BookName = Bookname;
            Author_Id = Authorid;
        }
    }
}
