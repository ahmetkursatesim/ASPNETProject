using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors.Manager
{
    public interface IAuthorManager : IDomainService
    {

        IEnumerable<Author> GetAllList();
        Author GetBookByID(int id);
        Task<Author> Create(Author entity);
        void Update(Author entity);
        void Delete(int id);
    }
}
