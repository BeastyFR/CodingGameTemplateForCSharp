public enum LogLevel
{
	None,
	Light,
	Medium,
	Verbose
}

public static class Log
{
	static public LogLevel debugLevel = LogLevel.None;
	static public string? lightLog(string message)
	{
		if (Log.debugLevel >= LogLevel.Light)
			return Console.Error.WriteLine(message);
		return null;
	}

	static public string? mediumLog(string message)
	{
		if (Log.debugLevel >= LogLevel.Medium)
			return Console.Error.WriteLine(message);
		return null;
	}

	static public string? verboseLog(string message)
	{
		if (Log.debugLevel >= LogLevel.Verbose)
			return Console.Error.WriteLine(message);
		return null;
	}

}
