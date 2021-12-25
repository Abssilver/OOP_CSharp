using System;
using System.IO;

namespace OOP_Homework
{
    /*
    В класс банковский счет, созданный в упражнениях добавить метод, который переводит деньги с одного счета на другой.
    У метода два параметра: ссылка на объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.
    Реализовать метод, который в качестве входного параметра принимает строку string, возвращает строку типа string, 
    буквы в которой идут в обратном порядке. Протестировать метод.
    (*) Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес. 
    Разделителем между ФИО и адресом электронной почты является символ &: 
    Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru Сформировать новый файл, 
    содержащий список адресов электронной почты. Предусмотреть метод, выделяющий из строки адрес почты. 
    Методу в качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: 
    public void SearchMail (ref string s).
    */
    class Program
    {
        static void Main(string[] args)
        {
            var betterAccount = CreateSecondAccount();
            Console.WriteLine("BreakPoint");
            Console.WriteLine($"Result: {betterAccount.GetData()}");
            Console.ReadKey();

            var testString = "nice to meet you";
            Console.WriteLine(testString);
            Console.WriteLine("BreakPoint. Any key to revert");
            Console.ReadKey();
            Console.WriteLine($"Result: {StringRevertUtil.GetRevertString(testString)}");

            Console.WriteLine("Starting parser service");
            var path = Path.GetFullPath(
                Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", "TextExample.txt"));
            var parser = new TextFileParser(path, '&');
            parser.CreateEmailList("ExampleResult.txt");
            Console.WriteLine("BreakPoint. Any key to continue");
            Console.ReadKey();
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