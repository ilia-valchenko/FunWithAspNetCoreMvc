using System.Collections.Generic;
using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Domain;

namespace FunWithAspNetCoreMvc.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetAsync(long id);

        Task InsertAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(T item);

        void SaveChanges();
    }
}