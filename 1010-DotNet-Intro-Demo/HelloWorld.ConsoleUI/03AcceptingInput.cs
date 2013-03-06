using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProgram.AcceptingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?: ");

            string name = Console.ReadLine();

            Console.Write("Hello " + name);

            Console.ReadLine();

        }
    }
}