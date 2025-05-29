using CharityNet.Domain.Interfaces;
using CharityNet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityNet.Infrastructure.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly CharityNetDbContextFactory _contextFactory;

        public GenericDataService(CharityNetDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> CreateAsync(T entity)
        {
            using (CharityNetDbContext context = _contextFactory.CreateDbContext()) 
            {
                EntityEntry<T> entityCreated = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return entityCreated.Entity;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (CharityNetDbContext context = _contextFactory.CreateDbContext())
            {
                T? entityToRemove = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                if (entityToRemove != null)
                {
                    context.Set<T>().Remove(entityToRemove);
                    await context.SaveChangesAsync();

                    return true;
                }

                return false;
            }
        }

        public async Task<IEnumerable<T>?> GetAllAsync()
        {
            using (CharityNetDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T>? entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            using (CharityNetDbContext context = _contextFactory.CreateDbContext())
            {
                T? entityToRead = await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                return entityToRead;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            using (CharityNetDbContext context = _contextFactory.CreateDbContext())
            {
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
