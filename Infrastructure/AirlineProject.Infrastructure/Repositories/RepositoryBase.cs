using AirlineProject.Application.Interfaces.Repositories;
using AirlineProject.Domain.Entities;
using AirlineProject.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet;
        private readonly AirlineContext _context;
        public RepositoryBase(AirlineContext context)
        {
            _dbSet = context.Set<T>();
            //Geri donus tipi : Database set etme => context.Ticket ... Ne gelecegini bilmedigimiz icin yukarıda boyle yaptık
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
            // Asenkron programlama await metod calısırken , baska metotda calısıcak bunun haberini veriyor diger metoda 
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.SingleOrDefaultAsync(x=>x.Id==id);
        }

        public void Update(T entity)
        {
            //_context.Set<T>().Update(entity);
            _dbSet.Update(entity);
            _context.SaveChanges();
        }
    }
}
