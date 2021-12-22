using System;

namespace OOP_Homework
{
    /*
    Создать класс счет в банке с закрытыми полями: 
    номер счета, баланс, тип банковского счета (использовать перечислимый тип). 
    Предусмотреть методы для доступа к данным – заполнения и чтения. Создать объект класса, 
    заполнить его поля и вывести информацию об объекте класса на печать
    Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным. 
    Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
    В классе банковский счет, удалить методы заполнения полей. Вместо этих методов создать конструкторы. 
    Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, 
    конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и 
    типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.
    В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.
    (*)Добавить в класс счет в банке два метода: снять со счета и положить на счет. Метод снять со счета проверяет, 
    возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            var badAccount = CreateTestAccount();
            Console.WriteLine("BreakPoint");
            Console.WriteLine($"Result: {badAccount.GetData()}");
            Console.ReadKey();
            var betterAccount = CreateSecondAccount();
            Console.WriteLine("BreakPoint");
            Console.WriteLine($"Result: {betterAccount.GetData()}");
            Console.ReadKey();
        }

        private static Account CreateTestAccount()
        {
            var badAccount = new Account();
            badAccount.AssignId(0);
            badAccount.AddCash(1_000_000);
            badAccount.ChangeAccountType(AccountType.Individual);
            badAccount.RemoveCash(500_000);
            return badAccount;
        }

        private static ImprovedAccount CreateSecondAccount()
        {
            var cashToAdd = 1_000_000;
            var cashToRemove = 500_000;
            var betterAccount = new ImprovedAccount(500_000, AccountType.Individual);
            Console.WriteLine(betterAccount.GetData());
            betterAccount.AddCash(cashToAdd);
            Console.WriteLine($"Add: {cashToAdd}");
            Console.WriteLine(betterAccount.GetData());
            betterAccount.RemoveCash(cashToRemove);
            Console.WriteLine($"Remove: {cashToRemove}");
            Console.WriteLine(betterAccount.GetData());
            return betterAccount;
        }
    }
}