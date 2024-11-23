using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Adoption_system.Models;
using Microsoft.Win32;
using System.Configuration;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web.Services.Description;

namespace Adoption_system.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Program()
        {
            return View();
        }
    
        public ActionResult SignIn()
        {

            return View();
        }
        public ActionResult Document()
        {

            return View();
        }
        public ActionResult Email()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignIn(SignIn login)
        {
            SignIn stud = new SignIn();
            AdoptionDBEntities4 fe = new AdoptionDBEntities4();
            stud = fe.SignIns.Where(X => X.Email == login.Email && X.Password == login.Password).FirstOrDefault();
            if(stud != null) 
            {
                Session["Username"] = stud.Username;
                return RedirectToAction("Verify");
            }
            else
            {
              ViewBag.Message = "Invalid Credential";
              ViewBag.color = "Red";
            }
            return View(login);
        }
        public ActionResult Register()
        {
           SignIn entities = new SignIn();
            return View(entities);
        }
        [HttpPost]
        public ActionResult Register(SignIn register)
        { 
            if(ModelState.IsValid)
            {
             AdoptionDBEntities4 Rp = new AdoptionDBEntities4();
                Rp.SignIns.Add(register);
                Rp.SaveChanges();
                ViewBag.Message = "Registration successful";
                return RedirectToAction("SignIn");
            }
            return View(register);

        }
       
        
        public ActionResult Child()
        {
          
            return View();
        }
       
        public ActionResult Verify()
        {

            return View();
        }


        public ActionResult Employee()
        {
            Employee entities = new Employee();
            return View(entities);
        }
        [HttpPost]
        public ActionResult Employee(Employee employee)
        {
            Employee stud = new Employee();
            AdoptionDBEntities4 Ep = new AdoptionDBEntities4();
            stud = Ep.Employees.Where(X => X.Username == employee.Username && X.Password == employee.Password).FirstOrDefault();
            if (stud != null)
            {
                Session["Username"] = stud.Username;
                return RedirectToAction("Email");
            }
            else
            {
                ViewBag.Message = "Invalid Credential";
                ViewBag.color = "Red";
            }

            return View(employee);

        }
        public ActionResult AdoptionForm()
        {
            Clientform entities = new Clientform();
            return View(entities);
        }
        [HttpPost]
        public ActionResult AdoptionForm(Clientform Adoption)
        {
            if (ModelState.IsValid)
            {
                AdoptionDBEntities4 Cb = new AdoptionDBEntities4();
                Adoption.CreatedDate = DateTime.Now;
                Cb.Clientforms.Add(Adoption);
                Cb.SaveChanges();
                ViewBag.Message = "successful Compliting An Adoption Form";
                return RedirectToAction("Document");
            }
            return View(Adoption);
        }
        public ActionResult ParentForm()
        {
            ChildParent entities = new ChildParent();
            return View(entities);
        }
        [HttpPost]
        public ActionResult ParentForm(ChildParent parent)
        {
            if (ModelState.IsValid)
            {
                AdoptionDBEntities4 pb = new AdoptionDBEntities4();
                pb.ChildParents.Add(parent);
                pb.SaveChanges();
                ViewBag.Message = "successful Compliting An parent Form";
                return RedirectToAction("Document");

            }
            return View(parent);

        }
        [HttpPost]
        public ActionResult Email(Email model)
        {
            //SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");

            //using (MailMessage mm = new MailMessage(smtpSection.From, model.To))
            //{
            // mm.Subject = model.Subject;
            // mm.Body = model.Body;
            // mm.IsBodyHtml = false;
            //    using(SmtpClient smtp=new SmtpClient())
            //    {
            //        smtp.Host = smtpSection.Network.Host;
            //        smtp.EnableSsl = smtpSection.Network.EnableSsl;
            //        NetworkCredential networkCred= new NetworkCredential (smtpSection.Network.UserName, smtpSection.Network.Password);
            //        smtp.UseDefaultCredentials = smtpSection.Network.DefaultCredentials;
            //        smtp.Port = smtpSection.Network.Port;
            //        smtp.Send(mm);
            //    }
            //}
            MailMessage mm = new MailMessage("shichabonkuna22@gmail.com", model.ToEmail);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "https://formsubmit.co/c5bfc30a0030d178bf5447ef0eb5476e";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("shichabonkuna22@gmail.com", "gmailpassword");

            

            smtp.Credentials = nc;

            try
            {
                smtp.Send(mm);
                ViewBag.Message = "The mail has been sent successfully.";
            }
            catch (SmtpException ex)
            {
                ViewBag.Message = "Error sending mail: " + ex.Message;
            }

            model.CreatedAt = DateTime.Now;


            return View(model);
        }

        public ActionResult Peter()
        {
           
            return View();
        }

        public ActionResult teresa()
        {
            return View();
        }
        public ActionResult Nicole()
        {
            return View();
        }
        public ActionResult Samantha()
        {

          return View();
        }
        public ActionResult Pual()
        {
            return View();
        }
        public ActionResult Sam()
        {
            return View();
        }
        public ActionResult Olive()
        {
            return View();
        }
        public ActionResult Scott()
        {
            return View();
        }
        public ActionResult Martin()
        {
            return View();
        }
        public ActionResult Anabelle()
        {
            return View();
        }

        //private readonly AdoptionDBEntities4 _context;

        //public HomeController (AdoptionDBEntities4 context)
        //{
        //    this._context = context;
        //}
        [HttpGet]
        public ActionResult AdoptionD()
        {
            //var Client = _context.Clientforms.ToList();
            //if(Client != null)
            //{
            //    List<AdoptionDBEntities4> clientList = new List<AdoptionDBEntities4>();
            //    foreach (var clientform in Client)
            //    {
            //        var AdoptionDBEntities4 = new AdoptionDBEntities4();
            //        {
            //          //Id = clientform.Id,
            //          //FirstName = clientform.FirstName,
            //        };
            //    }
            //}
            return View();
        }

    }
}