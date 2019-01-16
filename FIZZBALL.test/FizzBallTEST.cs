using System;
using Xunit;

namespace FIZZBALL.test
{
    public class FizzBallTEST
    {
        [Fact]
        public void Get_returns_1_For_1()
        {
            //Arrange
            FizzBall underTest = new FizzBall();
            //Act
            string result = underTest.Get(1);
            //Assert
            Assert.Equal("1", result);
        }
    }
}