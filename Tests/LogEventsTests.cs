using System.Linq;
using Logging;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class LogEventsTests
    {
        [Test]
        public void ShouldBeAbleToAccessIndividualId()
        {
            var id = LogEvents.ExpiredAuthenticationContext.EventId;
            Assert.AreEqual(1234, id);
        }

        [Test]
        public void AllEventsShouldReturnEntryForEachEvent()
        {
            var allEvents = LogEvents.AllEvents.ToArray();
            Assert.AreEqual(2, allEvents.Length);
        }
    }
}
