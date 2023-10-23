using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.BusinessIndicators.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    [Route("[area]/[controller]")]
    public class RateMaintenanceReportController : BaseBusinessIndicatorController
    {
        private readonly IApiService _apiService;

        public RateMaintenanceReportController(IApiService apiService)
        {
            _apiService = apiService;
        }
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        [HttpGet("[action]")]
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
        public object GetDataTableChildList(long id, DataSourceLoadOptions loadOptions)
        {
            var _response = model.First(p => p.RateMaintenanceReportId == id).child;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        //[HttpGet]
        //public object GetTypeListApi(DataSourceLoadOptions loadOptions)
        //{
        //    var _response = modelType;

        //    return DataSourceLoader.Load(_response, loadOptions);
        //}

        public static List<RateMaintenanceReportDto> model = new List<RateMaintenanceReportDto>()
        {
            new RateMaintenanceReportDto
            {
                RateMaintenanceReportId = 1,
                ToBeRenewed = "TM-1231432",
                Policy = "HD-6543432",
                PolicyOwner =  "Nguyễn Văn A",

                DateOfFirstIssued = DateTime.Now,
                DateOfClosePaid = DateTime.Now,

                PolicyStatus = "Chờ duyệt",
                IssuedAPE = "APE",
                CurrentAPE = "APE",
                Agent = "Hà Thanh Thảo",
                AgentStatus = "Đang hoạt động",
                SharedAgent = "Trần Thị Hòa",

                child = new List<RateMaintenanceReportChildDto>
                {
                    new RateMaintenanceReportChildDto

                {
                    RateMaintenanceReportChildId = 1,
                InforceAPE = 4564,
                IssuedAPE = 867867,
                PersistencyRatio = 99.24,
                PersistencyRatioString = 99.24 + "%",

                ExpectedPersistencyRatio = 0,
                RenewedAPETotal = 0,
                ClosingDateOfPaidAPETotal = 0,

                PolicyRenewedTotal = 2,
                APERenewedTotal = 3,
                PercentPersistencyRatio = 90,
                PercentPersistencyRatioString = 90 + "%"
                }
                },
            },
            new RateMaintenanceReportDto
            {
                RateMaintenanceReportId = 2,
                ToBeRenewed = "TM-4563",
                Policy = "HD-12343",
                PolicyOwner =  "Nguyễn Văn B",

                DateOfFirstIssued = DateTime.Now,
                DateOfClosePaid = DateTime.Now,

                PolicyStatus = "Đã duyệt",
                IssuedAPE = "APE",
                CurrentAPE = "APE",
                Agent = "Hà Thanh Thảo",
                AgentStatus = "Đang hoạt động",
                SharedAgent = "Trần Thị Hòa",

                 child = new List<RateMaintenanceReportChildDto>
                {
                    new RateMaintenanceReportChildDto

                {
                    RateMaintenanceReportChildId = 2,
                InforceAPE = 32423,
                IssuedAPE = 1231,
                PersistencyRatio = 99.24,
                PersistencyRatioString = 99.24 + "%",

                ExpectedPersistencyRatio = 0,
                RenewedAPETotal = 0,
                ClosingDateOfPaidAPETotal = 0,

                PolicyRenewedTotal = 2,
                APERenewedTotal = 3,
                PercentPersistencyRatio = 90,
                PercentPersistencyRatioString = 90 + "%"
                }
                },
            },
            new RateMaintenanceReportDto
            {
                RateMaintenanceReportId = 3,
                ToBeRenewed = "TM-96565",
                Policy = "HD-55555",
                PolicyOwner =  "Nguyễn Văn C",

                DateOfFirstIssued = DateTime.Now,
                DateOfClosePaid = DateTime.Now,

                PolicyStatus = "Chờ duyệt",
                IssuedAPE = "APE",
                CurrentAPE = "APE",
                Agent = "Hà Thanh Thảo",
                AgentStatus = "Đang hoạt động",
                SharedAgent = "Trần Thị Hòa",

                 child = new List<RateMaintenanceReportChildDto>
                {
                    new RateMaintenanceReportChildDto

                {
                    RateMaintenanceReportChildId = 3,
                InforceAPE = 75675,
                IssuedAPE = 456456,
                PersistencyRatio = 99.24,
                PersistencyRatioString = 99.24 + "%",

                ExpectedPersistencyRatio = 0,
                RenewedAPETotal = 0,
                ClosingDateOfPaidAPETotal = 0,

                PolicyRenewedTotal = 2,
                APERenewedTotal = 3,
                PercentPersistencyRatio = 90,
                PercentPersistencyRatioString = 90 + "%"
                }
                },
            },
        };

        public static List<RateMaintenanceReportChildDto> modelChild = new List<RateMaintenanceReportChildDto>()
        {
            new RateMaintenanceReportChildDto
            {
                RateMaintenanceReportChildId = 1,
                InforceAPE = 710838,
                IssuedAPE = 716261,
                PersistencyRatio = 99.24,
                PersistencyRatioString = 99.24 + "%",

                ExpectedPersistencyRatio = 0,
                RenewedAPETotal = 0,
                ClosingDateOfPaidAPETotal = 0,
                
                PolicyRenewedTotal = 2,
                APERenewedTotal = 3,
                PercentPersistencyRatio = 90,
                PercentPersistencyRatioString = 90 + "%"
            },
        };
    }
}
