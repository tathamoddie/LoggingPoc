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
    }
}
