using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myproject.Web.Areas.Authors.Models
{
    public class AuthorModel
    {

        public string AuthorName;
        public DateTime Created_at { get; set; }

        public DateTime Modified_at { get; set; }

    }
}