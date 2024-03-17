namespace Hospital.Models
{
    public class AppointmentData
    {
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set;}
    }
}
