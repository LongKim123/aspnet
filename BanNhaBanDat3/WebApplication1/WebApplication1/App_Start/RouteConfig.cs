using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "chi-tiet-tin",
                "chuyen-muc-nha-dat/{alias}-{id}",
                new { controller = "ChuyenMucNhaDat", action = "ChiTietNews"}, new { id = @"\d+" }               
            );
            routes.MapRoute(
               name: "chuyen muc nha dat",
               url: "nha-dat",
               defaults: new { controller = "ChuyenMucNhaDat", action = "Index", id = UrlParameter.Optional  }
           );
            routes.MapRoute(
               name: "details",
               url: "chuyen-muc-nha-dat/{alias}",
               defaults: new { controller = "ChuyenMucNhaDat", action = "Detail", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
