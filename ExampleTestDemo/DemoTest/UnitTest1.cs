using System;
using NUnit.Framework;
namespace DemoTest
{
    public class Tests
    {
        [Test]
        public void GivenTwoNumbers_WhenExecuted_ShouldReturnSum()
        {
            //Arrange
            int a=10,b=20;
            //Act
            Demo demo = new Demo();
            int sum = demo.Add(a, b);
            //Assert
            Assert.AreEqual(sum,30);
        }
    }
}