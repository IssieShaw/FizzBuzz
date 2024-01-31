namespace FizzBuzzApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var fizzOps = new FizzOperations();
            var buzzOps = new BuzzOperations();

            var fizzBuzzCalculator = new FizzBuzzCalculator(fizzOps, buzzOps);

            var results = await fizzBuzzCalculator.StartFizzBuzzCalculationsAsync();

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{results[i]}");
            }
        }
    }
}