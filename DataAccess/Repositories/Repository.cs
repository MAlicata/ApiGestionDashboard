﻿using Microsoft.EntityFrameworkCore;
using ApiGestionDashboard.DataAccess.Repositories.Interfaces;

namespace ApiGestionDashboard.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }       

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        
        public virtual async Task<bool> Insert(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return true;
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
            
        }
      
    }
}
