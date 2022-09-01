using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint
    //class : Referans tip olabilir.
    //IEntity : IEntity olabilir yada IEntity Arayüzünü implemente eden bir nesne olabilir.
    //new() :  referansı oluşturulmuş olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        T Get(Expression<Func<T, bool>>? filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
