using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For
            /*
            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            //While
            /*
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            */

            //Console.WriteLine("Finished!");
            //Console.WriteLine("Now number is {0}", number);

            //Do While
            /*
           
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
            */

            string[] students = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
