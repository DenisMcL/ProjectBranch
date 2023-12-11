namespace UUZooTest
{
    [TestClass]
    public class StorkTest
    {
        [TestMethod]
        public void TestEat()
        {
            //Arrange
            var Stork = new Stork();
            double expected = 6.5;

            //Act
            Stork.Eat(3);
            double AcWeight = Stork.Weight;

            //Assert
            Assert.AreEqual(expected, AcWeight);
        }
    }
}