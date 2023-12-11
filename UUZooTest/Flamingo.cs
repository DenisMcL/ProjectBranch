namespace UUZooTest
{
    [TestClass]
    public class FlamingoTest
    {
        [TestMethod]
        public void TestEat()
        {
            //Arrange
            var Flamingo = new Flamingo();
            double expected = 7.9;

            //Act
            Flamingo.Eat(3);
            double AcWeight = Flamingo.Weight;

            //Assert
            Assert.AreEqual(expected, AcWeight);
        }
    }
}