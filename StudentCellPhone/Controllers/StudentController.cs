using Microsoft.AspNetCore.Mvc;

namespace StudentCellPhone.Controllers
{
    public class StudentController : Controller
    {
        //Get: /Student 
        public string Index()
        {
            return "this is my default action";
        }
        //
        // GET: / Student/Welcome/
        public string WelcomeStudent()
        {
            return " this is the Welcome Student action method...";
        }
    }
        
}
