using MicroService.SendEmail.Domain.Repository;
using MicroService.SendEmail.Domain.Services;
using MicroService.SendEmail.Infrastucture.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.SendEmail.Application.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Delete(object id)
        {
            _repository.Delete(id);
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
