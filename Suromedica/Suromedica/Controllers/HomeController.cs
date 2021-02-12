using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Suromedica.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult Home()
        {
            
            Session["productos"] = null;
            Session["detalles"] = null;
            Session["home"] = true;

            return View();
        }
        
        public ActionResult productosA()
        {
            Session["productos"] = true;
            Session["detalles"] = null;
           Session["home"] = null;

            return View();
        }
        public ActionResult productosB()
        {
            Session["productos"] = true;
            Session["detalles"] = null;
           Session["home"] = null;
            return View();
        }
        public ActionResult productosC()
        {
            Session["productos"] = true;
            Session["detalles"] = null;
           Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA1()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA2()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA3()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA4()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA5()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleA6()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = true;
            Session["detallesB"] = null;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleB1()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = true;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleB2()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = true;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleB3()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = true;
            Session["detallesC"] = null;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC1()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC2()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC3()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC4()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC5()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        public ActionResult DetalleC6()
        {
            Session["productos"] = null;
            Session["detalles"] = true;
            Session["detallesA"] = null;
            Session["detallesB"] = null;
            Session["detallesC"] = true;
            Session["home"] = null;
            return View();
        }
        
    }
}