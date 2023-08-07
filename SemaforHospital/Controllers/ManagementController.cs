using Microsoft.AspNetCore.Mvc;
using Semafor_Hospital_Registrastion_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Semafor_Hospital_Registrastion_System.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ApplicationContext _context;
        public ManagementController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           ViewBag.visit_no= _context.visits.Count();
           ViewBag.patient_no = _context.patients.Count();
            
            return View();
        }
        
    }
}
