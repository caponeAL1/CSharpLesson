using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEfApp.Models;

namespace MvcEfApp.Controllers
{
    public class PatientController : Controller
    {
        private Patient pPatient;

        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patients = RepositoryPatient.GetPatients();
            if (patients != null && patients.Count() > 0)
                return View(patients);
            else
                return RedirectToAction("Create");

        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Patient pPatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(pPatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception error)
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Patient patient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.ModifyPatient(patient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   RepositoryPatient.RemovePatient(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}