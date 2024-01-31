namespace FizzBuzzApp
{
    public interface IFizzBuzzOperations
    {
        Task<string> CalculateAsync(int number);
    }
}