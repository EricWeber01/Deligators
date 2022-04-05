using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deligators
{
    class CreditCard
    {
        string FIO = "Owner_Ownerowich";
        int pin, cash, creditCash;
        bool credit = false;
        DateTime date;
        int max_cash;
        public CreditCard(int _pin, int _credit, DateTime _date)
        {
            pin = _pin;
            creditCash = _credit;
            date = _date;
        }
        public void AddCash(int money)
        {
            cash += money;
        }
        public void Withdraw(int money)
        {
            if (money > cash)
            {
                if (credit)
                {
                    money -= cash;
                    cash = 0;
                    creditCash -= money;
                }
                else
                    Console.WriteLine("Недостаточно средств");
            }
        }
        public void ChangePin(int _pin)
        {
            Console.WriteLine("Пин код успешно изменен");
            pin = _pin;
        }
        public void MaxCash(int _max_cash)
        {
            max_cash = _max_cash;
            Console.WriteLine($"Для достижения заданной суммы осталось: {max_cash - cash}uah.");
        }
        public void StartCredit()
        {
            credit = true;
        }
        public void CheckMax()
        {
            if (max_cash != 0)
                Console.WriteLine($"Для достижения заданной суммы осталось: {max_cash - cash}uah.");
            else if (cash > max_cash)
                Console.WriteLine("Вы достигли суммы накопления");
            else
                Console.WriteLine("Сумма накопления не задана");
        }
        public void Show()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(FIO);
            Console.WriteLine($"Ballance {cash}");
            Console.WriteLine($"Credit Ballance {creditCash}");
            Console.WriteLine($"Valid: {date.ToLongDateString()}");
            if (credit)
                Console.WriteLine("Credit Ballanse is active");
            else
                Console.WriteLine("Credit Ballanse is not active");
            Console.WriteLine("----------------------------------");
        }
    }
    public delegate void Card(int m);
    public delegate void CardWithoutArg();
    class Bank : CreditCard
    {
        Card[] c;
        CardWithoutArg[] cw;
        public Bank(int _pin, int _credit, DateTime _date) : base(_pin, _credit, _date)
        {
            c = new Card[4] { base.AddCash, base.Withdraw, base.ChangePin, base.MaxCash };
            cw = new CardWithoutArg[3] { base.Show, base.StartCredit, base.CheckMax };
        }
        public void Interface(int ind, int n)
        {
            c[ind](n);
        }
        public void Interface(int ind)
        {
            cw[ind]();
        }
    }
}
