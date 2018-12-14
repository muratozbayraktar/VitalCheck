using Serilog;
using System;

public static class Log
{
	private const string template = "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}";

	private static readonly ILogger aaa = new LoggerConfiguration().CreateLogger();

	public static void Error(string message, Exception exception = null)
	{
		using (var log = new LoggerConfiguration().WriteTo.Console(outputTemplate:template).CreateLogger())
		{
			log.Error(exception, message);
		}
	}
}