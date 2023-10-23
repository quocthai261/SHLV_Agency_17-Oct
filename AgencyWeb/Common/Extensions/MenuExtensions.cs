using AgencyWeb.Models.Menu;

namespace AgencyWeb.Common.Extensions
{
    public static class MenuExtensions
    {
        public static bool ContainsSystemName(this TreeMenuItem<SiteMapNode> node, string systemName)
        {
            if (!string.IsNullOrEmpty(systemName))
            {
                if (node.Item.SYSTEMNAME != null)
                {
                    return node.Item.SYSTEMNAME.ToUpper().Equals(systemName.ToUpper());
                }
            }

            return false;
        }

        public static bool ContainsParentSystemName(this TreeMenuItem<SiteMapNode> node, string parentSystemName)
        {
            if (!string.IsNullOrEmpty(parentSystemName))
            {
                if (node.Item.SYSTEMNAME != null)
                {
                    return node.Item.SYSTEMNAME.ToUpper().Equals(parentSystemName.ToUpper());
                }
            }

            return false;
        }


    }
}
