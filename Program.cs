using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            // date input
            int y, m, d;
            Console.Write("Enter the day you were born: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month you were born: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the year you were born: ");
            y = Convert.ToInt32(Console.ReadLine());
            // definition of the day
            DateTime dateValue = new DateTime(y, m, d);
            // output
            Console.WriteLine("The day of the week when you were born was: {0}!", dateValue.ToString("dddd"));

            Console.ReadLine();
        }
    }
}