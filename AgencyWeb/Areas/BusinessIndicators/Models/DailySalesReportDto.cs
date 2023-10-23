namespace AgencyWeb.Areas.BusinessIndicators.Models
{
    public class DailySalesReportDto
    {
        public long DailySaleReportId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string DateCaptionDisplay { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
