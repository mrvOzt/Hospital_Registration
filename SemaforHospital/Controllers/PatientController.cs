using Microsoft.AspNetCore.Mvc;
using Semafor_Hospital_Registrastion_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Semafor_Hospital_Registrastion_System.Controllers
{
    public class PatientController : Controller
    {

        private readonly ApplicationContext _context;
        public PatientController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult PatientList()
        {
            ViewBag.patients = _context.patients.ToList();
            return View();
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        
       

        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            ViewBag.idError = null;
            //User u = new User(patient.name_surname, patient.id_no.ToString(), "patient", patient.id_no.ToString());
            if (ModelState.IsValid)
            {
                var patientsWithId = _context.patients.Where(p => p.id_no == patient.id_no).Count();
                if(patientsWithId == 0)
                {
                    patient.id = null;
                    _context.Database.ExecuteSqlRaw($"CALL public.adduser('{patient.name_surname}', '{patient.id_no.ToString()}','Patient','{patient.id_no.ToString()}')");
                    _context.Database.ExecuteSqlRaw($"CALL public.addpatient({patient.id_no}, '{patient.name_surname}', '{patient.birth_date}')");
                    _context.SaveChanges();
                    return RedirectToAction("PatientList", "Patient"); // Başka bir sayfaya yönlendirme
                }
                else
                {
                    ViewBag.idError = "There is already a patient record with this identification number.";
                }
            }

            return View();


        }
        public IActionResult UpdatePatient()
        {
            ViewBag.patients = _context.patients.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult SelectPatient(int selectedPatientId)
        {
            if (selectedPatientId > 0)
            {
                var selectedPatient = _context.patients.FirstOrDefault(p => p.id == selectedPatientId);
                if (selectedPatient != null)
                {
                    return RedirectToAction("EditPatient", "Patient",new { id = selectedPatientId });
                }
            }

            // Hata durumunda veya seçim yapılmadığında ana sayfaya yönlendirme
            return RedirectToAction("SelectPatient");
        }
        public IActionResult EditPatient(int id)
        {
            var patient = _context.patients.FirstOrDefault(p => p.id == id);
            if (patient == null)
            {
                return RedirectToAction("SelectPatient");
            }
            
            return View(patient);
        }

        [HttpPost]
        public IActionResult EditPatient(Patient patient)
        {
            ViewBag.idError = null;
            if (ModelState.IsValid)
            {
                var patientsWithId = _context.patients.Where(p => p.id_no == patient.id_no).Count();
                if (patientsWithId == 0)
                {
                    _context.Database.ExecuteSqlRaw($"CALL public.updatepatient({patient.id},{patient.id_no}, '{patient.name_surname}', '{patient.birth_date}')");
                    _context.SaveChanges();
                    return RedirectToAction("UpdatePatient", "Patient");
                }
                else
                {
                    ViewBag.idError = "There is already a patient record with this identification number.";
                }

            }

            return View();
        }

        public IActionResult DetailPatient(int id) { 
        
            var visits = _context.visits.Where(v => v.patient_id == id).ToList();
            ViewBag.visitPatient = visits;
            var selectedPatient = _context.patients.FirstOrDefault(p => p.id == id);
            return View(selectedPatient);
        }
        public IActionResult DeletePatient(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Database.ExecuteSqlRaw($"CALL public.deletepatient({patient.id})");
                _context.SaveChanges();
                return RedirectToAction("PatientList", "Patient");
            }

            return View(patient.id);
        }



    }
}
