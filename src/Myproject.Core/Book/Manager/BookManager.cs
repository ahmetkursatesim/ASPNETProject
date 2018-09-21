using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Book.Manager
{
    public class BookManager : IDomainService, IBookManager
    {
        private readonly IRepository<BookDb> _repositoryBook;



        public BookManager(IRepository<BookDb> repositoryBook)
        {

            _repositoryBook = repositoryBook;

        }

        public IEnumerable<BookDb> GetAllList()
        {
            return _repositoryBook.GetAll();
        }

        public BookDb GetBookByID(int id)
        {
            return _repositoryBook.Get(id); 
        }

        public async Task<BookDb> Create(BookDb entity)


        {
            var book = _repositoryBook.FirstOrDefault(x => x.Id == entity.Id);
            if (book!=null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {

                return await _repositoryBook.InsertAsync(entity);
            }


           
        }

        public void Update(BookDb entity)
        {
            _repositoryBook.Update(entity);
        }

        public void Delete(int id)
        {
            var book = _repositoryBook.FirstOrDefault(x => x.Id == id);
           

            if (book == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {

                _repositoryBook.Delete(book);
            }
        }

        
    }
}
