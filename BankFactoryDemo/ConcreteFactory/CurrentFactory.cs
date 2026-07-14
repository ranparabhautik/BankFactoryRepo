using BankFactoryDemo.AbstractFactory;
using BankFactoryDemo.AbstractProduct;
using BankFactoryDemo.ConcreteProducts;

namespace BankFactoryDemo.ConcreteFactory;

public class CurrentFactory : IAccountFactorys
{
    public AccountTypeEnum AccountType => AccountTypeEnum.Current;

    public Account CreateAccount(string acno, Guid custId)
    {
        return new CurrentAccount()
        {
            AccountNo = acno,
            CustomerId = custId,
            Balance = 5000
        };
    }
}
