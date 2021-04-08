namespace FunWithAspNetCoreMvc.Models
{
    // It's better to use plain models which don't have any logic (methods, complicated constructors, etc.)
    public class CompanyPlainModel
    {
        public string CompanyName { get; set; }

        public int NumberOfEmployees { get; set; }

        public double AverageSalaryAmount { get; set; }
    }
}