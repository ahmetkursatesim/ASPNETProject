using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors.DTO
{


    public class GetAuthorInput:EntityDto
    {
        
        public string AuthorName { get; set; }
        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }
    }
}
