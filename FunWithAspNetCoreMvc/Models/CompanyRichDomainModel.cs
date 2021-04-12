namespace FunWithAspNetCoreMvc.Models
{
    // Rich/Fat/Thick domain model
    public class CompanyRichDomainModel
    {
        public string CompanyName { get; set; }

        public int NumberOfEmployees { get; set; }

        public double AverageSalaryAmount { get; set; }

        public override string ToString()
        {
            return $"Name: {this.CompanyName}, Employees: {this.NumberOfEmployees}";
        }
    }
}