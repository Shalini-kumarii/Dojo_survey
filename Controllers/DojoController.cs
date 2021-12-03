using Microsoft.AspNetCore.Mvc;
namespace Dojo_survey.Controllers     //be sure to use your own project's namespace!
{
    public class DojoController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        // [HttpGet]       //type of request
        // [Route("")]     //associated route string (exclude the leading /)
        [HttpGet("")]      // Both upper lines can be written in one line
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("result")]
        public IActionResult Result(string result)
        {

            return View("Result");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string location, string language, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comments = comment;
            return View();
        }
        [HttpPost]
        [Route("back")]
        public IActionResult back()
        {
            return RedirectToAction("Index");
        }

    }
}

