using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Books.DTO
{
    public class DeleteBookInput
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public int Author_Id { get; set; }

    }
}
