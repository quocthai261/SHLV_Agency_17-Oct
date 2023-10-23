using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class PremiumCollectionReportController : BaseFunctionController
    {
        private readonly IApiService _apiService;

        public PremiumCollectionReportController(IApiService apiService)
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
        [HttpGet("[action]/{id}")]
        public IActionResult Detail(long id)
        {
            var _response = model.Where(p => p.PremiumCollectionReportId == id).First();
            return View(_response);
        }

        [HttpGet("[action]")]
        public object GetList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<PremiumCollectionReportDto> model = new List<PremiumCollectionReportDto>()
        {
            new PremiumCollectionReportDto
            {
                PremiumCollectionReportId = 1,
                Policy = "HĐ-7737",
                Agent = "Nguyễn Văn A",
                PolicyOnwer = "Trần Văn B",
                LifeAssured = "Phạm Văn D",
                PhoneNumber = "0937532131",
                Address = "25 Lê Duẫn, Tphcm",
                BillingFrequency = 1000000,
                RegularPremium = 12500000,

                FirstIssuedDate = DateTime.Now,
                DateClosingOfPaid = DateTime.Now,
                PolicyStatus = "Đang chờ duyệt"
            },
            new PremiumCollectionReportDto
            {
                PremiumCollectionReportId = 2,
                Policy = "HĐ-589",
                Agent = "Trần Thị Tú",
                PolicyOnwer = "Lê Văn Được",
                LifeAssured = "Lê Huỳnh Dung",
                PhoneNumber = "0851235436",
                Address = "35 Nguyễn Huệ, Tphcm",
                BillingFrequency = 1300000,
                RegularPremium = 21500000,

                FirstIssuedDate = DateTime.Now,
                DateClosingOfPaid = DateTime.Now,
                PolicyStatus = "Đang chờ duyệt"
            },
            new PremiumCollectionReportDto
            {
                PremiumCollectionReportId = 3,
                Policy = "HĐ-9334",
                Agent = "Nguyễn Văn A",
                PolicyOnwer = "Trần Văn B",
                LifeAssured = "Phạm Văn D",
                PhoneNumber = "0937532131",
                Address = "225 CMTT, Tphcm",
                BillingFrequency = 2400000,
                RegularPremium = 542500000,

                FirstIssuedDate = DateTime.Now,
                DateClosingOfPaid = DateTime.Now,
                PolicyStatus = "Đang chờ duyệt"
            },

        };
    }
}
