using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Logging
{
    partial class LogEvents
    {
        public class LogEvent
        {
            public long EventId { get; set; }
            public string ShortDescription { get; set; }
            public string OperationalGuidance { get; set; }
        }

        public static IEnumerable<LogEvent> AllEvents
        {
            get
            {
                return typeof(LogEvents)
                    .GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly)
                    .Where(f => f.FieldType == typeof(LogEvent))
                    .Select(f => (LogEvent)f.GetValue(null));
            }
        }
    }
}
