using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Myproject.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Books.DTO
{
    [AutoMapFrom(typeof(BookDb))]
    public class GetBookInput:EntityDto
    {
        
        public string BookName { get; set; }

        public int Author_Id { get; set; }
    }
}
