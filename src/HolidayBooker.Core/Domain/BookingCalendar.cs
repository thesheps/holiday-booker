using System.Collections.Generic;

namespace HolidayBooker.Core.Domain
{
    public class BookingCalendar
    {
        public IList<Booking> GetDates()
        {
            return new List<Booking> { new Booking() };
        }
    }
}