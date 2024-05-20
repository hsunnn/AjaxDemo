using AjaxDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AjaxDemo.Controllers
{
    public class ApiController : Controller
    {

        private readonly MyDBContext _context;

        public ApiController(MyDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return Content("<h1>安安安安</h1>", "text/html", System.Text.Encoding.UTF8);
        }

        public IActionResult Cities()
        {
            var cities = _context.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }

        public IActionResult Avatar(int id = 1)
        {
            Member? member = _context.Members.Find(id);
            if (member != null)
            {
                byte[] img = member.FileData;
                if (img != null)
                {
                    return File(img, "image/jpeg");
                }
            }

            return NotFound();
        }

    }
}
