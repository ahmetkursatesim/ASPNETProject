using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors.DTO
{

    [AutoMapFrom(typeof(Author))]
    public class CreateAuthorInput : EntityDto
    {

        public string AuthorName { get; set; }
        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }

    }
}
