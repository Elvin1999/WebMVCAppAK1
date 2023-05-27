namespace WebMVCAppAK1.Services
{
    public class SimpleCalculatorService : ICalculatorService
    {
        public decimal Data { get; set; }
        public SimpleCalculatorService()
        {
            System.Console.WriteLine(Data);
        }
        public decimal Calculate(decimal amount)
        {
            Data += amount;
            return Data;
        }
    }
}
