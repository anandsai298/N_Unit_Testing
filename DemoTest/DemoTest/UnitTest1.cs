using ExampleTestDemo;
namespace DemoTest
{
    public class Tests
    {
        [Test]
        public void GivenTwoNumbers_WhenExecuted_ShouldReturnSum()
        {
            //arrange
            int x=30,y=10;
            //act
            Demo demo = new Demo();
            int sum = demo.Add(x, y);
            //assert
            Assert.AreEqual(sum, 40);
        }
        [Test]
        public void GivenTwoNumbers_WhenExecuted_ShouldReturnSub()
        {
            //arrange
            int x = 30, y = 10;
            //act
            Demo demo = new Demo();
            int sub = demo.Sub(x, y);
            //assert
            Assert.AreEqual(sub, 40);
        }
    }
}