namespace FizzBuzzApp
{
        public class FizzOperations : IFizzBuzzOperations
    {
        public async Task<string> CalculateAsync(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}