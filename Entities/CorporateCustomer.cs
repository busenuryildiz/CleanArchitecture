namespace CleanArchitecture.Entities
{
    public class CorporateCustomer:BaseCustomer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
