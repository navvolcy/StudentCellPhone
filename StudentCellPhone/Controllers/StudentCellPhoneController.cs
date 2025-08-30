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
        //
        // GET: / Student/WelcomeStudent/
        //public string WelcomeStudent( string name, int ID = 1)
        //{
        //    //return " this is the Welcome Student action method...";
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}
    }
        
}
