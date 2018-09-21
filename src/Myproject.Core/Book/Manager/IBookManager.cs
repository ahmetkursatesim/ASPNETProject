using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Book.Manager
{
    public interface IBookManager:IDomainService

    {
        IEnumerable<BookDb> GetAllList();
        BookDb GetBookByID(int id);
        Task<BookDb> Create(BookDb entity);
        void Update(BookDb entity);
        void Delete(int id);


    }
}
