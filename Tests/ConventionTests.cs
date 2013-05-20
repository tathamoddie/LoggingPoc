using System.Linq;
using Logging;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConventionTests
    {
        [Test]
        [TestCaseSource(typeof(LogEvents), "AllEvents")]
        public void AllEventsShouldHaveUniqueIds(LogEvents.LogEvent logEvent)
        {
            var numberOfTimesThisEventIdIsUsed = LogEvents
                .AllEvents
                .Count(l => l.EventId == logEvent.EventId);

            Assert.AreEqual(
                1, numberOfTimesThisEventIdIsUsed,
                "The id was used multiple times. Log event ids must be unique.");
        }

        [Test]
        [TestCaseSource(typeof(LogEvents), "AllEvents")]
        public void AllEventsShouldHaveShortDescription(LogEvents.LogEvent logEvent)
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(logEvent.ShortDescription));
        }

        [Test]
        [TestCaseSource(typeof(LogEvents), "AllEvents")]
        public void AllEventsShouldHaveAtLeast50CharactersOfOperationalGuidance(LogEvents.LogEvent logEvent)
        {
            Assert.IsTrue(logEvent.OperationalGuidance.Length >= 50);
        }
    }
}
