using Microsoft.Extensions.Logging;
using System;

namespace VitalCheck.Logger
{
	public interface ILogger
	{
		void Log<Tstate>(LogLevel logLevel, EventId eventId, Tstate state, Exception exception, Func<Tstate, Exception, string> formatter);
		bool IsEnabled(LogLevel logLevel);
		IDisposable BeginScope<Tstate>(Tstate state);
	}

	public interface ILoggerFactory : IDisposable
	{
		ILogger CreateLogger(string categoryName);
		void AddProvider(ILoggerProvider provider);
	}

	public interface ILoggerProvider : IDisposable
	{
		ILogger CreateLogger(string categoryName);
	}
}
