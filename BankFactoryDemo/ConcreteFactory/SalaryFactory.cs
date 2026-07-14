using BankFactoryDemo.AbstractFactory;
using BankFactoryDemo.AbstractProduct;
using BankFactoryDemo.ConcreteProducts;

namespace BankFactoryDemo.ConcreteFactory;

public class SalaryFactory : IAccountFactorys
{
    public AccountTypeEnum AccountType => AccountTypeEnum.Salary;

    public Account CreateAccount(string acno, Guid custId)
    {
        return new SalaryAccount()
        {
            AccountNo = acno,
            Balance = 0,
            CustomerId = custId,
        };
    }
}
