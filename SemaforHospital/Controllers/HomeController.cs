using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Semafor_Hospital_Registrastion_System.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Semafor_Hospital_Registrastion_System.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ApplicationContext _context;
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            ViewBag.loginUser = user.role;
            ViewBag.username = user.username;
            var controlUser = _context.users.FirstOrDefault(u => u.id_number == user.id_number);
            

            if (controlUser != null && controlUser.password == user.password && controlUser.username == user.username && controlUser.role == user.role)
            {
                if(controlUser.role == "admin")
                {
                    return RedirectToAction("Index", "Management"); // Yönlendireceğiniz sayfa ve controller'ı belirtin
                }
                else
                {
                    var selectedPatient = _context.patients.FirstOrDefault(p => p.id_no.ToString() == user.id_number);
                    return RedirectToAction("DetailPatient", "Patient" , new { id = selectedPatient.id});
                }
                // Doğru kullanıcı adı ve şifre, başka sayfaya yönlendir
            }
            else
            {
                ViewBag.loginError = "Invalid information";
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
