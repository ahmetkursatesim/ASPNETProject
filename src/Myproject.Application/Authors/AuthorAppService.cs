using Abp.Application.Services;
using AutoMapper;
using Myproject.Authors.DTO;
using Myproject.Authors.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors
{
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {

        private readonly IAuthorManager _authorManager;

        public AuthorAppService(IAuthorManager authorManager)
        {

            _authorManager = authorManager;
        }
        public async Task Create(CreateAuthorInput input)
        {
            input.Created_at = DateTime.Now;
            input.Modified_at = DateTime.MinValue;
            Author output = Mapper.Map<CreateAuthorInput,Author>(input);
            await _authorManager.Create(output);
        }

        public void Delete(DeleteAuthorInput input)
        {
            _authorManager.Delete(input.Id);
        }

        public GetAuthorOutput GetBookByID(GetAuthorInput input)
        {
            var getBook = _authorManager.GetBookByID(input.Id);
            GetAuthorOutput output = Mapper.Map<Author, GetAuthorOutput>(getBook);
            return output;
        }

        public IEnumerable<GetAuthorOutput> ListAll()
        {
            var getAll = _authorManager.GetAllList().ToList();
            List<GetAuthorOutput> output = Mapper.Map<List<Author>, List<GetAuthorOutput>>(getAll);
            return output;
        }

        public void Update(UpdateAuthorInput input)
        {
            Author output = Mapper.Map<UpdateAuthorInput, Author>(input);
            _authorManager.Update(output);
        }
    }
}
