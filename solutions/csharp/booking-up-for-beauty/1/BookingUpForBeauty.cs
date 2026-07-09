static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        try
        {
            return DateTime.Parse(appointmentDateDescription);
        }
        catch (Exception)
        {
            throw new ArgumentException("The appointment date description is invalid.");
        }
    }

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate <= DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
