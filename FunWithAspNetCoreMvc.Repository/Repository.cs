using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Domain;
using Microsoft.EntityFrameworkCore;

namespace FunWithAspNetCoreMvc.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly ApplicationContext context;

        private DbSet<T> entities;

        public Repository(/*ApplicationContext context*/)
        {
            //this.context = context;
            //this.entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            //return Task.FromResult(this.entities.AsEnumerable());

            return await Task.FromResult(new[]
            {
                new T {
                    Id = 1,
                    LastModifiedBy = "user-id",
                    LastModifiedDateTime = DateTime.Now
                },
                new T {
                    Id = 2,
                    LastModifiedBy = "user-id",
                    LastModifiedDateTime = DateTime.Now
                },
                new T {
                    Id = 3,
                    LastModifiedBy = "user-id",
                    LastModifiedDateTime = DateTime.Now
                }
            }.AsEnumerable());
        }

        public async Task<T> GetAsync(long id)
        {
            //return await this.entities.FirstOrDefaultAsync(e => e.Id == id);

            return await Task.FromResult(new T
            {
                Id = 1,
                LastModifiedBy = "user-id",
                LastModifiedDateTime = DateTime.Now
            });
        }

        public Task DeleteAsync(T item)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertAsync(T item)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T item)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}