using DiskYedekleme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiskYedekleme.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string USERNAME, string PASSWORD) 
        {
            using (var Context=new DBcontext()) 
            {
                var Query = Context.Users.FirstOrDefault(x=>x.USERNAME==USERNAME&&x.PASSWORD==PASSWORD);
                if (Query != null)
                {
                    Session["Name"] = USERNAME;
                    return View("DiskManager");
                }
                else
                {
                    ViewBag.Error = "Kullanıcı adı veya şifre hatalı";
                    return View();
                }
                }
               
        }

        [HttpGet]
        public ActionResult DiskManager()
        {

            if (Session["Name"] != null) 
            {
                return View();
            }
            else { return View("Index"); }
           
        
        }


    }
}