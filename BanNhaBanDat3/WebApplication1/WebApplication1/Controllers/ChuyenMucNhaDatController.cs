using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ChuyenMucNhaDatController : Controller
    {
        // GET: ChuyenMucNhaDat
        public ActionResult Index()
        {
            Model1 context = new Model1();
            List<Category> list = context.Categories.ToList();
            return View(list);
        }
        public ActionResult Detail(string alias)
        {
            Model1 context = new Model1();
            List<News> list = context.News.Where(p => p.Category.Alias == alias).ToList();
            return View(list);
        }
        public ActionResult ChiTietNews(int id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            Model1 context = new Model1();
            News item = context.News.FirstOrDefault(p => p.id == id);
            return View(item);
        }
    }
}