namespace TestProjectCCAD17
{
    [TestClass]
    public sealed class TestDivision
    {
        [TestMethod]
        public void DivideByZero_TestShouldThrow()
        {
            // Arrange
            int a = 20;
            int b = 0;

            // Act
            int result = Divide(a, b);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void DivideNonNumber()
        {
        }

        [TestMethod]
        public void DivideByDouble()
        {
        }

        [TestMethod]
        public void DivideByNegative()
        {
        }
    }
}
