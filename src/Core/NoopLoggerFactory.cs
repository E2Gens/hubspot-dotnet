using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace HubSpot.Core
{
    public static class NoopLoggerFactory
    {
        public static ILogger Get()
        {
            return new NoopLogger<HubSpotAction>();
        }

        public static ILogger<T> Get<T>()
        {
            return new NoopLogger<T>();
        }
    }
}
