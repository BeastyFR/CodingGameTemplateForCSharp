enum LogLevel{
	None,
	Light,
	Medium,
	Verbose
}

static class Log
{
	static public LogLevel debugLevel = LogLevel.None;
	static public void lightLog(string message)
	{
		if(Log.debugLevel >= LogLevel.Light)
			Console.Error.WriteLine(message);
	}

	static public void mediumLog(string message)
	{
		if(Log.debugLevel >= LogLevel.Medium)
			Console.Error.WriteLine(message);
	}

	static public void verboseLog(string message)
	{
		if(Log.debugLevel >= LogLevel.Verbose)
			Console.Error.WriteLine(message);
	}

} 