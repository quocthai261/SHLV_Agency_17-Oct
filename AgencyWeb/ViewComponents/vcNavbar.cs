using AgencyWeb.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;
using System;
using AgencyWeb.Services;
using AgencyWeb.Common.Enums;

namespace AgencyWeb.ViewComponents
{
    public class vcNavbar : ViewComponent
    {
        private readonly IApiService _apiService;
        public vcNavbar(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SiteMap = await GetSiteMap();

            return View();
        }

        private async Task<IEnumerable<TreeMenuItem<SiteMapNode>>> GetSiteMap()
        {
            IEnumerable<TreeMenuItem<SiteMapNode>> siteMap = null;

            List<SiteMapNode> menus = new List<SiteMapNode>();

            var menuResponse = await _apiService.GetMenuListApi(MenuSourceType.Agency);

            foreach (var item in menuResponse)
            {
                string[] splittedUrl = item.Url.Split("/");
                menus.Add(new SiteMapNode
                {
                    ACTIVE = false,
                    CONTENT = item.Content,
                    ICONCLASS = item.IconClass,
                    ID = item.MenuId,
                    ISACTIVE = item.IsActive,
                    ISDISPLAY = item.IsDisplay,
                    ORDER = null,
                    ORDER_ = item.Order,
                    PARENTID = item.ParentId,
                    SYSTEMNAME = item.SystemName,
                    URL = null,
                    URL_ = (splittedUrl.Length >= 2 ? Url.Action((splittedUrl.Length > 2 ? splittedUrl[2] : "Index"), splittedUrl[1], new { area = splittedUrl[0] }).Substring(1) : "#"),
                });
            }

            if (menus != null && menus.Count > 0)
            {
                siteMap = menus.GenerateTreeMenu(c => c.ID, c => c.PARENTID, c => c.ORDER_);
            }

            return siteMap;
        }
    }
}
