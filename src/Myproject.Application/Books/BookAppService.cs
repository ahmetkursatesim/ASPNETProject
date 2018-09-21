using Abp.Application.Services;
using AutoMapper;
using Myproject.Book;
using Myproject.Book.Manager;
using Myproject.Books.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Books
{
    public class BookAppService : ApplicationService, IBookAppService
    {

        private readonly IBookManager _bookManager;

        public BookAppService(IBookManager bookManager)
        {

            _bookManager = bookManager;
        }
        public async Task Create(CreateBookInput input)
        {
           
            BookDb x = Mapper.Map<CreateBookInput, BookDb>(input);

            await _bookManager.Create(x);

        }

        public void Delete(DeleteBookInput input)
        {
            _bookManager.Delete(input.Id);
        }

        public GetBookOutput GetBookByID(GetBookInput input)
        {
            var getBook = _bookManager.GetBookByID(input.Id);
            GetBookOutput output = Mapper.Map<BookDb, GetBookOutput>(getBook);
            return output;
        }

        public IEnumerable<GetBookOutput> ListAll()
        {
            var getAll = _bookManager.GetAllList().ToList();
            List<GetBookOutput> output = Mapper.Map<List<BookDb>,List< GetBookOutput>>(getAll);
            return output;
        }

        public void Update(UpdateBookInput input)
        {
            BookDb output = Mapper.Map<UpdateBookInput, BookDb>(input);
            _bookManager.Update(output);
        }
    }
}
