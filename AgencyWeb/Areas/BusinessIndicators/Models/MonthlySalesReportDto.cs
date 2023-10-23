namespace AgencyWeb.Areas.BusinessIndicators.Models
{
    public class MonthlySalesReportDto
    {
        public long MonthlySalesReportId { get; set; }
        public int Type { get; set; }
        public string TypeName { get; set; }

        public double IPSubmittedActual { get; set; }
        public double IPSubmittedPercentLastMonth { get; set; }
        public double IPNetIssuedActual { get; set; }
        public double IPNetIssuedPercentLastMonth { get; set; }
        public double IPPendingActual { get; set; }

        public double MPSubmittedActual { get; set; }
        public double MPSubmittedPercentLastMonth { get; set; }
        public double MPNetIssuedActual { get; set; }
        public double MPNetIssuedPercentLastMonth { get; set; }

        public double APESubmittedActual { get; set; }
        public double APESubmittedPercentLastMonth { get; set; }
        public double APENetIssuedTarget { get; set; }
        public double APENetIssuedActual { get; set; }
        public double APENetIssuedPercentTarget { get; set; }
        public double APENetIssuedPercentLastMonth { get; set; }

        public double RenewalCollectedActual { get; set; }

        public double PolicySubmitted { get; set; }
        public double PolicyIssueed { get; set; }
        public double PolicyPending { get; set; }
        public double PolicyIPPerIssued { get; set; }

        public long ManpowerNumberInforce { get; set; }
        public long ManpowerNumberRecruit { get; set; }
        public long ManpowerNumberActive { get; set; }
        public double ManpowerProductivityActiveRatio { get; set; }
        public double ManpowerProductivityIPPerActive { get; set; }
        public double ManpowerProductivityMPPerActive { get; set; }
        public double ManpowerProductivityAPEPerActive { get; set; }

        public double YTDIPActual { get; set; }
        public double YTDIPPercentLastMonth { get; set; }
        public double YTDMPActual { get; set; }
        public double YTDMPPercentLastMonth { get; set; }
        public double YTDAPETarget { get; set; }
        public double YTDAPEActual { get; set; }
        public double YTDAPEPercentTarget { get; set; }
        public double YTDAPEPercentLastYear { get; set; }

        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }

    }

    public class DropdownListModel
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
