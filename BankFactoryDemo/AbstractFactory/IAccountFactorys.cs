using BankFactoryDemo.AbstractProduct;

namespace BankFactoryDemo.AbstractFactory;

public interface IAccountFactorys
{
    AccountTypeEnum AccountType { get; }
    Account CreateAccount(string acno, Guid custId);
}
