using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class ClaimReportController : BaseFunctionController
    {
        private readonly IApiService _apiService;

        public ClaimReportController(IApiService apiService)
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
            var _response = model.Where(p => p.ClaimReportId == id).First();
            return View(_response);
        }

        [HttpGet("[action]")]
        public object GetList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ClaimReportDto> model = new List<ClaimReportDto>()
        {
            new ClaimReportDto
            {
                ClaimReportId = 1,
                Policy = "HĐ-7737",
                ClaimNumber = "QLBH-34534",
                LifeAssured = "Phạm Văn Hai",
                ClaimBenefit = "Chi trả tai nạn",
                EventDate = DateTime.Now,
                ClaimApprovedAmount = 75000000,
                ClaimStatus = "Được duyệt",
                Notification = "Thông báo",
                DateOfClaimSubmission = DateTime.Now,
                DateOfSupplementingDocuments = DateTime.Now,
                DateOfDecision = DateTime.Now,
                Agent = "Nguyễn Văn A - 4234",
            },
            new ClaimReportDto
            {
                ClaimReportId = 2,
                Policy = "HĐ-4353",
                ClaimNumber = "QLBH-53823",
                LifeAssured = "Phạm Văn Hai",
                ClaimBenefit = "Chi trả tai nạn",
                EventDate = DateTime.Now,
                ClaimApprovedAmount = 45000000,
                ClaimStatus = "Được duyệt",
                Notification = "Thông báo",
                DateOfClaimSubmission = DateTime.Now,
                DateOfSupplementingDocuments = DateTime.Now,
                DateOfDecision = DateTime.Now,
                Agent = "Nguyễn Văn A - 4234",
            },
            new ClaimReportDto
            {
                ClaimReportId = 3,
                Policy = "HĐ-653345",
                ClaimNumber = "QLBH-978056",
                LifeAssured = "Phạm Văn Hai",
                ClaimBenefit = "Chi trả tai nạn",
                EventDate = DateTime.Now,
                ClaimApprovedAmount = 35000000,
                ClaimStatus = "Được duyệt",
                Notification = "Thông báo",
                DateOfClaimSubmission = DateTime.Now,
                DateOfSupplementingDocuments = DateTime.Now,
                DateOfDecision = DateTime.Now,
                Agent = "Nguyễn Văn A - 4234",
            },

        };
    }
}
