namespace AgencyWeb.Areas.Functions.Models
{
    public class PremiumCollectionReportDto
    {
        public long PremiumCollectionReportId { get; set; }
        public string Policy { get; set; }
        public string Agent { get; set; }
        public string PolicyOnwer { get; set; }
        public string LifeAssured { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public double BillingFrequency { get; set; }
        public double RegularPremium { get; set; }
        public DateTime FirstIssuedDate { get; set; }
        public DateTime DateClosingOfPaid { get; set; }
        public string PolicyStatus { get; set; }

    }
}
