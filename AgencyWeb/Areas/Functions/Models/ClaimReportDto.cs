namespace AgencyWeb.Areas.Functions.Models
{
    public class ClaimReportDto
    {
        public long ClaimReportId { get; set; }
        public string Policy { get; set; }
        public string ClaimNumber { get; set; }
        public string LifeAssured { get; set; }
        public string ClaimBenefit { get; set; }
        public DateTime EventDate { get; set; }
        public double ClaimApprovedAmount { get; set; }
        public string ClaimStatus { get; set; }
        public string Notification { get; set; }
        public DateTime DateOfClaimSubmission { get; set; }
        public DateTime DateOfSupplementingDocuments { get; set; }
        public DateTime DateOfDecision { get; set; }
        public string Agent { get; set; }
    }
}
