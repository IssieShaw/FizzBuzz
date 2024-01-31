using FizzBuzzApp;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzCalculatorUnitTest
    {
        [TestMethod]
        public async Task StartFizzBuzzCalculationsAsync_ReturnsCorrectResults()
        {
            // Arrange
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            string[] results = await fizzBuzzCalculator.StartFizzBuzzCalculationsAsync();

            // Assert
            Assert.AreEqual(10, results.Length); // Assuming 10 groups - hardcoded
            Assert.IsTrue(results.All(groupResult => !string.IsNullOrEmpty(groupResult))); // Check not empty
        }

        [TestMethod]
        public async Task CalculateFizzBuzzAsync_ReturnsValidResults()
        {
            // Arrange
            var fizzCalculator = new FizzOperations();
            var buzzCalculator = new BuzzOperations();
            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzCalculator, buzzCalculator);

            // Act
            List<string> result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(1, 10);

            // Assert assuming the range 1-10, so 10 results expected
            Assert.AreEqual(10, result.Count);
            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz", string.Join(" ", result));
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
            List<string> result = await fizzBuzzCalculator.CalculateFizzBuzzAsync(number, number);

            // Assert
            Assert.AreEqual(1, result.Count); // Single result expected
            Assert.AreEqual(number.ToString(), result[0]);
        }
    }
}
