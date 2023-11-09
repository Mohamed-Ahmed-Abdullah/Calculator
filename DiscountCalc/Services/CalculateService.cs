namespace DiscountCalc.Services
{
    public interface ICalculateService
    {
        int Add(int a, int b);
    }

    public class CalculateService : ICalculateService, IDisposable
    {
        public CalculateService()
        {
            Console.WriteLine("CalculateService instance created");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Dispose()
        {
            Console.WriteLine("CalculateService instance disposed");
        }

        ~CalculateService()
        {
            Console.WriteLine("CalculateService instance finalized");
        }
    }

}
