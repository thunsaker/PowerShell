using Xunit;
using System;
using System.Management.Automation;
using System.Reflection;

namespace PSTests.Parallel
{
    public static class UtilsTests
    {
        [SkippableFact]
        public static void TestIsWinPEHost()
        {
            Skip.IfNot(Platform.IsWindows);
            Assert.False(Utils.IsWinPEHost());
        }
    }
}
