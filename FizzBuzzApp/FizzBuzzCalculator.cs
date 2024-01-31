namespace FizzBuzzApp
{
    public class FizzBuzzCalculator
    {
        private readonly FizzOperations fizzOps;
        private readonly BuzzOperations buzzOps;

        public FizzBuzzCalculator(FizzOperations fizzOps, BuzzOperations buzzOps)
        {
            this.fizzOps = fizzOps;
            this.buzzOps = buzzOps;
        }

        public async Task<string> CalculateFizzBuzzAsync(int number)
        {
            Task<string> fizzTask = fizzOps.CalculateAsync(number);
            Task<string> buzzTask = buzzOps.CalculateAsync(number);

            // Wait for both tasks to complete
            await Task.WhenAll(fizzTask, buzzTask);

            string fizzResult = fizzTask.Result;
            string buzzResult = buzzTask.Result;

            var result = "";
            bool isFizz = fizzResult == "Fizz";
            bool isBuzz = buzzResult == "Buzz";

            if (isFizz && isBuzz)
            {
                result = fizzResult + buzzResult;
            }
            else if (isFizz)
            {
                result = fizzResult;
            }
            else if (isBuzz)
            {
                result = buzzResult;
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}