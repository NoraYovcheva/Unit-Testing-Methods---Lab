namespace _1.Calculator.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_SumOfIntegers()
        {
            //Arrange
            int x = 2;
            int y = 3;
            int expected = 5;

            //Act 
            int actual = Program.SumOfIntegers(x, y);

            //Assert
            //Assert.AreEqual(expected, actual);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}