using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface_1
{
    class basiccalculatorinterface
    {
        int sum(int x, int y);
        int sub(int x, int y);
        int multiplication(int x, int y);
        int division(int x, int y);
    }
    class Basiccalc : Basiccalculatorinterface
    {
        int result;
        public int sum(int number1, int number2)
        {
            Console.WriteLine("Summation : " + number1 + " With : " + number2);
            result = number1 + number2;
            return result;
        }
        public int sub(int number1, int number2)
        {
            Console.WriteLine("Subtraction : " + number1 + " By : " + number2);
            result = number1 - number2;
            return result;
        }
        public int multiplication(int number1, int number2)
        {
            Console.WriteLine("Multiplication : " + number1 + " With : " + number2);
            result = number1 * number2;
            return result;
        }
        public int division(int number1, int number2)
        {
            Console.WriteLine("Divident : " + number1 + " & Divisor : " + number2);
            result = number1 / number2;
            return result;
        }
        public void printStates()
        {
            Console.WriteLine("Result : " + result);
        }
    }
}