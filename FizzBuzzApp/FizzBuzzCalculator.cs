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

        public async Task<string[]> StartFizzBuzzCalculationsAsync()
        {
            // Divide the range for the task into 10 groups
            int start = 1;
            int end = 100;
            int groupSize = (end - start + 1) / 10; 

            // Create an array to store the results for each group
            string[] results = new string[10];

            // Use Parallel.For for async processing
            Parallel.For(0, 10, async i =>
            {
                int groupStart = start + i * groupSize;
                int groupEnd;
                if (i == 9)
                {
                    groupEnd = end;
                }
                else
                {
                    groupEnd = groupStart + groupSize - 1;
                }

                // Calculate FizzBuzz for the current group
                results[i] = string.Join(" ", await CalculateFizzBuzzAsync(groupStart, groupEnd));
            });

            return results;
        }

        public async Task<List<string>> CalculateFizzBuzzAsync(int start, int end)
        {
            List<string> results = new List<string>();

            for (int number = start; number <= end; number++)
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

                results.Add(result);
            }

            return results;
        }
    }
}