using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace StudentCellPhone.Controllers
{
    public class StudentCellPhoneController : Controller
    {
        //Get: /Student/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}
