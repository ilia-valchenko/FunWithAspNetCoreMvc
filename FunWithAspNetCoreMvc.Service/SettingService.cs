using System.Collections.Generic;
using System.Threading.Tasks;
using FunWithAspNetCoreMvc.Domain;
using FunWithAspNetCoreMvc.Repository;

namespace FunWithAspNetCoreMvc.Service
{
    public class SettingService : ISettingService
    {
        private readonly IRepository<Setting> settingRepository;

        public SettingService(IRepository<Setting> settingRepository)
        {
            this.settingRepository = settingRepository;
        }

        public async Task<IEnumerable<Setting>> GetAsync()
        {
            return await this.settingRepository.GetAllAsync();
        }

        public async Task<Setting> GetAsync(long id)
        {
            return await this.settingRepository.GetAsync(id);
        }
    }
}