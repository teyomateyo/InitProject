using System;

namespace InitProject.Infrastructure.Instrumentation.Logging
{
    public interface ILoggerService
    {
        void LogException(Exception ex);

        void LogDebug(string message);

        void LogInformation(string message);

        void LogWarning(string message);
    }
}
