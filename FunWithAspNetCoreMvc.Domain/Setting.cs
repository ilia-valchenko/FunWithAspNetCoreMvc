namespace FunWithAspNetCoreMvc.Domain
{
    public class Setting : BaseEntity
    {
        public string Code { get; set; }

        public string DefaultValue { get; set; }

        public string CustomValue { get; set; }
    }
}