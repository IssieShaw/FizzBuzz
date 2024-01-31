using FizzBuzzApp;

using System.Threading.Tasks;


namespace FizzBuzzTest
{
    [TestClass]
    public class BuzzOperationUnitTest
    {
        [TestMethod]
        public async Task CalculateBuzzAsync_ReturnsBuzz()
        {
            // Arrange with a number that should return Buzz
            int number = 10;
            var buzzOperations = new BuzzOperations();

            // Act
            string result = await buzzOperations.CalculateAsync(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public async Task CalculateFizzAsync_ReturnsNumber()
        {
            // Arrange with number not divisible by 5
            int number = 7;
            var buzzOperations = new BuzzOperations();

            // Act
            string result = await buzzOperations.CalculateAsync(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }
    }
}   