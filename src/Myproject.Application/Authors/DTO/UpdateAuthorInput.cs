using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors.DTO
{
   public  class UpdateAuthorInput
    {
        public string AuthorName { get; set; }
        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }
    }
}
