using System;
using System.Linq;

namespace Booking
{
    public class Reservation : IReservationy
    {
        Random random = new Random();

        public string GetCodeBooking()
        {          
            string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(allowedChars, 7).Select(x => x[random.Next(x.Length)]).ToArray());
        }

        public string GetDowBooking()
        {
            Array values = Enum.GetValues(typeof(DayOfWeek));
            DayOfWeek randomDay = (DayOfWeek)values.GetValue(random.Next(values.Length));
            return randomDay.ToString();
        }
    }
    enum DayOfWeek
    {
        MON,
        TUE,
        WED,
        THU,
        FRI,
        SAT,
        SUN
    }
}