namespace VitalCheck.Logger
{
	public class LogggerProvider : ILoggerProvider
	{
		public ILogger CreateLogger(string categoryName)
		{
			return new Logger();
		}

		public void Dispose()
		{
		}
	}
}