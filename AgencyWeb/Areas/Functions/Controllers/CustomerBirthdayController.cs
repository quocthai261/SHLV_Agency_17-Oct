using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class CustomerBirthdayController : BaseFunctionController
    {
        private readonly IApiService _apiService;

        public CustomerBirthdayController(IApiService apiService)
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
        public IActionResult Detail(long id)
        {
            var _response = model.Where(p => p.CustomerBirthdayId == id).First();
            return View(_response);
        }

        [HttpGet("[action]")]
        public object GetList(DataSourceLoadOptions loadOptions)
        {
            var _response = model;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<CustomerBirthdayDto> model = new List<CustomerBirthdayDto>()
        {
            new CustomerBirthdayDto
            {
                CustomerBirthdayId = 1,
                Name = "Nguyễn Văn A",
                DateOfBirth = new DateTime(1990, 1, 15),
                Gender = "Nam",
                Address = "35 Nguyễn Huệ, Quận 1, Tphcm",
                PhoneNumber = "09376453645",
                Agent = "Phạm Thị Ngọc Bích"
            },
            new CustomerBirthdayDto
            {
                CustomerBirthdayId = 2,
                Name = "Nguyễn Văn A",
                DateOfBirth = new DateTime(1990, 1, 13),
                Gender = "Nam",
                Address = "35 Nguyễn Huệ, Quận 1, Tphcm",
                PhoneNumber = "09376453645",
                Agent = "Phạm Thị Ngọc Bích"
            },
            new CustomerBirthdayDto
            {
                CustomerBirthdayId = 3,
                Name = "Nguyễn Văn A",
                DateOfBirth = new DateTime(1990, 1, 7),
                Gender = "Nam",
                Address = "35 Nguyễn Huệ, Quận 1, Tphcm",
                PhoneNumber = "09376453645",
                Agent = "Phạm Thị Ngọc Bích"
            },

        };
    }
}
