using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class MessageController : Controller
    {
        // GET: MessageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageController/Details/5
        public ActionResult Details(int id)
        {
        // I'm updating this controller for user story 1B
        // I'm going to update this for the second part of 1B as well!
        // I'm going to filter this code in accordance with user story 2B
            return View();
        }

        // GET: MessageController/Create
        public ActionResult Create()
        {
            // I'm updating this controller for user story 1B
            //I'm updating this for the second part of 1B as well
            return View();
        }

        // POST: MessageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            // Changes Sprint 2C -- As a system administrator, I want to serve hundreds of users concurrently -- Grace Hrabik
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageController/Edit/5
        public ActionResult Edit(int id)
        {
            // Changes Sprint 2C -- As a system administrator, I want to serve hundreds of users concurrently -- Grace Hrabik
            return View();
        }

        // POST: MessageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            // Changes Sprint 2C -- As a system administrator, I want to serve hundreds of users concurrently -- Grace Hrabik
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageController/Delete/5
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
    }
}
