using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunWithAspNetCoreMvc.Domain
{
    public class SettingMap
    {
        public SettingMap(EntityTypeBuilder<Setting> entityBuilder)
        {
            entityBuilder.HasKey(e => e.Id);
            entityBuilder.Property(e => e.LastModifiedBy);
            entityBuilder.Property(e => e.LastModifiedDateTime);
            entityBuilder.Property(e => e.Code);
            entityBuilder.Property(e => e.DefaultValue);
            entityBuilder.Property(e => e.CustomValue);
        }
    }
}