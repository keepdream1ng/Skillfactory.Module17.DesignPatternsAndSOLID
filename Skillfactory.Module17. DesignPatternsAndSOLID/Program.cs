namespace Skillfactory.Module17._DesignPatternsAndSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Some example code.

            // Down below in comments is the old implimentation;

            //Account testAccount = new Account() { Type = "Обычный", Balance = 100, Interest = 40 };
            //Calculator.CalculateInterest(testAccount);
            //Console.WriteLine(testAccount.Interest);

            // Here is new one.

            WageAccount testWageAccount = new WageAccount() { Balance = 100 };
            Console.WriteLine($"{testWageAccount.Type} аккаунт имеет процентную ставку {testWageAccount.Interest}");

            RegularAccount testRegularAccount = new RegularAccount() { Balance = 100 };
            Console.WriteLine($"{testRegularAccount.Type} аккаунт имеет процентную ставку {testRegularAccount.Interest}");

            Console.ReadKey();
        }
    }
}