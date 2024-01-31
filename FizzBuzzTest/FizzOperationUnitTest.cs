using FizzBuzzApp;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzOperationUnitTest
    {
        [TestMethod]
        public async Task CalculateFizzAsync_ReturnsFizz()
        {
            // Arrange with a number that should return Fizz
            int number = 9;
            var fizzOperations = new FizzOperations();

            // Act
            string result = await fizzOperations.CalculateAsync(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public async Task CalculateFizzAsync_ReturnsNumber()
        {
            // Arrange with number not divisible by 3
            int number = 7;
            var fizzOperations = new FizzOperations();

            // Act
            string result = await fizzOperations.CalculateAsync(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }
    }
}