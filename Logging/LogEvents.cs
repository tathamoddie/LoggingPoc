namespace Logging
{
    public static partial class LogEvents
    {
        public static readonly LogEvent ExpiredAuthenticationContext = new LogEvent
        {
            EventId = 1234,
            ShortDescription = "The authentication context is beyond its expiry date and can't be used.",
            OperationalGuidance = "Check the time coordination between the front-end web servers and the authentication tier."
        };

        public static readonly LogEvent CorruptAuthenticationContext = new LogEvent
        {
            EventId = 5678,
            ShortDescription = "The authentication token failed checksum prior to decryption.",
            OperationalGuidance = "Use the authentication test helper script to validate the raw tokens being returned by the authentication tier."
        };
    }
}
