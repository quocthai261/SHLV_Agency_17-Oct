using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class RegisterController : BaseFunctionController
    {
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]")]
        public IActionResult List(string typeOfContest)
        {
            try
            {
                ViewBag.TypeOfContest = typeOfContest;
                ContestGeneral contestGeneral = new ContestGeneral();

                if (typeOfContest == "new")
                {
                    contestGeneral.RegisterNewContest = new List<RegisterNewContestDto>();
                    contestGeneral.RegisterNewContest = newContestList;
                }
                else if (typeOfContest == "happening")
                {
                    contestGeneral.HappeningContest = new List<HappeningContestDto>();
                    contestGeneral.HappeningContest = happeningContestList;
                }
                else if (typeOfContest == "finished")
                {
                    contestGeneral.FinishedContest = new List<FinishedContestDto>();
                    contestGeneral.FinishedContest = finishedContestList;
                }
                else if (typeOfContest == "incomplete")
                {
                    contestGeneral.IncompleteContest = new List<IncompleteContestDto>();
                    contestGeneral.IncompleteContest = incompleteContestList;
                }

                return View(contestGeneral);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<RegisterNewContestDto> newContestList = new List<RegisterNewContestDto>()
        {
            new RegisterNewContestDto
            {
                ContestId = 1,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new RegisterNewContestDto
            {
                ContestId = 2,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new RegisterNewContestDto
            {
                ContestId = 3,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 79,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
            new RegisterNewContestDto
            {
                ContestId = 4,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new RegisterNewContestDto
            {
                ContestId = 5,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new RegisterNewContestDto
            {
                ContestId = 6,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 79,
                CreatedDay = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
        };

        public static List<HappeningContestDto> happeningContestList = new List<HappeningContestDto>()
        {
            new HappeningContestDto
            {
                ContestId = 1,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                Status = "Chưa đăng ký",
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new HappeningContestDto
            {
                ContestId = 2,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Đang diễn ra",
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new HappeningContestDto
            {
                ContestId = 3,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Đang diễn ra",
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
            new HappeningContestDto
            {
                ContestId = 4,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                Status = "Chưa đăng ký",
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new HappeningContestDto
            {
                ContestId = 5,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Đang diễn ra",
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
        };

        public static List<FinishedContestDto> finishedContestList = new List<FinishedContestDto>()
        {
            new FinishedContestDto
            {
                ContestId = 1,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                Status = "Đang diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new FinishedContestDto
            {
                ContestId = 2,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Chưa diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new FinishedContestDto
            {
                ContestId = 3,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Đang diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
            new FinishedContestDto
            {
                ContestId = 4,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                ExpireAfter = 116,
                Status = "Đang diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new FinishedContestDto
            {
                ContestId = 5,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Chưa diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new FinishedContestDto
            {
                ContestId = 6,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                ExpireAfter = 68,
                Status = "Đang diễn ra",
                RegisterDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
        };

        public static List<IncompleteContestDto> incompleteContestList = new List<IncompleteContestDto>()
        {
            new IncompleteContestDto
            {
                ContestId = 1,
                ContestName = "Memo 156 DF - Chào tháng 10 - 78J-Finance - Từ Japan Đến Sài Gòn",
                ContestCode = "254789",
                EndDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154.png"
            },
            new IncompleteContestDto
            {
                ContestId = 2,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                EndDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new IncompleteContestDto
            {
                ContestId = 3,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                EndDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
            new IncompleteContestDto
            {
                ContestId = 4,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                EndDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 154-1.png"
            },
            new IncompleteContestDto
            {
                ContestId = 5,
                ContestName = "Memo 189 DF - Chào tháng 11 - 87P-Economic - Từ Seoul Đến Nha Trang",
                ContestCode = "254790",
                EndDate = DateTime.Now,
                ImageUrl = "\\images\\contest\\Ellipse 2.png"
            },
        };
    }
}
