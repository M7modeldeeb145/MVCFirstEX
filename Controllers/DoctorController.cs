using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            SampleDataDoctor sample = new SampleDataDoctor();
            var result = sample.doctors.ToList();
            return View(result);
        }
    }
}
