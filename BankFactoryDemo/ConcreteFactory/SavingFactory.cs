using BankFactoryDemo.AbstractFactory;
using BankFactoryDemo.AbstractProduct;
using BankFactoryDemo.ConcreteProducts;

namespace BankFactoryDemo.ConcreteFactory;

public class SavingFactory : IAccountFactorys
{
    public AccountTypeEnum AccountType => AccountTypeEnum.Saving;

    public Account CreateAccount(string acno, Guid custId)
    {
        return new SavingAccount()
        {
            AccountNo = acno,
            CustomerId = custId,
            Balance = 0
        };
    }
}
