using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
	public class ConfirmAppointmentController : Controller
	{
		List<AppointmentData> appointmentDatas = new List<AppointmentData>();
		public IActionResult ConfirmAppointment(string patientName, DateTime appointmentDate, TimeSpan appointmentTime)
		{
			AppointmentData data = new AppointmentData();
			data.PatientName = patientName;
			data.AppointmentDate = appointmentDate;
			data.AppointmentTime = appointmentTime;
            appointmentDatas.Add(data);
            return View(appointmentDatas);
		}

	}
}
