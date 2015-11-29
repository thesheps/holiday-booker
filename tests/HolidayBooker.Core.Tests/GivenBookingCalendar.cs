using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace HolidayBooker.Core.Tests
{
    public class GivenBookingCalendar
    {
        [Test]
        public void WhenIRetrieveAvailableDates_ThenDatesAreRetrieved()
        {
            var calendar = new BookingCalendar();
            var dates = calendar.GetDates();

            Assert.That(dates, Is.Not.Empty);
        }
    }

    public class BookingCalendar
    {
        public IList<Date> GetDates()
        {
            throw new NotImplementedException();
        }
    }

    public class Date
    {
    }
}
