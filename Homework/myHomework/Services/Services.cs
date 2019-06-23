using myHomework._17HelpModel;
using myHomework.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace myHomework.Services
{
    class Services : IRepository<XMLRepository>
    {
        private readonly XMLRepository _repository;
        public Services(XMLRepository repository)
        {
            this._repository = repository;
        }
        public void Add(Article article)
        {
            _repository.Add(article);
        }
        public XMLRepository GetByAuthorName(string authorName)
        {
            throw new NotImplementedException();
        }

        public XMLRepository OrderByPublishDate()
        {
            throw new NotImplementedException();
        }

        public void Remove(Article article)
        {
            throw new NotImplementedException();
        }

        public void RemoveByAuthorName(string authorName)
        {
            throw new NotImplementedException();
        }

        public XMLRepository Search(string search)
        {
            throw new NotImplementedException();
        }

        public XMLRepository Get()
        {
            throw new NotImplementedException();
        }
    }
}
