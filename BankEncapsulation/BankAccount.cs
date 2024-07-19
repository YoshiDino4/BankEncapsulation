namespace BankEncapsulation;

public class BankAccount
{
    public BankAccount()
    {
        
    }

    private double _balance = 0;

    public void Deposit(double depositAmount)
    {
        _balance = depositAmount;
    }

    public double GetBalance()
    {
        return _balance;
    }
}