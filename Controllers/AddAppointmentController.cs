using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
	public class AddAppointmentController : Controller
	{
		public IActionResult Index(string DrName)
		{
			return View("Index", DrName);
		}
		//public IActionResult AddAppointment() 
		//{
		//	return View();
		//}
	}
}
