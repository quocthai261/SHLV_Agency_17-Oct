using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.BusinessIndicators.Models;
using AgencyWeb.Services;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.BusinessIndicators.Controllers
{
    [Route("[area]/[controller]")]
    public class DailySalesReportController : BaseBusinessIndicatorController
    {
        private readonly IApiService _apiService;

        public DailySalesReportController(IApiService apiService)
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
                Name = "Cha"
            },
            new DropdownListModel
            {
                Code = "2",
                Name = "Reg"
            },
            new DropdownListModel
            {
                Code = "3",
                Name = "Are"
            },
            new DropdownListModel
            {
                Code = "4",
                Name = "Zon"
            },
            new DropdownListModel
            {
                Code = "5",
                Name = "Tea"
            },
            new DropdownListModel
            {
                Code = "6",
                Name = "Uni"
            },
            new DropdownListModel
            {
                Code = "7",
                Name = "Age"
            },
        };

        public static List<DailySalesReportDto> model = new List<DailySalesReportDto>()
        {
            new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 1),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 2),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 3),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 4),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 5),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 6),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 7),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 8),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 9),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 10),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 11),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 12),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 13),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 14),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 15),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 16),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 17),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 18),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 19),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 20),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 21),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 22),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 23),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 24),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 25),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 26),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 27),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 28),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 29),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 30),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 31),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Lê Hồng Vũ",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },

                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 1),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 2),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 3),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 4),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 5),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 6),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 7),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 8),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 9),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 10),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 11),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 12),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 13),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 14),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 15),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 16),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 17),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 18),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 19),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 20),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 21),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 22),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 23),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 24),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 25),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 26),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 27),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 28),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 29),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 30),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 31),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Vũ Trường Giang",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },

                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 1),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 2),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 3),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 4),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 5),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 6),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 7),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 8),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 9),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 10),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 11),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 12),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 13),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 14),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 15),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 16),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 17),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 18),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 19),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 20),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
                           new DailySalesReportDto
            {
                DailySaleReportId = 1,
                Amount = 150000,
                Date = new DateTime(2023, 1, 21),
                DateCaptionDisplay =  (new DateTime(2023, 1, 1)).ToString("dd/MM/yyyy"),

                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 2,
                Amount = 270000,
                Date = new DateTime(2023, 1, 22),
                DateCaptionDisplay =  (new DateTime(2023, 1, 2)).ToString("dd/MM/yyyy"),
                Type = 2,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 3,
                Amount = 73000,
                Date = new DateTime(2023, 1, 23),
                DateCaptionDisplay =  (new DateTime(2023, 1, 3)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 4,
                Amount = 550000,
                Date = new DateTime(2023, 1, 24),
                DateCaptionDisplay =  (new DateTime(2023, 1, 4)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 5,
                Amount = 700000,
                Date = new DateTime(2023, 1, 25),
                DateCaptionDisplay =  (new DateTime(2023, 1, 5)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 6,
                Amount = 320000,
                Date = new DateTime(2023, 1, 26),
                DateCaptionDisplay =  (new DateTime(2023, 1, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
            new DailySalesReportDto
            {
                DailySaleReportId = 7,
                Amount = 320000,
                Date = new DateTime(2023, 1, 27),
                DateCaptionDisplay =  (new DateTime(2023, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
             new DailySalesReportDto
            {
                DailySaleReportId = 8,
                Amount = 320000,
                Date = new DateTime(2023, 1, 28),
                DateCaptionDisplay =  (new DateTime(2022, 2, 6)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
              new DailySalesReportDto
            {
                DailySaleReportId = 9,
                Amount = 320000,
                Date = new DateTime(2023, 1, 29),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 30),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            },
               new DailySalesReportDto
            {
                DailySaleReportId = 10,
                Amount = 210000,
                Date = new DateTime(2023, 1, 31),
                DateCaptionDisplay =  (new DateTime(2022, 2, 11)).ToString("dd/MM/yyyy"),
                Type = 1,
                TypeName = "Nguyễn Thiên Tú",

                CreationDate = DateTime.Now,
                LastUpdatedDate = DateTime.Now,
            }
        };
    }
}
