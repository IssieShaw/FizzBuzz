
namespace FizzBuzzApp
{
    public class BuzzOperations : IFizzBuzzOperations
    {
        public async Task<string> CalculateAsync(int number)
        {
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}