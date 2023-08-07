using Microsoft.AspNetCore.Mvc;
using Semafor_Hospital_Registrastion_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Semafor_Hospital_Registrastion_System.Controllers
{
    public class VisitController : Controller
    {
        private readonly ApplicationContext _context;
        public VisitController(ApplicationContext context)
        {
            _context = context;
        }
       
        public IActionResult AddVisit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVisit(Visit visit)
        {
            ViewBag.visitError = null;

            if (ModelState.IsValid)
            {
                var controlPatient = _context.patients.Where(p => p.id == visit.patient_id).Count();
                if (controlPatient == 1)
                {
                    visit.visit_id = null;
                    _context.Database.ExecuteSqlRaw($"CALL addvisit({visit.patient_id},'{visit.visit_date}','{visit.doctor_name}','{visit.complaint}','{visit.form_of_treatment}')");
                    _context.SaveChanges();
                    return RedirectToAction("AddVisit", "Visit"); // Başka bir sayfaya yönlendirme
                }
                else
                {
                    ViewBag.visitError = "There is not a patient record with this 'patient_id'. Please add the patient first.";
                }
            }

            return View();

        }
        public IActionResult ViewVisit()
        {
            ViewBag.visits = _context.visits.ToList();
            return View();
        }

        public IActionResult SelectVisit(int selectedVisitId)
        {
            if (selectedVisitId > 0)
            {
                var selectedVisit = _context.visits.FirstOrDefault(p => p.visit_id == selectedVisitId);
                if (selectedVisit != null)
                {
                    return RedirectToAction("ViewDetails", "Visit", new { id = selectedVisitId });
                }
            }

            // Hata durumunda veya seçim yapılmadığında ana sayfaya yönlendirme
            return RedirectToAction("SelectVisit");
        }
        public IActionResult ViewDetails(int id)
        {
            var visit = _context.visits.FirstOrDefault(p => p.visit_id == id);
            if (visit == null)
            {
                return RedirectToAction("SelectVisit");
            }

            return View(visit);
        }
        public IActionResult UpdateVisit(Visit visit)
        {
            return View(visit);
        }
        [HttpPost]
        public IActionResult Update(Visit visit)
        {
            if (ModelState.IsValid)
            {
                _context.Database.ExecuteSqlRaw($"CALL updatevisit({visit.visit_id},{visit.patient_id},'{visit.visit_date}','{visit.doctor_name}','{visit.complaint}','{visit.form_of_treatment}')");
                _context.SaveChanges();
                return RedirectToAction("ViewVisit", "Visit");
            }

            return View(visit);
        }
        public IActionResult DeleteVisit(Visit visit)
        {
            if (ModelState.IsValid)
            {
                _context.Database.ExecuteSqlRaw($"CALL deletevisit({visit.visit_id})");
                _context.SaveChanges();
                return RedirectToAction("ViewVisit", "Visit");
            }

            return View(visit);
        }
       
    }
}
