using AgencyWeb.Areas.BaseController;
using AgencyWeb.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    [Route("[area]/[controller]")]
    public class ISInhouseController : BaseBusinessIndicatorController
    {
        private readonly IApiService _apiService;

        public ISInhouseController(IApiService apiService)
        {
            //_client = new HttpClient();
            //_client.BaseAddress = baseAddress;
            _apiService = apiService;
        }
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]/{id}")]
        public IActionResult Detail(long id)
        {
            var _response = SampleData.userList.First(p => p.UserId == id);
            return View(_response);
        }

        [HttpGet("[action]")]
        public object GetISInhouse(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetUserListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
