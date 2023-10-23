using AgencyWeb.Areas.BaseController;
using AgencyWeb.Areas.Functions.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AgencyWeb.Areas.Functions.Controllers
{
    [Route("[area]/[controller]")]

    public class ManagementContentController : BaseFunctionController
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ManagementContentController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpGet("[action]")]
        public IActionResult ListContest()
        {
            return View();
        }
        [HttpGet("[action]")]
        public IActionResult ListNewEvent()
        {
            return View();
        }
        [HttpGet("[action]/{Id}")]
        public IActionResult UpsertRegister(int? Id)
        {
            if (Id == null || Id == 0)
            {
                // create
                RegisterDetailDto model = new RegisterDetailDto();

                return View(model);
            }
            else
            {
                // update
                RegisterDetailDto model = listRegister.Where(x => x.Id == Id).FirstOrDefault();

                return View(model);
            }
        }

        [HttpGet("[action]")]
        public IActionResult UpsertRegister(RegisterDetailDto model)
        {
            return View(model);
        }
        [HttpGet("[action]/{Id}")]
        public IActionResult UpsertNewEvent(int? Id)
        {
            if (Id == null || Id == 0)
            {
                // create
                NewEventDetailDto model = new NewEventDetailDto();

                return View(model);
            }
            else
            {
                // update
                NewEventDetailDto model = listNewEvent.Where(x => x.Id == Id).FirstOrDefault();

                return View(model);
            }
        }

        [HttpGet("[action]")]
        public IActionResult UpsertNewEvent(NewEventDetailDto model)
        {
            return View(model);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UploadImage(IFormFile upload)
        {
            if (upload != null && upload.Length > 0)
            {
                var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), _webHostEnvironment.WebRootPath);
                path = Path.Combine(path, "uploads", fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    upload.CopyTo(stream);
                }

                var url = $"{"/uploads/"}{fileName}";
                var successMessage = "upload successfully";
                dynamic success = JsonConvert.DeserializeObject("{ 'uploaded': 1,'fileName': \"" + fileName + "\",'url': \"" + url + "\", 'error': { 'message': \"" + successMessage + "\"}}");

                return new JsonResult(success);
            }

            return RedirectToAction("Upsert");
        }

        public IActionResult UploadExplorer()
        {
            var dir = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), _webHostEnvironment.WebRootPath, "uploads"));
            ViewBag.fileInfo = dir.GetFiles();

            return View("FileExplorer");
        }
        [HttpGet("[action]/{Id}")]
        public IActionResult ViewDetailRegister(int Id)
        {
            RegisterDetailDto model = listRegister.Where(x => x.Id == 1).FirstOrDefault();

            return View(model);
        }
        [HttpGet("[action]/{Id}")]
        public IActionResult ViewDetailNewEvent(int Id)
        {
            NewEventDetailDto model = listNewEvent.Where(x => x.Id == 1).FirstOrDefault();

            return View(model);
        }

        [HttpGet("[action]")]
        public object GetRegisterPostList(DataSourceLoadOptions loadOptions)
        {
            var _response = listRegister;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        [HttpGet("[action]")]
        public object GetNewEventPostList(DataSourceLoadOptions loadOptions)
        {
            var _response = listNewEvent;

            return DataSourceLoader.Load(_response, loadOptions);
        }

        public static List<RegisterDetailDto> listRegister = new List<RegisterDetailDto>()
        {
           new RegisterDetailDto
           {
               Id = 1,
               Title = "Memo 148 DP 2023",
               Content = "<p style=\"text-align:center\"><img alt=\"\" src=\"/uploads/20231011100000Ellipse 154.png\" style=\"height:791px; width:800px\" /></p>\r\n\r\n<p style=\"text-align:center\">Kết th&uacute;c sau</p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:22px\"><strong>470 giờ</strong></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:20px\"><strong>Memo 148 DP 2023 - X&ocirc;ng Pha Tuyển Dụng</strong>&nbsp;-</span></p>\r\n\r\n<p style=\"text-align:center\"><strong><span style=\"font-size:20px\">H&acirc;n Hoan Vương Tầm - Th&aacute;ng 10.2023</span></strong></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:16px\">M&atilde; thi đua: 230148</span></p>\r\n\r\n<div style=\"background:#eeeeee; border:1px solid #cccccc; margin-bottom:0px; margin-left:auto; margin-right:auto; margin-top:0px; padding:5px 10px; text-align:center; width:fit-content\">Thời điểm kết th&uacute;c: Ng&agrave;y 31/10/2023</div>\r\n\r\n<p><strong>Th&ocirc;ng tin về thi đua</strong></p>\r\n\r\n<p style=\"text-align:center\"><img alt=\"\" src=\"/uploads/20231011131711Media view2.png\" style=\"height:201px; width:400px\" /><img alt=\"\" src=\"/uploads/20231011131732Rectangle 127.png\" style=\"height:201px; width:400px\" /></p>\r\n\r\n<p style=\"text-align:justify\">TP. Hồ Ch&iacute; Minh, ng&agrave;y 15/9/2023, Shinhan Life Việt Nam tiếp tục đồng h&agrave;nh c&ugrave;ng Bệnh viện Nhi đồng Th&agrave;nh Phố hỗ trợ cho c&aacute;c bệnh nhi ung thư m&aacute;u c&oacute; ho&agrave;n cảnh kh&oacute; khăn th&ocirc;ng qua việc t&agrave;i trợ 150.000.000 đồng chi ph&iacute; điều trị v&agrave; trao tặng hơn 120 phần qu&agrave; cho bệnh nhi khoa Huyết học l&acirc;m s&agrave;ng nh&acirc;n dịp Tết Trung thu.</p>\r\n\r\n<p style=\"text-align:justify\">&Ocirc;ng Bae Seung Jun &ndash; Tổng gi&aacute;m đốc Shinhan Life Việt Nam chia sẻ: &ldquo;Một trong những ưu ti&ecirc;n của Shinhan Life Việt Nam l&agrave; n&acirc;ng cao tr&aacute;ch nhiệm x&atilde; hội v&agrave; lan tỏa sự sẻ chia th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng. Đồng h&agrave;nh c&ugrave;ng bệnh viện nhi đồngTh&agrave;nh phố, ch&uacute;ng t&ocirc;i hy vọng rằng nguồn t&agrave;i trợ của Shinhan Life Việt Nam sẽ g&oacute;p phần động vi&ecirc;n tinh thần, tiếp th&ecirc;m sức mạnh cho c&aacute;c em v&agrave; gia đ&igrave;nh tr&ecirc;n h&agrave;nh tr&igrave;nh đấu tranh để chiến thắng bệnh tật&rdquo;.</p>\r\n\r\n<p style=\"text-align:justify\">Đ&acirc;y l&agrave; năm thứ hai li&ecirc;n tiếp Shinhan Life Việt Nam đồng h&agrave;nh c&ugrave;ng Bệnh viện Nhi đồng Th&agrave;nh Phố trong việc hỗ trợ chi ph&iacute; điều trị cho c&aacute;c bệnh nhi ung thư m&aacute;u với tổng số tiền t&agrave;i trợ 450.000.000 đồng. Gia đ&igrave;nh của 30 em nhỏ mắc bệnh ung thư m&aacute;u c&oacute; ho&agrave;n cảnh kh&oacute; khăn đ&atilde; nhận được sự hỗ trợ kịp thời về kinh tế để tiếp tục h&agrave;nh tr&igrave;nh chiến đấu với bệnh tật.</p>\r\n\r\n<p>Shinhan Life Việt Nam hy vọng rằng, th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng, sự sẻ chia v&agrave; t&igrave;nh y&ecirc;u thương sẽ được lan tỏa để trẻ em tr&ecirc;n khắp cả nước n&oacute;i chung v&agrave; c&aacute;c bệnh nhi kh&ocirc;ng may mắc bệnh hiểm ngh&egrave;o n&oacute;i ri&ecirc;ng, sẽ được vui sống trong v&ograve;ng tay y&ecirc;u thương, sẻ chia của cả cộng đồng.</p>\r\n\r\n<h5>Về Shinhan Life Việt Nam</h5>\r\n\r\n<p>C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</p>\r\n\r\n<p>Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\">https://shinhanlifevn.com.vn</a></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           },
           new RegisterDetailDto
           {
               Id = 2,
               Title = "Memo 135 XC 2023",
               Content = "<p style=\"text-align:center\"><img alt=\"contest Memo 148\" src=\"/uploads/20231011094538Ellipse 2.png\" style=\"height:400px; margin:10px; width:850px\" /></p>\r\n\r\n<p style=\"text-align:center\">Kết th&uacute;c sau</p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:22px\"><strong>470 giờ</strong></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:20px\"><strong>Memo 148 DP 2023 - X&ocirc;ng Pha Tuyển Dụng</strong>&nbsp;-</span></p>\r\n\r\n<p style=\"text-align:center\"><strong><span style=\"font-size:20px\">H&acirc;n Hoan Vương Tầm - Th&aacute;ng 10.2023</span></strong></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:16px\">M&atilde; thi đua: 230148</span></p>\r\n\r\n<div style=\"background:#eeeeee; border:1px solid #cccccc; margin-bottom:0px; margin-left:auto; margin-right:auto; margin-top:0px; padding:5px 10px; text-align:center; width:fit-content\">Thời điểm kết th&uacute;c: Ng&agrave;y 31/10/2023</div>\r\n\r\n<p><strong>Th&ocirc;ng tin về thi đua</strong></p>\r\n\r\n<p style=\"text-align:center\"><img alt=\"\" src=\"/uploads/20231011131711Media view2.png\" style=\"height:251px; width:400px\" /><img alt=\"\" src=\"/uploads/20231011131732Rectangle 127.png\" style=\"height:251px; width:400px\" /></p>\r\n\r\n<p style=\"text-align:justify\">TP. Hồ Ch&iacute; Minh, ng&agrave;y 15/9/2023, Shinhan Life Việt Nam tiếp tục đồng h&agrave;nh c&ugrave;ng Bệnh viện Nhi đồng Th&agrave;nh Phố hỗ trợ cho c&aacute;c bệnh nhi ung thư m&aacute;u c&oacute; ho&agrave;n cảnh kh&oacute; khăn th&ocirc;ng qua việc t&agrave;i trợ 150.000.000 đồng chi ph&iacute; điều trị v&agrave; trao tặng hơn 120 phần qu&agrave; cho bệnh nhi khoa Huyết học l&acirc;m s&agrave;ng nh&acirc;n dịp Tết Trung thu.</p>\r\n\r\n<p style=\"text-align:justify\">&Ocirc;ng Bae Seung Jun &ndash; Tổng gi&aacute;m đốc Shinhan Life Việt Nam chia sẻ: &ldquo;Một trong những ưu ti&ecirc;n của Shinhan Life Việt Nam l&agrave; n&acirc;ng cao tr&aacute;ch nhiệm x&atilde; hội v&agrave; lan tỏa sự sẻ chia th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng. Đồng h&agrave;nh c&ugrave;ng bệnh viện nhi đồngTh&agrave;nh phố, ch&uacute;ng t&ocirc;i hy vọng rằng nguồn t&agrave;i trợ của Shinhan Life Việt Nam sẽ g&oacute;p phần động vi&ecirc;n tinh thần, tiếp th&ecirc;m sức mạnh cho c&aacute;c em v&agrave; gia đ&igrave;nh tr&ecirc;n h&agrave;nh tr&igrave;nh đấu tranh để chiến thắng bệnh tật&rdquo;.</p>\r\n\r\n<p style=\"text-align:justify\">Đ&acirc;y l&agrave; năm thứ hai li&ecirc;n tiếp Shinhan Life Việt Nam đồng h&agrave;nh c&ugrave;ng Bệnh viện Nhi đồng Th&agrave;nh Phố trong việc hỗ trợ chi ph&iacute; điều trị cho c&aacute;c bệnh nhi ung thư m&aacute;u với tổng số tiền t&agrave;i trợ 450.000.000 đồng. Gia đ&igrave;nh của 30 em nhỏ mắc bệnh ung thư m&aacute;u c&oacute; ho&agrave;n cảnh kh&oacute; khăn đ&atilde; nhận được sự hỗ trợ kịp thời về kinh tế để tiếp tục h&agrave;nh tr&igrave;nh chiến đấu với bệnh tật.</p>\r\n\r\n<p>Shinhan Life Việt Nam hy vọng rằng, th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng, sự sẻ chia v&agrave; t&igrave;nh y&ecirc;u thương sẽ được lan tỏa để trẻ em tr&ecirc;n khắp cả nước n&oacute;i chung v&agrave; c&aacute;c bệnh nhi kh&ocirc;ng may mắc bệnh hiểm ngh&egrave;o n&oacute;i ri&ecirc;ng, sẽ được vui sống trong v&ograve;ng tay y&ecirc;u thương, sẻ chia của cả cộng đồng.</p>\r\n\r\n<h5>Về Shinhan Life Việt Nam</h5>\r\n\r\n<p>C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</p>\r\n\r\n<p>Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\">https://shinhanlifevn.com.vn</a></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           }
        };

        public static List<NewEventDetailDto> listNewEvent = new List<NewEventDetailDto>()
        {
           new NewEventDetailDto
           {
               Id = 1,
               Title = "SHINHAN LIFE VIỆT NAM TIẾP TỤC ĐỒNG HÀNH CÙNG BỆNH NHI UNG THƯ MÁU TRONG DỊP TẾT ĐOÀN VIÊN",
               Content = "<p style=\"text-align:center\"><span style=\"font-size:36px\"><span style=\"color:#9900ff\"><strong>S<strong>HINHAN LIFE VIỆT NAM TIẾP TỤC ĐỒNG H&Agrave;NH C&Ugrave;NG BỆNH NHI UNG THƯ M&Aacute;U TRONG DỊP TẾT ĐO&Agrave;N VI&Ecirc;N</strong></strong></span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:#7f8c8d\"><span style=\"font-size:18px\"><em>15-09-2023</em></span></span></p>\r\n\r\n<hr />\r\n<p><span style=\"font-size:16px\">TP. Hồ Ch&iacute; Minh, ng&agrave;y 15/9/2023, Shinhan Life Việt Nam tiếp tục đồng h&agrave;nh c&ugrave;ng Bệnh viện Nhi đồng Th&agrave;nh Phố hỗ trợ cho c&aacute;c bệnh nhi ung thư m&aacute;u c&oacute; ho&agrave;n cảnh kh&oacute; khăn th&ocirc;ng qua việc t&agrave;i trợ 150.000.000 đồng chi ph&iacute; điều trị v&agrave; trao tặng hơn 120 phần qu&agrave; cho bệnh nhi khoa Huyết học l&acirc;m s&agrave;ng nh&acirc;n dịp Tết Trung thu.</span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:16px\"><img alt=\"\" src=\"/uploads/20231012091729New11.png\" style=\"height:467px; margin:10px; width:700px\" /></span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"color:null\"><span style=\"font-size:16px\">&Ocirc;ng Bae Seung Jun &ndash; Tổng gi&aacute;m đốc Shinhan Life Việt Nam chia sẻ: &ldquo;Một trong những ưu ti&ecirc;n của Shinhan Life Việt Nam l&agrave; n&acirc;ng cao tr&aacute;ch nhiệm x&atilde; hội v&agrave; lan tỏa sự sẻ chia th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng. Đồng h&agrave;nh c&ugrave;ng bệnh viện nhi đồngTh&agrave;nh phố, ch&uacute;ng t&ocirc;i hy vọng rằng nguồn t&agrave;i trợ của Shinhan Life Việt Nam sẽ g&oacute;p phần động vi&ecirc;n tinh thần, tiếp th&ecirc;m sức mạnh cho c&aacute;c em v&agrave; gia đ&igrave;nh tr&ecirc;n h&agrave;nh tr&igrave;nh đấu tranh để chiến thắng bệnh tật&rdquo;.</span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:null\"><span style=\"font-size:16px\"><img alt=\"\" src=\"/uploads/20231012091901New12.png\" style=\"height:467px; width:700px\" /></span></span></p>\r\n\r\n<p style=\"text-align:justify\"><span style=\"color:null\"><span style=\"font-size:16px\">&Ocirc;ng Bae Seung Jun &ndash; Tổng gi&aacute;m đốc Shinhan Life Việt Nam chia sẻ: &ldquo;Một trong những ưu ti&ecirc;n của Shinhan Life Việt Nam l&agrave; n&acirc;ng cao tr&aacute;ch nhiệm x&atilde; hội v&agrave; lan tỏa sự sẻ chia th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng. Đồng h&agrave;nh c&ugrave;ng bệnh viện nhi đồngTh&agrave;nh phố, ch&uacute;ng t&ocirc;i hy vọng rằng nguồn t&agrave;i trợ của Shinhan Life Việt Nam sẽ g&oacute;p phần động vi&ecirc;n tinh thần, tiếp th&ecirc;m sức mạnh cho c&aacute;c em v&agrave; gia đ&igrave;nh tr&ecirc;n h&agrave;nh tr&igrave;nh đấu tranh để chiến thắng bệnh tật&rdquo;.</span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:null\"><span style=\"font-size:16px\"><img alt=\"\" src=\"/uploads/20231012094143New13.png\" style=\"height:467px; width:700px\" /></span></span></p>\r\n\r\n<p><span style=\"font-size:16px\">Shinhan Life Việt Nam hy vọng rằng, th&ocirc;ng qua c&aacute;c hoạt động v&igrave; cộng đồng, sự sẻ chia v&agrave; t&igrave;nh y&ecirc;u thương sẽ được lan tỏa để trẻ em tr&ecirc;n khắp cả nước n&oacute;i chung v&agrave; c&aacute;c bệnh nhi kh&ocirc;ng may mắc bệnh hiểm ngh&egrave;o n&oacute;i ri&ecirc;ng, sẽ được vui sống trong v&ograve;ng tay y&ecirc;u thương, sẻ chia của cả cộng đồng.</span></p>\r\n\r\n<h5><strong><span style=\"font-size:18px\">Về Shinhan Life Việt Nam</span></strong></h5>\r\n\r\n<p><span style=\"font-size:16px\">C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</span></p>\r\n\r\n<p><span style=\"font-size:16px\">Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\"><span style=\"color:#0000ff\">https://shinhanlifevn.com.vn</span></a></span></p>\r\n\r\n<h5><span style=\"font-size:18px\"><strong>Th&ocirc;ng tin li&ecirc;n lạc:</strong></span></h5>\r\n\r\n<p><span style=\"font-size:16px\">Trần Thị Tuyết Minh &ndash; Trưởng ph&ograve;ng Marketing<br />\r\nĐiện thoại:&nbsp;<a href=\"https://shinhanlifevn.com.vn/028%20730%2009920\"><span style=\"color:#0000ff\">028 730 09920</span></a><br />\r\nEmail:&nbsp;<span style=\"color:#0000ff\">minhtran@shinhan.com</span>&nbsp;hoặc&nbsp;<span style=\"color:#0000ff\">minhtran@shinhanlife.biz.vn</span></span></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           },
           new NewEventDetailDto
           {
               Id = 2,
               Title = "SHINHAN LIFE VIỆT NAM BỔ NHIỆM TÂN CHỦ TỊCH HỘI ĐỒNG THÀNH VIÊN KIÊM TỔNG GIÁM ĐỐC",
               Content = "<p style=\"text-align:center\"><span style=\"color:#9900ff\"><span style=\"font-size:36px\"><strong>SHINHAN LIFE VIỆT NAM BỔ NHIỆM T&Acirc;N CHỦ TỊCH HỘI ĐỒNG TH&Agrave;NH VI&Ecirc;N KI&Ecirc;M TỔNG GI&Aacute;M ĐỐC</strong></span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:#7f8c8d\"><span style=\"font-size:16px\"><em>09-08-2023</em></span></span></p>\r\n\r\n<hr />\r\n<p><span style=\"font-size:14px\">Được sự chấp thuận của Bộ T&agrave;i ch&iacute;nh theo C&ocirc;ng văn số 8362/BTC-QLBH, ng&agrave;y 08/08/2023, C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam ch&iacute;nh thức bổ nhiệm &ocirc;ng Bae Seung Jun l&agrave;m t&acirc;n Chủ tịch Hội đồng Th&agrave;nh vi&ecirc;n ki&ecirc;m Tổng Gi&aacute;m đốc C&ocirc;ng ty kể từ ng&agrave;y 08/08/2023, thay cho &ocirc;ng Lee EuiChul.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Bắt đầu l&agrave;m việc tại c&ocirc;ng ty mẹ Shinhan Life Insurance Corporation, H&agrave;n Quốc từ 2008, &ocirc;ng Bae Seung Jun đ&atilde; c&oacute; gần 15 năm kinh nghiệm trong việc x&acirc;y dựng chiến lược marketing tại thị trường bảo hiểm H&agrave;n Quốc; kinh doanh nước ngo&agrave;i, nghi&ecirc;n cứu v&agrave; ph&aacute;t triển thị trường bảo hiểm quốc tế. &Ocirc;ng Bae Seung Jun cũng l&agrave; một trong những th&agrave;nh vi&ecirc;n trực tiếp tham gia qu&aacute; tr&igrave;nh x&acirc;y dựng v&agrave; đặt nền m&oacute;ng cho Shinhan Life Việt Nam từ những bước đầu ti&ecirc;n.</span></p>\r\n\r\n<p><span style=\"font-size:14px\"><img alt=\"\" src=\"/uploads/20231012112719New21.png\" style=\"height:801px; width:1200px\" /></span></p>\r\n\r\n<p style=\"text-align:center\">&nbsp;&Ocirc;ng Bae Seung Jun &ndash; Chủ tịch Hội đồng Th&agrave;nh vi&ecirc;n ki&ecirc;m Tổng Gi&aacute;m đốc Shinhan Life Việt Nam</p>\r\n\r\n<p><span style=\"font-size:14px\">Trong ph&aacute;t biểu nhậm chức của m&igrave;nh, &ocirc;ng Bae Seung Jun chia sẻ với tập thể nh&acirc;n vi&ecirc;n: &ldquo;Trong vai tr&ograve; mới l&agrave; Chủ tịch Hội đồng Th&agrave;nh vi&ecirc;n ki&ecirc;m Tổng Gi&aacute;m đốc c&ocirc;ng ty, t&ocirc;i muốn nhấn mạnh ba điều. Thứ nhất, l&agrave; một doanh nghiệp bảo hiểm nh&acirc;n thọ mới tại thị trường Việt Nam, Shinhan Life cần li&ecirc;n tục thay đổi v&agrave; đổi mới, để th&iacute;ch nghi với thị trường v&agrave; ph&aacute;t huy được những thế mạnh sẵn c&oacute;. Thứ hai, ch&uacute;ng ta cần kh&aacute;m ph&aacute; v&agrave; ph&aacute;t triển m&ocirc; h&igrave;nh kinh doanh mới để tăng lợi thế cạnh tranh trong thị trường. Thứ ba, Shinhan Life Việt Nam sẽ l&agrave; doanh nghiệp ph&aacute;t triển đồng h&agrave;nh c&ugrave;ng với sự ph&aacute;t triển của từng nh&acirc;n vi&ecirc;n c&ocirc;ng ty. Ch&uacute;ng ta sẽ tạo ra một doanh nghiệp m&agrave; tất cả mọi người đều c&oacute; thể tự h&agrave;o.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Với bề d&agrave;y kinh nghiệm, tinh thần nhiệt huyết đầy năng động c&ugrave;ng kiến thức rộng về ph&aacute;t triển thị trường bảo hiểm quốc tế, &ocirc;ng Bae Seung Jun được kỳ vọng sẽ g&oacute;p phần th&uacute;c đẩy Shinhan Life Việt Nam tiến l&ecirc;n bước chuyển m&igrave;nh mới, đạt được sự tăng trưởng đ&aacute;ng mong đợi trong hoạt động kinh doanh.</span></p>\r\n\r\n<p><strong><span style=\"font-size:16px\">Về Shinhan Life Việt Nam</span></strong></p>\r\n\r\n<p><span style=\"font-size:14px\">C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\"><span style=\"color:#0000ff\">https://shinhanlifevn.com.vn</span></a></span></p>\r\n\r\n<p><strong><span style=\"font-size:16px\">Th&ocirc;ng tin li&ecirc;n lạc:</span></strong></p>\r\n\r\n<p><span style=\"font-size:14px\">Trần Thị Tuyết Minh &ndash; Trưởng ph&ograve;ng Marketing<br />\r\nĐiện thoại:&nbsp;<a href=\"https://shinhanlifevn.com.vn/028%20730%2009920\"><span style=\"color:#0000ff\">028 730 09920</span></a><br />\r\nEmail:&nbsp;<span style=\"color:#0000ff\">minhtran@shinhan.com</span>&nbsp;hoặc&nbsp;<span style=\"color:#0000ff\">minhtran@shinhanlife.biz.vn</span></span></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           },
           new NewEventDetailDto
           {
               Id = 3,
               Title = "SHINHAN LIFE VIỆT NAM HỢP TÁC TỔ CHỨC CHƯƠNG TRÌNH GIÁO DỤC ILEAD DÀNH CHO THANH THIẾU NIÊN LÀNG TRẺ EM SOS VIỆT NAM",
               Content = "<p style=\"text-align:center\"><span style=\"font-size:36px\"><span style=\"color:#9900ff\"><strong>SHINHAN LIFE VIỆT NAM HỢP T&Aacute;C TỔ CHỨC CHƯƠNG TR&Igrave;NH GI&Aacute;O DỤC ILEAD D&Agrave;NH CHO THANH THIẾU NI&Ecirc;N L&Agrave;NG TRẺ EM SOS VIỆT NAM</strong></span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:#7f8c8d\"><span style=\"font-size:18px\"><em>17-06-2023</em></span></span></p>\r\n\r\n<hr />\r\n<p><span style=\"font-size:14px\">Th&aacute;ng 6/2023, C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam (Shinhan Life Việt Nam) hợp t&aacute;c c&ugrave;ng C&ocirc;ng ty TNHH BNJ Việt Nam (BNJ) thực hiện chương tr&igrave;nh gi&aacute;o dục iLead d&agrave;nh cho thanh thiếu ni&ecirc;n tại L&agrave;ng trẻ em SOS Việt Nam.</span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"font-size:14px\"><img alt=\"\" src=\"/uploads/20231012114141New31.jpg\" style=\"height:665px; width:900px\" /></span></p>\r\n\r\n<p><span style=\"font-size:14px\">Đ&acirc;y l&agrave; chương tr&igrave;nh đ&agrave;o tạo thanh thiếu ni&ecirc;n L&agrave;ng trẻ em SOS Việt Nam c&oacute; độ tuổi từ 15 đến 25 về những gi&aacute; trị l&atilde;nh đạo trong chương tr&igrave;nh &ldquo;iLead Leadership Values&rdquo; của Tiến sĩ John C. Maxwell, trong khu&ocirc;n khổ S&aacute;ng kiến chương tr&igrave;nh YouthCan! của L&agrave;ng trẻ em SOS quốc tế &ndash; Hợp t&aacute;c v&igrave; việc l&agrave;m của thanh ni&ecirc;n.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Chương tr&igrave;nh iLead cung cấp cho học sinh diễn đ&agrave;n để tiếp thu kiến ​​thức, kỹ năng v&agrave; c&aacute;c gi&aacute; trị l&atilde;nh đạo, tạo điều kiện thuận lợi gi&uacute;p c&aacute;c em thực h&agrave;nh c&aacute;c kỹ năng l&atilde;nh đạo, đồng thời khuyến kh&iacute;ch sự kết nối v&agrave; h&ograve;a nhập trong nh&oacute;m đồng đẳng; từ đ&oacute; ph&aacute;t triển mối quan hệ tốt hơn với c&aacute;c bạn c&ugrave;ng trang lứa, t&igrave;m ra tiếng n&oacute;i của m&igrave;nh v&agrave; h&agrave;nh động để hướng bản th&acirc;n đến những gi&aacute; trị tốt đẹp.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Gi&aacute;o tr&igrave;nh iLead bao gồm 03 học phần: iChoose, iDo v&agrave; iLead, mỗi học phần lấy cảm hứng từ c&aacute;c triết l&yacute; l&atilde;nh đạo của t&aacute;c giả, diễn giả, huấn luyện vi&ecirc;n v&agrave; nh&agrave; l&atilde;nh đạo &ndash; Tiến sĩ John C. Maxwell, gồm c&aacute;c b&agrave;i học dựa tr&ecirc;n gi&aacute; trị v&agrave; lấy con người l&agrave;m trung t&acirc;m được thiết kế với sự hợp t&aacute;c của c&aacute;c nh&agrave; l&atilde;nh đạo gi&aacute;o dục để khuyến kh&iacute;ch thế hệ tương lai ph&aacute;t triển v&agrave; thực h&agrave;nh c&aacute;c gi&aacute; trị v&agrave; kỹ năng l&atilde;nh đạo.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Thanh thiếu ni&ecirc;n tham gia chương tr&igrave;nh sẽ được học tập v&agrave; kh&aacute;m ph&aacute; c&aacute;c gi&aacute; trị phẩm chất từ chương tr&igrave;nh iLead, lựa chọn c&aacute;c gi&aacute; trị c&aacute; nh&acirc;n &aacute;p dụng cho việc ph&aacute;t triển bản th&acirc;n, tiếp cận h&agrave;nh tr&igrave;nh ph&aacute;t triển l&atilde;nh đạo từ việc l&atilde;nh đạo bản th&acirc;n, từ đ&oacute; tăng khả năng h&ograve;a nhập thuận lợi v&agrave;o đời sống v&agrave; thị trường lao động của x&atilde; hội. Ngo&agrave;i ra, Shinhan Life Việt Nam cũng tạo điều kiện về cơ hội tập huấn kỹ năng, trao cơ hội thực tập v&agrave; cơ hội việc l&agrave;m tại trong tương lai cho c&aacute;c em c&oacute; nguyện vọng v&agrave; năng lực ph&ugrave; hợp.</span></p>\r\n\r\n<p><span style=\"font-size:14px\"><img alt=\"\" src=\"/uploads/20231012114356New32.jpg\" style=\"height:599px; margin:10px; width:900px\" /></span></p>\r\n\r\n<p><span style=\"font-size:14px\">&ldquo;Với slogan &ldquo;Gửi Trao Diệu Kỳ&rdquo;, c&aacute;c hoạt động n&acirc;ng cao tr&aacute;ch nhiệm x&atilde; hội lu&ocirc;n l&agrave; một trong những ưu ti&ecirc;n của Shinhan Life khi hoạt động tại Việt Nam. Ch&uacute;ng t&ocirc;i mong muốn g&oacute;p phần v&agrave;o sự ph&aacute;t triển bền vững của thế hệ tương lai, kh&ocirc;ng chỉ dừng lại ở c&aacute;c hỗ trợ về nhu cầu thiết yếu cơ bản, m&agrave; c&ograve;n tạo điều kiện để c&aacute;c em c&oacute; thể ph&aacute;t triển to&agrave;n diện, l&agrave;m chủ được cuộc sống của bản th&acirc;n, trở th&agrave;nh c&ocirc;ng d&acirc;n c&oacute; &iacute;ch cho x&atilde; hội.&rdquo; &Ocirc;ng Bae Seung Jun, ph&oacute; Tổng Gi&aacute;m đốc Shinhan Life chia sẻ.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">L&agrave; dự &aacute;n cộng đồng d&agrave;i hạn từ 2023 &ndash; 2025, chương tr&igrave;nh iLead sẽ được tổ chức thực hiện tại L&agrave;ng trẻ em SOS Việt Nam tại H&agrave; Nội, Đ&agrave; Nẵng v&agrave; Tp. Hồ Ch&iacute; Minh trong năm đầu ti&ecirc;n 2023.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">L&agrave;ng trẻ em SOS Việt Nam &ndash; một th&agrave;nh vi&ecirc;n của Li&ecirc;n minh L&agrave;ng trẻ em SOS quốc tế &ndash; l&agrave; tổ chức phi lợi nhuận hoạt động nhằm nhằm bảo vệ, chăm s&oacute;c trẻ mất đi sự chăm s&oacute;c của cha mẹ hoặc c&oacute; nguy cơ mất đi sự chăm s&oacute;c của cha mẹ. Từ khi th&agrave;nh lập năm 1987 đến nay, L&agrave;ng trẻ em SOS Việt Nam đ&atilde; v&agrave; đang chăm s&oacute;c, nu&ocirc;i dưỡng theo m&ocirc; h&igrave;nh gia đ&igrave;nh thay thế cho hơn 6.000 trẻ em v&agrave; thanh ni&ecirc;n c&oacute; ho&agrave;n cảnh đặc biệt tại 17 L&agrave;ng trẻ em SOS cơ sở tại 17 tỉnh, th&agrave;nh tr&ecirc;n to&agrave;n quốc bao gồm: H&agrave; Nội, Hồ Ch&iacute; Minh, Hải Ph&ograve;ng, Đ&agrave; Nẵng, Điện Bi&ecirc;n, Ph&uacute; Thọ, Th&aacute;i B&igrave;nh, Thanh H&oacute;a, Nghệ An, Quảng B&igrave;nh, Thừa Thi&ecirc;n Huế, B&igrave;nh Định, Gia Lai, Kh&aacute;nh H&ograve;a, L&acirc;m Đồng, Bến Tre v&agrave; C&agrave; Mau. B&ecirc;n cạnh chương tr&igrave;nh chăm s&oacute;c thay thế tại c&aacute;c L&agrave;ng trẻ em SOS cơ sở, SOS Việt Nam thực hiện c&aacute;c chương tr&igrave;nh Tăng cường gia đ&igrave;nh v&agrave; Chăm s&oacute;c dựa v&agrave;o người th&acirc;n hỗ trợ hơn 3000 gia đ&igrave;nh c&oacute; ho&agrave;n cảnh kh&oacute; khăn tại cộng đồng tr&ecirc;n 6 tỉnh (Th&aacute;i B&igrave;nh, Nghệ An, Quảng Nam-Đ&agrave; Nẵng, Đ&agrave; Lạt, Bến Tre v&agrave; C&agrave; Mau) nhằm ngăn ngừa t&igrave;nh trạng gia đ&igrave;nh ly t&aacute;n v&agrave; trẻ em bị bỏ rơi.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">BNJ Việt Nam v&agrave; B&agrave; Helen Nguyễn, người s&aacute;ng lập v&agrave; cũng l&agrave; th&agrave;nh vi&ecirc;n ch&iacute;nh thức của tổ chức Maxwell Leadership, được ph&eacute;p sử dụng c&aacute;c chương tr&igrave;nh đ&agrave;o tạo l&atilde;nh đạo của tổ chức Maxwell Leadership thực hiện giảng dạy v&agrave; cấp chứng nhận ho&agrave;n th&agrave;nh cho người học, bao gồm c&aacute;c chương tr&igrave;nh sau: Maxwell Leadership Mentorship Program, Maxwell Leadership Certification Program, Maxwell Leadership Youth Program, Maxwell Leadership DISC Program.</span></p>\r\n\r\n<p><span style=\"font-size:18px\"><strong>Về Shinhan Life Việt Nam</strong></span></p>\r\n\r\n<p><span style=\"font-size:14px\">C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\"><span style=\"color:#0000ff\">https://shinhanlifevn.com.vn</span></a></span></p>\r\n\r\n<h5><span style=\"color:null\"><strong><span style=\"font-size:18px\">Th&ocirc;ng tin li&ecirc;n lạc:</span></strong></span></h5>\r\n\r\n<p><span style=\"font-size:14px\">Trần Thị Tuyết Minh &ndash; Trưởng ph&ograve;ng Marketing<br />\r\nĐiện thoại:&nbsp;<a href=\"https://shinhanlifevn.com.vn/028%20730%2009920\"><span style=\"color:#0000ff\">028 730 09920</span></a><br />\r\nEmail:&nbsp;<span style=\"color:#0000ff\">minhtran@shinhan.com</span>&nbsp;hoặc&nbsp;<span style=\"color:#0000ff\">minhtran@shinhanlife.biz.vn</span></span></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           },
           new NewEventDetailDto
           {
               Id = 4,
               Title = "SHINHAN LIFE VIỆT NAM TẶNG 1.300 SUẤT ĂN TRƯA CHO BỆNH NHI BỆNH VIỆN NHI ĐỒNG 2",
               Content = "<p style=\"text-align:center\"><span style=\"font-size:36px\"><span style=\"color:#9900ff\"><strong>SHINHAN LIFE VIỆT NAM TẶNG 1.300 SUẤT ĂN TRƯA CHO BỆNH NHI BỆNH VIỆN NHI ĐỒNG 2</strong></span></span></p>\r\n\r\n<p style=\"text-align:center\"><span style=\"color:#999999\"><span style=\"font-size:16px\"><em>30-05-2023</em></span></span></p>\r\n\r\n<hr />\r\n<p><span style=\"color:null\"><span style=\"font-size:14px\">Th&agrave;nh phố Hồ Ch&iacute; Minh, ng&agrave;y 30/5/2023, Nh&acirc;n dịp Quốc tế Thiếu nhi 1/6, đại diện Ban Gi&aacute;m đốc v&agrave; nh&acirc;n vi&ecirc;n Shinhan Life Việt Nam đ&atilde; đến thăm v&agrave; tặng qu&agrave; cho c&aacute;c bệnh nhi tại Bệnh viện nhi đồng 2 TP.HCM. Cụ thể, Shinhan Life Việt Nam tổ chức hoạt động trao tặng 1.300 suất ăn trưa cho c&aacute;c bệnh nhi v&agrave; người nh&agrave; bệnh nh&acirc;n. Ngo&agrave;i ra, đại diện c&ocirc;ng ty cũng gh&eacute; thăm v&agrave; gửi tặng 200 suất qu&agrave; cho c&aacute;c em nhỏ đang điều trị tại khoa Ung Bướu của bệnh viện. Đ&acirc;y l&agrave; một trong những hoạt động tiếp nối nỗ lực chia sẻ v&igrave; cộng đồng thường ni&ecirc;n của c&ocirc;ng ty tại Việt Nam.</span></span></p>\r\n\r\n<p><span style=\"color:null\"><span style=\"font-size:14px\"><img alt=\"\" src=\"/uploads/20231012132318New4.1.jpg\" style=\"height:667px; width:1000px\" /></span></span></p>\r\n\r\n<p><span style=\"font-size:14px\">&Ocirc;ng Bae Seung Jun &ndash; Ph&oacute; Tổng Gi&aacute;m đốc của Shinhan Life Việt Nam chia sẻ: &ldquo;Ch&uacute;ng t&ocirc;i lu&ocirc;n nỗ lực n&acirc;ng cao chất lượng cuộc sống, quan t&acirc;m đến sức khỏe v&agrave; hạnh ph&uacute;c của gia đ&igrave;nh Việt. Với sứ mệnh &ldquo;Mang lại một thế giới tốt đẹp hơn bằng sức mạnh t&agrave;i ch&iacute;nh&rdquo;, ch&uacute;ng t&ocirc;i mong rằng những phần qu&agrave; nhỏ trong dịp Quốc tế Thiếu nhi n&agrave;y sẽ g&oacute;p phần mang lại ch&uacute;t niềm vui nhỏ để c&aacute;c em v&agrave; bố mẹ lạc quan vượt qua giai đoạn kh&oacute; khăn, chiến thắng bệnh tật&rdquo;.</span></p>\r\n\r\n<p><span style=\"font-size:14px\"><img alt=\"\" src=\"/uploads/20231012132417New4.2.jpg\" style=\"height:667px; width:1000px\" /></span></p>\r\n\r\n<p><span style=\"font-size:14px\">Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 01/2022, Shinhan Life Việt Nam hiện đang tập trung x&acirc;y dựng danh mục sản phẩm v&agrave; mạng lưới ph&acirc;n phối đa dạng để mang bảo hiểm nh&acirc;n thọ đến gần hơn với tất cả mọi người. Với slogan &ldquo;Gửi trao diệu kỳ&rdquo;, Shinhan Life mong muốn mang những gi&aacute; trị mới, gửi trao hạnh ph&uacute;c, sự bảo vệ như những điều diệu kỳ đến với cuộc sống của mọi người d&acirc;n Việt Nam.</span></p>\r\n\r\n<h5><strong><span style=\"font-size:18px\">Về Shinhan Life Việt Nam</span></strong></h5>\r\n\r\n<p><span style=\"font-size:14px\">C&ocirc;ng ty TNHH Bảo hiểm Shinhan Life Việt Nam c&oacute; số vốn điều lệ ban đầu l&agrave; 2.320 tỉ đồng, l&agrave; c&ocirc;ng ty bảo hiểm nh&acirc;n thọ thuộc Shinhan Life Insurance Corporation, H&agrave;n Quốc. Ch&iacute;nh thức hoạt động kinh doanh bảo hiểm tại thị trường Việt Nam từ th&aacute;ng 1/2022, Shinhan Life cung cấp c&aacute;c dịch vụ về bảo hiểm nh&acirc;n thọ, bảo hiểm sức khỏe v&agrave; đầu tư t&agrave;i ch&iacute;nh.</span></p>\r\n\r\n<p><span style=\"font-size:14px\">Để biết th&ecirc;m th&ocirc;ng tin vui l&ograve;ng truy cập:&nbsp;<a href=\"https://shinhanlifevn.com.vn/\" rel=\"noreferrer noopener\" target=\"_blank\"><span style=\"color:#0000ff\">https://shinhanlifevn.com.vn</span></a></span></p>\r\n\r\n<h5><span style=\"font-size:18px\"><strong>Th&ocirc;ng tin li&ecirc;n lạc:</strong></span></h5>\r\n\r\n<p><span style=\"font-size:14px\">Trần Thị Tuyết Minh &ndash; Trưởng ph&ograve;ng Marketing<br />\r\nĐiện thoại:&nbsp;<a href=\"https://shinhanlifevn.com.vn/028%20730%2009920\"><span style=\"color:#0000ff\">028 730 09920</span></a><br />\r\nEmail:&nbsp;<span style=\"color:#0000ff\">minhtran@shinhan.com</span>&nbsp;hoặc&nbsp;<span style=\"color:#0000ff\">minhtran@shinhanlife.biz.vn</span></span></p>\r\n",
               CreationDate = DateTime.Now,
               LastUpdatedDate = DateTime.Now,
           }
        };
    }
}
