namespace Logging
{
    public static class LogEvents
    {
        public class LogEvent
        {
            public long EventId { get; set; }
            public string ShortDescription { get; set; }
            public string OperationalGuidance { get; set; }
        }

        public static readonly LogEvent ExpiredAuthenticationContext = new LogEvent
        {
            EventId = 1234,
            ShortDescription = "The authentication context is beyond its expiry date and can't be used.",
            OperationalGuidance = "Check the time coordination between the front-end web servers and the authentication tier."
        };
    }
}
