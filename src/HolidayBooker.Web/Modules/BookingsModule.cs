using Nancy;

namespace HolidayBooker.Web.Modules
{
    public class BookingsModule : NancyModule
    {
        public BookingsModule()
        {
            Get["bookings"] = o => HttpStatusCode.NoContent;
        }
    }
}