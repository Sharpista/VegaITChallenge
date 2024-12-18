﻿namespace Domain.Interfaces.Commom.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T?> Get(int id);
        Task<IEnumerable<T>?> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(int id);
        Task<int> SaveChanges();
        void Dispose();
    }
}
