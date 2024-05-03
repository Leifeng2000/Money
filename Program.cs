internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter US Dollar amount: ");
        double usdAmount = double.Parse(Console.ReadLine());

        double exchangeRate = 23000;
        double vndAmount = usdAmount * exchangeRate;

        Console.WriteLine($"Amount in Vietnam Dong: {vndAmount} VND");
    }
}