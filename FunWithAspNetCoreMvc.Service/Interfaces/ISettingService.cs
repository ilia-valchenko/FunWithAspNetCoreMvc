using System.Collections.Generic;
using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Domain;

namespace FunWithAspNetCoreMvc.Service.Interfaces
{
    public interface ISettingService
    {
        Task<IEnumerable<Setting>> GetAsync();

        Task<Setting> GetAsync(long id);
    }
}