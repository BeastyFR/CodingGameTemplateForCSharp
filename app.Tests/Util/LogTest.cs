using Xunit;

namespace appTests.Tests
{

	public class LogTest
	{
		[Fact]
		public void TestVerbose()
		{
			Log.debugLevel = LogLevel.Verbose;
			Assert.Equal("message", Log.verboseLog("message"));
			Assert.Equal("message", Log.mediumLog("message"));
			Assert.Equal("message", Log.lightLog("message"));
		}

		[Fact]
		public void TestMedium()
		{
			Log.debugLevel = LogLevel.Medium;
			Assert.Null(Log.verboseLog("message"));
			Assert.Equal("message", Log.mediumLog("message"));
			Assert.Equal("message", Log.lightLog("message"));
		}

		[Fact]
		public void TestLight()
		{
			Log.debugLevel = LogLevel.Light;
			Assert.Null(Log.verboseLog("message"));
			Assert.Null(Log.mediumLog("message"));
			Assert.Equal("message", Log.lightLog("message"));
		}


		[Fact]
		public void TestNone()
		{
			Log.debugLevel = LogLevel.None;
			Assert.Null(Log.verboseLog("message"));
			Assert.Null(Log.mediumLog("message"));
			Assert.Null(Log.lightLog("message"));
		}

	}
}