using Abp.Application.Services;
using Myproject.Books.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Books
{
   public  interface IBookAppService:IApplicationService
    {
        IEnumerable<GetBookOutput> ListAll();
        Task Create(CreateBookInput input);
        void Update(UpdateBookInput input);
        void Delete(DeleteBookInput input);

        GetBookOutput GetBookByID(GetBookInput input);






    }
}
