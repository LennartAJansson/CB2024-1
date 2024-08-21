using FactoryPattern.Interfaces;

using FactoryPattern.Factories;

ISavingsAccount citiAcct = AccountFactory.GetSavingsAccount("CITI-321");
ISavingsAccount nationalAcct = AccountFactory.GetSavingsAccount("NATIONAL-987");

Console.WriteLine($"My Citi balance is ${citiAcct.Balance}");
Console.WriteLine($"My National balance is ${nationalAcct.Balance}");
