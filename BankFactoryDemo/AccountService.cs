using BankFactoryDemo.AbstractFactory;
using BankFactoryDemo.AbstractProduct;
using BankFactoryDemo.FactoryProvider;

namespace BankFactoryDemo;

public class AccountService
{
    private readonly IAccountFactoryProvider _factoryProvider;
    public AccountService(IAccountFactoryProvider factoryProvider)
    {
        _factoryProvider = factoryProvider;
    }

    public Account OpenAccount(AccountTypeEnum type,string scno, Guid CustId )
    {
        IAccountFactorys factory = _factoryProvider.GetFactory(type);
        Account acc = factory.CreateAccount(scno,CustId);
        return acc;
    }
}
