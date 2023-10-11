using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_info
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter your name\n ");
            string name = Console.ReadLine();

            Console.WriteLine(" When you were born " + name);
            int year = int.Parse(Console.ReadLine());

            int age = 2023 - year;

            Console.WriteLine();
            Console.WriteLine(" You are " + age + " years old ");
            Console.ReadLine();


        }
    }
}
