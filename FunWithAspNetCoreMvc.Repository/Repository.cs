using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Domain;
using Microsoft.EntityFrameworkCore;

namespace FunWithAspNetCoreMvc.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;

        private DbSet<T> entities;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult(this.entities.AsEnumerable());
        }

        public async Task<T> GetAsync(long id)
        {
            return await this.entities.FirstOrDefaultAsync(e => e.Id == id);
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