using HolidayBooker.Web.Infrastructure;
using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace HolidayBooker.Web.Tests
{
    public class GivenBookingsModule
    {
        [Test]
        public void When()
        {
            var browser = new Browser(new HolidayBookerBootstrapper());
            var result = browser.Get("bookings");
            Assert.That(result.StatusCode, Is.EqualTo(HttpStatusCode.NoContent));
        }
    }
}
