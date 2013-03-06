///Instructions
///1. Walk through the code
///2. Compile with csc
///3. Press f5 and demonstrate that console window closes
///4. Add a break point and debug
///5. Add Console.ReadLine() and re-execute

// Imported Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Namespace Declaration
namespace MyFirstProgram
{
    // Class Name
    class Program
    {
        //In a console app, Main is executed
        static void Main(string[] args)
        {
            //write to the console
            Console.WriteLine("Hello World");

            //wait for a response
            Console.ReadLine();

        }
    }
}


