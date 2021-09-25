using System;
using Xunit;
using DotNetCoreApp.Controllers;

namespace DotNetCoreApp.Tests
{
    public class UnitTest1
    {
        WeatherForecastController obj = new  WeatherForecastController();
        [Fact]
        public void Test1()
        {
            var result = obj.Get(101);
            Assert.Equal("Vivek Gupta123",result);

            
        }
    }
}
