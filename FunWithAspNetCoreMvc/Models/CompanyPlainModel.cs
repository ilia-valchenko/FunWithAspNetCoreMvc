namespace FunWithAspNetCoreMvc.Models
{
    // It's better to use plain models (Anemic Domain Model) which don't have any logic (methods, complicated constructors, etc.)
    // Looks like Martin Fowler thinks that it's an anti-pattern. It violates one of OOP principles. Class should incapsulates its
    // data and methods which work with this data. We usually put such methods in separate services.
    public class CompanyPlainModel
    {
        public string CompanyName { get; set; }

        public int NumberOfEmployees { get; set; }

        public double AverageSalaryAmount { get; set; }
    }
}