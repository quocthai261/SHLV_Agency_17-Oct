using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;

namespace AgencyWeb.Common.Extensions
{
    public static class AddControllersWithViewsExtensions
    {
        public static IMvcBuilder AddControllersWithViewsEx(this IServiceCollection services)
        {
            //if (services == null)
            //{
            //    throw new ArgumentNullException(nameof(services));
            //}

            var builder = services
                .AddControllersWithViews(opts =>
                    opts.Conventions.Add(new RouteTokenTransformerConvention(new ToKebabParameterTransformer())));
            //var builder = services
            //    .AddControllersWithViews();
            return builder;
        }

        private class ToKebabParameterTransformer : IOutboundParameterTransformer
        {
			public string? TransformOutbound(object? value)
			{
				if (value == null)
				{
					return null;
				}

				string text = value!.ToString();
				if (!string.IsNullOrEmpty(text))
				{
					return Regex.Replace(text, "([a-z])([A-Z])", "$1-$2").ToLower();
				}

				return null;
			}
		}
    }
}
