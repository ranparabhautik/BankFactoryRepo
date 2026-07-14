using BankFactoryDemo.AbstractProduct;

namespace BankFactoryDemo.ConcreteProducts;

public class SavingAccount : Account
{
    public override void Withdraw(int amt)
    {
        if(Balance < amt)
        {
            throw new ArgumentException("Amount is insufficient");
        }
        Balance -= amt;
    }
}
