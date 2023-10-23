using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.BusinessIndicators.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    [Route("[area]/[controller]")]
    public class MonthlySalesReportController : BaseBusinessIndicatorController
    {
        private readonly IApiService _apiService;

        public MonthlySalesReportController(IApiService apiService)
        {
            _apiService = apiService;
        }
        [HttpGet("[action]")]

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            return View();
        }

        [HttpGet("[action]")]

        public object GetList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet("[action]")]

        public object GetTypeListApi(DataSourceLoadOptions loadOptions)
        {
            var _response = modelType;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<DropdownListModel> modelType = new List<DropdownListModel>()
        {
            new DropdownListModel
            {
                Code = "1",
                Name = "Channel"
            },
            new DropdownListModel
            {
                Code = "2",
                Name = "Region"
            },
            new DropdownListModel
            {
                Code = "3",
                Name = "Area"
            },
            new DropdownListModel
            {
                Code = "4",
                Name = "Zone"
            },
            new DropdownListModel
            {
                Code = "5",
                Name = "Team"
            },
            new DropdownListModel
            {
                Code = "6",
                Name = "Unit"
            },
            new DropdownListModel
            {
                Code = "7",
                Name = "Individual"
            },
        };

        public static List<MonthlySalesReportDto> model = new List<MonthlySalesReportDto>()
        {
            new MonthlySalesReportDto {
                        MonthlySalesReportId = 1,
                        Type = 1,
                        TypeName = "Channel",

                        IPSubmittedActual = 1000000,
                        IPSubmittedPercentLastMonth = -10.5,
                        IPNetIssuedActual = 250000,
                        IPNetIssuedPercentLastMonth = 7.5,
                        IPPendingActual = 50000,

                        MPSubmittedActual = 350000000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 700000,
                        APESubmittedPercentLastMonth = -4,
                        APENetIssuedTarget = 5500000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },

            new MonthlySalesReportDto {
                        MonthlySalesReportId = 2,
                        Type = 1,
                        TypeName = "TM",

                        IPSubmittedActual = 230000,
                        IPSubmittedPercentLastMonth = 12.2,
                        IPNetIssuedActual = 10500,
                        IPNetIssuedPercentLastMonth = 3.5,
                        IPPendingActual = 78000,

                        MPSubmittedActual = 350000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 230000,
                        APESubmittedPercentLastMonth = -4,
                        APENetIssuedTarget = 240000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },


            new MonthlySalesReportDto {
                        MonthlySalesReportId = 4,
                        Type = 1,
                        TypeName = "GA",

                        IPSubmittedActual = 65000,
                        IPSubmittedPercentLastMonth = 5.2,
                        IPNetIssuedActual = 10500,
                        IPNetIssuedPercentLastMonth = 13.5,
                        IPPendingActual = 78000,

                        MPSubmittedActual = 83000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 150000,
                        APESubmittedPercentLastMonth = 2,
                        APENetIssuedTarget = 240000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new MonthlySalesReportDto {
                        MonthlySalesReportId = 5,
                        Type = 1,
                        TypeName = "Unit",

                        IPSubmittedActual = 65000,
                        IPSubmittedPercentLastMonth = 5.2,
                        IPNetIssuedActual = 10500,
                        IPNetIssuedPercentLastMonth = 13.5,
                        IPPendingActual = 78000,

                        MPSubmittedActual = 83000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 150000,
                        APESubmittedPercentLastMonth = 2,
                        APENetIssuedTarget = 240000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
            new MonthlySalesReportDto {
                        MonthlySalesReportId = 6,
                        Type = 1,
                        TypeName = "Nguyễn Văn Hiếu",

                        IPSubmittedActual = 65000,
                        IPSubmittedPercentLastMonth = 5.2,
                        IPNetIssuedActual = 10500,
                        IPNetIssuedPercentLastMonth = 13.5,
                        IPPendingActual = 78000,

                        MPSubmittedActual = 83000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 150000,
                        APESubmittedPercentLastMonth = 2,
                        APENetIssuedTarget = 240000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
                        new MonthlySalesReportDto {
                        MonthlySalesReportId = 3,
                        Type = 1,
                        TypeName = "Vũ Trường Giang",

                        IPSubmittedActual = 65000,
                        IPSubmittedPercentLastMonth = 5.2,
                        IPNetIssuedActual = 10500,
                        IPNetIssuedPercentLastMonth = 13.5,
                        IPPendingActual = 78000,

                        MPSubmittedActual = 83000,
                        MPSubmittedPercentLastMonth = 12.5,
                        MPNetIssuedActual = 65000,
                        MPNetIssuedPercentLastMonth = -5.5,

                        APESubmittedActual = 150000,
                        APESubmittedPercentLastMonth = 2,
                        APENetIssuedTarget = 240000,
                        APENetIssuedActual = 4500000,
                        APENetIssuedPercentTarget = 12.2,
                        APENetIssuedPercentLastMonth = -8.7,

                        RenewalCollectedActual = 7.3,

                        PolicySubmitted = 230000,
                        PolicyIssueed = 340000,
                        PolicyPending = 240000,
                        PolicyIPPerIssued = 12000,

                        ManpowerNumberInforce = 25000,
                        ManpowerNumberRecruit = 28,
                        ManpowerNumberActive = 32,
                        ManpowerProductivityActiveRatio = 5.4,
                        ManpowerProductivityIPPerActive = 7.5,
                        ManpowerProductivityAPEPerActive = 10500,
                        ManpowerProductivityMPPerActive = 12000,

                        YTDIPActual = 83000,
                        YTDIPPercentLastMonth = -7.2,
                        YTDMPActual = 78000,
                        YTDMPPercentLastMonth = 9.4,
                        YTDAPETarget = 150000,
                        YTDAPEActual = 100000,
                        YTDAPEPercentTarget = 50,
                        YTDAPEPercentLastYear = -23,

                        CreationDate = DateTime.Now,
                        LastUpdatedDate = DateTime.Now,
                    },
        };
    }
}
