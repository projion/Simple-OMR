using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_OMR.Models;
using Simple_OMR.ViewModels;

namespace Simple_OMR.Controllers
{
    [Authorize(Roles = "Admin, User, Moderator")]
    public class DemoBufferController : Controller
    {
        private readonly IDemoBufferRepository demoBufferRepository;

        public DemoBufferController(IDemoBufferRepository demoBufferRepository)
        {
            this.demoBufferRepository = demoBufferRepository;
        }
        #region System generated W/r
        // GET: DemoBufferController
        public IActionResult Index()
        {
            var model = demoBufferRepository.All().ToList();
            return View(model);
        }
        #endregion
        // GET: DemoBufferController/Details/5
        public ActionResult Details(int id)
        {
            DemoBufferDetailsViewModel demoBufferDetailsViewModel = new DemoBufferDetailsViewModel();
            {
                demoBufferDetailsViewModel.demoBufferModel= demoBufferRepository.GetPerson(id);
            }
            return View(demoBufferDetailsViewModel);
        }
        #region auto generated methods
        // GET: DemoBufferController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DemoBufferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DemoBufferController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DemoBufferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DemoBufferController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DemoBufferController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
        public ActionResult DemoBuffer()
        {
            return View();
        }
    }
}
