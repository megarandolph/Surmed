using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;


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
        [HttpPost]
        public JsonResult correo(string email, string subject, string message) {

            try
            {
                // Credentials
                var credentials = new NetworkCredential("randolphmarte@hotmail.com", "Dokirayo@");
                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress(email, "Prueba"),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress("randolphmarte@hotmail.com"));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 25,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.live.com",
                    EnableSsl = false,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                // TODO: handle exception
                throw new InvalidOperationException(ex.Message);
            }
            
            var data = "Correo enviado";

            return Json(data,JsonRequestBehavior.AllowGet);
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