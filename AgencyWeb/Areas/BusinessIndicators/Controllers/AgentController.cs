using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using AgencyWeb.Services;
using Microsoft.AspNetCore.Mvc;
using AgencyWeb.Areas.BaseController;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    [Route("[area]/[controller]")]
    public class AgentController : BaseBusinessIndicatorController
    {
        //Uri baseAddress = new Uri("http://localhost:49557/api");
        //private readonly HttpClient _client;

        private readonly IApiService _apiService;

        public AgentController(IApiService apiService)
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
        public IActionResult AgentDetail()
        {
            return View();
        }
        [HttpGet("[action]")]
        [HttpGet]
        public object GetAgentList(DataSourceLoadOptions loadOptions)
        {
            var _response = _apiService.GetAgentListApi();

            return DataSourceLoader.Load(_response, loadOptions);
        }
    }
}
