using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator|");
            Console.WriteLine();
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("Summation Function Result");

            b.sum(20, 10);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Subtraction Function Result");
           
            b.sub(20, 10);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Multiplication Function Result");
           
            b.multiplication(20, 10);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Division Function Result");
          
            b.division(20, 10);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scientific Calculator Interface ");
            Console.WriteLine();
            SciCal s = new SciCal();
            Console.WriteLine();
            Console.WriteLine("Division Function Result");
            Console.WriteLine();
            s.division(20, 10);
            Console.WriteLine("Factorial Function Result");
            Console.WriteLine();
            s.factorial(10);
            Console.WriteLine();
            Console.WriteLine("X to Y Function Result");
            Console.WriteLine();
            s.XtoY(100, 500);

        }
    }
}