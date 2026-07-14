using BankFactoryDemo.AbstractFactory;

namespace BankFactoryDemo.FactoryProvider;

public interface IAccountFactoryProvider
{
    IAccountFactorys GetFactory(AccountTypeEnum type);
}
