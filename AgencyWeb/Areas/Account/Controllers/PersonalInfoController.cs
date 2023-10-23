using AgencyWeb.Areas.BaseController;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Account.Controllers
{
    [Route("[area]/[controller]")]
    public class PersonalInfoController : BaseAccountController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public PersonalInfoController(IApiService apiService)
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

        [HttpGet("[action]")]
        public object GetDocumenteList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetDocumenteListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
