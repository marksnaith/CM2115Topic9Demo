namespace Topic9Demo;

public class BankAccount
{
    public decimal Balance;

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if(amount <= 0 || amount > this.Balance)
        {
            return false;
        }

        this.Balance -= amount;
        return true;
    }
}
