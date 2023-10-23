using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.BusinessIndicators.Models;
using AgencyWeb.Areas.Functions.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class ContractRecordController : BaseFunctionController
    {
        private readonly IApiService _apiService;

        public ContractRecordController(IApiService apiService)
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
            var _response = model.Where(p => p.ContractRecordId == id).First();
            return View(_response);
        }

        [HttpGet("[action]")]
        public object GetList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<ContractRecordDto> model = new List<ContractRecordDto>()
        {
            new ContractRecordDto
            {
                ContractRecordId = 1,
                Proposal = "HS-001",
                Policy = "HĐ-7737",
                MainProduct = "Shinhan life 834589",
                PolicyOwner = "0856345345",
                AddressCustomer = "35 Nguyễn Huệ, Quận 1, Tphcm",
                LifeAssured = "Nguyễn Văn A",
                RegularPremium = 1250000000,
                TemporaryCollection = 5500000,
                StatusProposal = "Đang thẩm định",
                InformationMore = "Chờ bổ sung thông tin",
                DateAdditionalDocument = DateTime.Now,
                DownloadAttachment = "",
                DateAdditionalContract = DateTime.Now,
                ReleaseDateContract = DateTime.Now,
                Status = "Đang chờ",
                DateNBUTransferCS = DateTime.Now,
                DateCSReceiveContract = DateTime.Now,
                DateTVTCReceiveContract = DateTime.Now,
                DateTVTCSendMailCS = DateTime.Now,
                DateSignContract = DateTime.Now,
                EndDateFee = DateTime.Now,
                ExpiresDate = DateTime.Now,
                TVTCName = "Trần Thị B - 223",
                TVTCOtherName = "Phạm Phương Thảo - 7423",
                OfficeName = "25 Lê Duẫn, Tphcm",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new ContractRecordDto
            {
                ContractRecordId = 2,
                Proposal = "HS-002",
                Policy = "HĐ-4346",
                MainProduct = "Shinhan life",
                PolicyOwner = "09732423434",
                AddressCustomer = "35 Nguyễn Huệ, Quận 1, Tphcm",
                LifeAssured = "Nguyễn Văn A",
                RegularPremium = 7500000,
                TemporaryCollection = 300000,
                StatusProposal = "Đang thẩm định",
                InformationMore = "Chờ bổ sung thông tin",
                DateAdditionalDocument = DateTime.Now,
                DownloadAttachment = "",
                DateAdditionalContract = DateTime.Now,
                ReleaseDateContract = DateTime.Now,
                Status = "Đang chờ",
                DateNBUTransferCS = DateTime.Now,
                DateCSReceiveContract = DateTime.Now,
                DateTVTCReceiveContract = DateTime.Now,
                DateTVTCSendMailCS = DateTime.Now,
                DateSignContract = DateTime.Now,
                EndDateFee = DateTime.Now,
                ExpiresDate = DateTime.Now,
                TVTCName = "Trần Thị B - 223",
                TVTCOtherName = "Phạm Phương Thảo - 7423",
                OfficeName = "25 Lê Duẫn, Tphcm",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
        };

    }
}
