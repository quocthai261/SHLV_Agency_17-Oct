using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AgencyWeb.Areas.BusinessIndicators.Models
{
    public class RateMaintenanceReportDto
    {
        public long RateMaintenanceReportId { get; set; }
        public string ToBeRenewed { get; set; }
        public string Policy { get; set; }
        public string PolicyOwner { get; set; }
        public DateTime DateOfFirstIssued { get; set; }
        public DateTime DateOfClosePaid { get; set; }
        public string PolicyStatus { get; set; }
        public string IssuedAPE { get; set; }
        public string CurrentAPE { get; set; }
        public string Agent { get; set; }
        public string AgentStatus { get; set; }
        public string SharedAgent { get; set; }

        public List<RateMaintenanceReportChildDto> child { get; set; }
    }

    public class RateMaintenanceReportChildDto
    {
        public long RateMaintenanceReportChildId { get; set; }
        public double InforceAPE { get; set; }
        public double IssuedAPE { get; set; }
        public double PersistencyRatio { get; set; }
        public string PersistencyRatioString { get; set; }


        public double ExpectedPersistencyRatio { get; set; }
        public double RenewedAPETotal { get; set; }
        public double ClosingDateOfPaidAPETotal { get; set; }

        public int PolicyRenewedTotal { get; set; }
        public int APERenewedTotal { get; set; }
        public double PercentPersistencyRatio { get; set; }
        public string PercentPersistencyRatioString { get; set; }
    }

}
