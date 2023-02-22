using LeaveManagement.Configuration.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LeaveManagement.Repositories
{
    //<T> denotes genericType
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Db Ref copy
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context) {
            this.context = context;
        }

        //Add operation from create(LTController)
        public async Task<T> AddAsync(T entity)
        {
            //before add entity has no 
            await context.AddAsync(entity);
            await context.SaveChangesAsync();

            //return entity with id
            return entity;
        } 
        public async Task AddRangeAsync(List<T> entities)
        {
            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
            //return nothing

        }

        //leaveType -> Set<T>() why bcz input from any table excepted not leaveType
        public async Task<T?> GetAsync(int? id)
        { 
            if (id == null)
            {
                return null;
            }
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }
        
        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);

            if(entity!=null) { context.Set<T>().Remove(entity); }
            
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);

            return entity != null;
        }

        public async Task UpdateAsync(T entity)
        {
            //context.Entry(entity).State= EntityState.Modified;  valid

            context.Update(entity);
            await context.SaveChangesAsync();
        }

       
    }
}
