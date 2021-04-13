using FunWithAspNetCoreMvc.Domain;
using Microsoft.EntityFrameworkCore;

namespace FunWithAspNetCoreMvc.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new SettingMap(modelBuilder.Entity<Setting>());
        }
    }
}