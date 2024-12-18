using Domain.Entities.Base;
using Domain.Interfaces.Commom.Base;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase, new()
    {

        protected readonly AppReservasContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        public Repository(AppReservasContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T?> Get(int id)
        {
            return await _dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>?> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task Add(T entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Delete(int id)
        {
            _dbSet.Remove(new T { Id = id });
            await SaveChanges();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }
        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
