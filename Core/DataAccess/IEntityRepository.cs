using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    // generic constraint
    // class: referans tip olabilir
    // IEntity: IEntity olabilir, ya da IEntity implemente eden bir nesne olabilir
    // new(): Sadece newlenebilir bir nesne gelebilir
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
