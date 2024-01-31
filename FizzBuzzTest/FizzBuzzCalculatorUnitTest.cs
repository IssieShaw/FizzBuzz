using FizzBuzzApp;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzCalculatorUnitTest
    {
        [TestMethod]
        public async Task CalculateFizzBuzzAsync_FizzReturned()
        {
            // Arrange
            int number = 9;  // Example number divisible by 3
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            string result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [TestMethod]
        public async Task CalculateFizzBuzzAsync_BuzzReturned()
        {
            // Arrange
            int number = 10;  // Example number divisible by 5
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            string result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [TestMethod]
        public async Task CalculateFizzBuzzAsync_FizzBuzzReturned()
        {
            // Arrange
            int number = 15;  // Example number divisible by both 3 and 5
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            string result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [TestMethod]
        public async Task CalculateFizzBuzzAsync_Number()
        {
            // Arrange
            int number = 7;
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            string result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }
    }
}
