using BankFactoryDemo.AbstractFactory;

namespace BankFactoryDemo.FactoryProvider;

public class AccountFactoryProvider : IAccountFactoryProvider
{
    private readonly Dictionary<AccountTypeEnum, IAccountFactorys> _factory;
    public AccountFactoryProvider(IEnumerable<IAccountFactorys> factories)
    {
        _factory = factories.ToDictionary(x=> x.AccountType);
    }
    public IAccountFactorys GetFactory(AccountTypeEnum type)
    {
        if(!_factory.TryGetValue(type, out var factory))
        {
            throw new Exception("Factory Not Found");
        }
        return factory;
    }
}
