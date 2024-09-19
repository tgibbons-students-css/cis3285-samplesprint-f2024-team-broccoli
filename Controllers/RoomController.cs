using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            //I'm going to filter this code in accordance with user story 2B
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            // I am updating this Details method for User story 1A!
            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
            
        {
            //I'm going to filter this code in accordance with user story 2B
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            // This is a comment for User Story 2D - Jonny Saldin
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            // I am updating this Edit method for User story 1A!
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            // This is a comment for User Story 2D - Jonny Saldin
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            // I am updating this Delete method for User story 1A!
            return View();
        }

        // POST: RoomController/Delete/5
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
