﻿using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject.Authors.Manager
{
    public class AuthorManager : IDomainService, IAuthorManager
    {


        private readonly IRepository<Author> _repositoryAuthor;



        public AuthorManager(IRepository<Author> repositoryAuthor)
        {

            _repositoryAuthor = repositoryAuthor;

        }
        public async Task<Author> Create(Author entity)
        {
            var author = _repositoryAuthor.FirstOrDefault(x => x.Id == entity.Id);
            if (author!= null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {

                return await _repositoryAuthor.InsertAsync(entity);
            }

        }

        public void Delete(int id)
        {
            var author = _repositoryAuthor.FirstOrDefault(x => x.Id == id);

            if (author == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {

                _repositoryAuthor.Delete(author);
            }
        }

        public IEnumerable<Author> GetAllList()
        {
            return _repositoryAuthor.GetAll();
        }

        public Author GetBookByID(int id)
        {
            return _repositoryAuthor.Get(id);
        }

        public void Update(Author entity)
        {
            _repositoryAuthor.Update(entity);
        }
    }
}
