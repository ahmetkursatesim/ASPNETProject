

using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Myproject.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myproject.Web.Areas.Books.Models
{

    [AutoMapFrom(typeof(BookDb))]
    public class BookModel:EntityDto
    {

      
        public string BookName;
        public int AuthorId { get; set; }

       


    }

}