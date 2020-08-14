using Microsoft.AspNetCore.Mvc;

namespace PierresSweetAndSavoryTreats.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}