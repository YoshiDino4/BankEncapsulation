namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Deposit Amount: ");
            var depAmount = double.Parse(Console.ReadLine());
            
            account.Deposit(depAmount);
            Console.WriteLine($"You have deposited ${depAmount}. Your bank balance is now ${account.GetBalance()}");
        }
    }
}
