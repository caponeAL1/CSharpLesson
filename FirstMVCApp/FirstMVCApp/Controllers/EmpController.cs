using AuthorApplication2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<CreateEmp> empList = EmpDbRepository.GetEmpList();
            return View(empList);
            
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            CreateEmp emp=EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            CreateEmp emp = new CreateEmp();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,CreateEmp pCreateEmp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.AddNewEmp(pCreateEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            CreateEmp emp = EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            if(id<=0)
            {
                return RedirectToAction("Index");
            }
            CreateEmp emp=EmpDbRepository.GetEmpById(id);
            return View(emp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    EmpDbRepository.DeleteEmp(id);
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
