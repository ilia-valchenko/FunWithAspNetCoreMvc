using System;

namespace FunWithAspNetCoreMvc.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModifiedDateTime { get; set; }
    }
}