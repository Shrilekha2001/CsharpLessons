using FirstMVCEFApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcEfApp.Models;

namespace FirstMVCEFApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: PatientController
        public ActionResult Index()
        {
            List<Patient> patient = RepositoryPatient.GetPatients();
            if (patient != null && patient.Count > 0)
                return View(patient);
            else
                return RedirectToAction("Create");
            
        }

        // GET: PatientController/Details/5
        public ActionResult Details(int id)
        {
            Patient patient = RepositoryPatient.GetPatientById(id);
            return View(patient);
            
        }

        // GET: PatientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Patient dpatient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryPatient.AddNewPatient(dpatient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: PatientController/Edit/5
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
                    RepositoryPatient.ModifyPatients(patient);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatientController/Delete/5
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
