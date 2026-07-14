namespace BankFactoryDemo.AbstractProduct;

public abstract class Account
{
    public string AccountNo { get; set; }
    public int Balance { get; set; }
    public Guid CustomerId { get; set; }

    public virtual void Deposit(int amt)
    {
        Balance += amt;
    }
    public abstract void Withdraw(int amt);
}
