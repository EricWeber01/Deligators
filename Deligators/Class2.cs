using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deligators
{
    public delegate void CallMethods();
    public class Methods
    {
        CallMethods[] cm;
        public void Time() => Console.WriteLine(DateTime.Now.ToLongTimeString());
        public void Date() => Console.WriteLine(DateTime.Now.ToLongDateString());
        public void Day() => Console.WriteLine(DateTime.Now.DayOfWeek);
        public void Triangle()
        {
            int a, h;
            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter H:");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine($"S Triangle: {0.5 * a * h}");
        }
        public void Rectangle()
        {
            int a, b;
            Console.WriteLine("Enter A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"S Rectangle: {a * b}");
        }
        public void Call()
        {
            cm = new CallMethods[5] { Time, Date, Day, Triangle, Rectangle };
            foreach (var item in cm)
            {
                Console.WriteLine();
                item();
            }
        }
    }
}
