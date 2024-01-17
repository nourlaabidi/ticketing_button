using System.Web;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Buttons;
using System.Reflection.Emit;
using WebApplication1.Data;
using WebApplication1.Core.Models;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbcontext _db;
        public CategoryController(ApplicationDbcontext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            SharedValue.Url = Request.GetDisplayUrl();
            return View();
        }


        [HttpPost]
        
        public IActionResult SubmitForm(Category model)
        {
            if (ModelState.IsValid)
            {
                string UrlC = SharedValue.Url;
                model.Url = UrlC;
                _db.categories.Add(model);
                _db.SaveChanges();
                return View("Index");
            }
            return View("Index", model);
        }

        public IActionResult SubmitForm2(feedback model)
        {
            if (ModelState.IsValid)
            {
                int ratingValue = Convert.ToInt32(Request.Form["Feedback"]);
                model.Feedback = ratingValue;
                string UrlC = SharedValue.Url;
                model.Url = UrlC;
                _db.feedbacks.Add(model);
                _db.SaveChanges();
                return View("Index");
            }
            return View("Index", model);
        }
    }
}
