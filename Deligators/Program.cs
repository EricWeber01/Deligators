using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligators
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------
            static void GoodM(int h)
            {
                Console.WriteLine($"Доброе утро , сейчас {h} часов");
            }
            static void GoodD(int h)
            {
                Console.WriteLine($"Добрый день , сейчас {h} часов");
            }
            static void GoodE(int h)
            {
                Console.WriteLine($"Добрый вечер , сейчас {h} часов");
            }
        public delegate void Hello(int h);
        //---------------------------------------------------------------------
        static int Sum(int x, int y) => x + y;
        static int Min(int x, int y) => x - y;
        static int Mult(int x, int y) => x * y;
        static int Div(int x, int y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException();
        }
        public delegate int Action(int x, int y);
        static void Calculator(int x, int y, Action a)
        {
            int? res = a?.Invoke(x, y);
            Console.WriteLine($"{x} ({a.Method.Name}) {y} = {res ?? 0}");
        }
        //---------------------------------------------------------------------
        static void IsOdd(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("Четное");
            else
                Console.WriteLine("Нечетное");
        }
        static void IsSimple(int num)
        {
            bool check = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Число просто");
            else
                Console.WriteLine("Число не простое");
        }
        static void IsFibonacci(int x)
        {
            double X1 = 5 * Math.Pow(x, 2) + 4;
            double X2 = 5 * Math.Pow(x, 2) - 4;
            long X1_sqrt = (long)Math.Sqrt(X1);
            long X2_sqrt = (long)Math.Sqrt(X2);
            if ((X1_sqrt * X1_sqrt == X1) || (X2_sqrt * X2_sqrt == X2))
                Console.WriteLine("Число Фибоначчи");
            else
                Console.WriteLine("Не является числом Фибоначчи");
        }
        public delegate void CheckNum(int num);
        static void Main(string[] args)
        {
            /*Hello hello;
            int hour = DateTime.Now.Hour;
            if (hour > 3 && hour < 12)
                hello = GoodM;
            else
                hello = GoodD;
            hello(hour);*/
            /*Calculator(10, 5, Sum);
            Calculator(10, 5, Min);
            Calculator(10, 5, Mult);
            Calculator(10, 5, Div);
            Calculator(10, 0, null);*/
            /*CheckNum[] ch = { IsOdd, IsSimple, IsFibonacci };
            foreach (var item in ch)
                item(11);*/
            /*Array a = new Array(10);
            a.CheckArray();*/
            /*Methods m = new Methods();
            m.Call();*/
            Bank b = new Bank(1111, 5000, new DateTime(2025, 5, 15));
            b.Interface(0, 1500);
            b.Interface(3, 2000);
            b.Interface(1, 2000);
            b.Interface(1);
            b.Interface(1, 2000);
            b.Interface(0);
        }
    }
}