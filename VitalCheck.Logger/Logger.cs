using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace VitalCheck.Logger
{
	public class Logger : ILogger
	{
		public void Log<Tstate>(LogLevel logLevel, EventId eventId, Tstate state, Exception exception, Func<Tstate, Exception, string> formatter)
		{
			var message = string.Format("{0}: {1} - {2}", logLevel.ToString(), eventId.Id, formatter(state, exception));

			Debug.WriteLine(message);
		}

		public IDisposable BeginScope<Tstate>(Tstate state)
		{
			return null;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return true;
		}
	}
}