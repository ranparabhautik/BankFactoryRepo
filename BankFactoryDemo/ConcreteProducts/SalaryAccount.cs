using BankFactoryDemo.AbstractProduct;

namespace BankFactoryDemo.ConcreteProducts;

public class SalaryAccount : Account
{
    public override void Withdraw(int amt)
    {
        if(Balance < amt)
        {
            throw new ArgumentException("Amount insufficient");
        }
        Balance -= amt;
    }
}


