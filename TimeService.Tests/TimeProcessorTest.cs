using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TimeService.Tests
{
    public class TimeProcessorTest
    {
        [Fact]
        public void TestCurrentTimeUTC()
        {
            // Arrange
            var processor = new TimeProcessor();
            var preTestTimeUtc = DateTime.UtcNow;

            // Act
            var result = processor.CurrentTimeUTC();
           // var finalresult = result.ToString();

            // Assert time moves forwards 
            var postTestTimeUtc = DateTime.UtcNow;
            Assert.True(result >= preTestTimeUtc);
            Assert.True(result <= postTestTimeUtc);
        }
    }
}
