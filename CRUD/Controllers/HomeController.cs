using CRUD.Models;
using CRUD.Models.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepo _context;
        EmployeeContext EmployeeRepo = new EmployeeContext();
        public HomeController()
        {
            this._context = new EmployeeRepo (new Models.EmployeeContext());
        }
        // GET: Home
        public ActionResult Index()
        {
            var AllEmps = _context.GetEmps();
            return View(AllEmps);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            _context.InsertEmp(employee);
            _context.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Employee emp = _context.GetEmpByID(id);
            return View(emp);
        }
        public ActionResult Delete(int id)
        {
            Employee emp = _context.GetEmpByID(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            _context.DeleteEmp(id);
            _context.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Employee emp = _context.GetEmpByID(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            _context.UpdateEmp(emp);
            _context.Save();
            return RedirectToAction("Index");
        }
    }
}