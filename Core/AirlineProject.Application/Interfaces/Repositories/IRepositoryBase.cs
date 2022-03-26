using AirlineProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Application.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>>filter);
        Task<TEntity> GetById(int id);

        void Update(TEntity entity);
        void Create(TEntity entity);
        void Delete(TEntity entity);
    }
}
