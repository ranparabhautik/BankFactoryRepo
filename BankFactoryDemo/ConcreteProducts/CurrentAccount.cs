using BankFactoryDemo.AbstractProduct;

namespace BankFactoryDemo.ConcreteProducts;

public class CurrentAccount : Account
{
    private int overdraftlimit = 100000;
    public override void Withdraw(int amt)
    {
        if((Balance + overdraftlimit ) < amt)
        {
            throw new Exception("Over draft exceddes");
        }
        Balance -= amt;
    }
}
