using BankFactoryDemo;
using BankFactoryDemo.AbstractFactory;
using BankFactoryDemo.ConcreteFactory;
using BankFactoryDemo.FactoryProvider;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection services = new ServiceCollection();

services.AddScoped<IAccountFactorys, SavingFactory>();
services.AddScoped<IAccountFactorys, CurrentFactory>();
services.AddScoped<IAccountFactorys, SalaryFactory>();
services.AddScoped<IAccountFactoryProvider,AccountFactoryProvider>();
services.AddScoped<AccountService>();


ServiceProvider provider = services.BuildServiceProvider();

AccountService accservices = provider.GetRequiredService<AccountService>();

var ac1 = accservices.OpenAccount(AccountTypeEnum.Current, "AC101", new Guid("hello"));

Console.WriteLine(ac1.Balance);
Console.WriteLine(ac1.AccountNo); 
Console.WriteLine(ac1.CustomerId);


