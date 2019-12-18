using NUnit.Framework;

namespace Mars.Rover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5, 5)]
        public void Set_Size_Of_The_Exploration_Zone(int height, int width)
        {
            // Arrang
            var expectedSize = new Size(height, width);
            var landingSurface = new LandingSurface();

            // Act
            landingSurface.SetSize(expectedSize);
            var setSize = landingSurface.GetSize();

            // Assert
            Assert.AreEqual(expectedSize, setSize);
        }
    }
}