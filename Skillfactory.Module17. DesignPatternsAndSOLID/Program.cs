namespace Skillfactory.Module17._DesignPatternsAndSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Some example code.
            Account testAccount = new Account() { Type = "Обычный", Balance = 100, Interest = 40 };
            Calculator.CalculateInterest(testAccount);
            Console.WriteLine(testAccount.Interest);

            Console.ReadKey();
        }
    }
}