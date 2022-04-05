using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deligators
{
    public delegate void ArrAct();
    class Array
    {
        int[] arr;
        ArrAct[] ac;
        public Array(int size)
        {
            arr = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = rand.Next(20);
        }
        public void IsOdd()
        {
            Console.WriteLine("\nЧетные");
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                    Console.Write(item + " ");
            }
        }
        public void IsNotOdd()
        {
            Console.WriteLine("\nНечетные");
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                    Console.Write(item + " ");
            }
        }
        public void IsSimple()
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                bool check = true;
                for (int i = 2; i <= item / 2; i++)
                {
                    if (item % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    Console.WriteLine("Число простоe " + item);
                else
                    Console.WriteLine("Число не простое " + item);
            }
        }
        public void IsFibonacci()
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                double X1 = 5 * Math.Pow(item, 2) + 4;
                double X2 = 5 * Math.Pow(item, 2) - 4;
                long X1_sqrt = (long)Math.Sqrt(X1);
                long X2_sqrt = (long)Math.Sqrt(X2);
                if ((X1_sqrt * X1_sqrt == X1) || (X2_sqrt * X2_sqrt == X2))
                    Console.WriteLine("Число Фибоначчи " + item);
                else
                    Console.WriteLine("Не является числом Фибоначчи " + item);
            }
        }
        public void CheckArray()
        {
            ac = new ArrAct[4] { IsOdd, IsNotOdd, IsSimple, IsFibonacci };
            foreach (var item in ac)
            {
                item();
            }
        }
    }
}
