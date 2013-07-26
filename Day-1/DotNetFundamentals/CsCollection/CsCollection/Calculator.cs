using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsCollection
{
    public class Calculator
    {
        public int Add(int number1, int number2)
        {
            Console.WriteLine("Calculator.Add invoked");
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            Console.WriteLine("Calculator.Subtract invoked");
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            Console.WriteLine("Calculator.Multiply invoked");
            return number1*number2;
        }
        public int Divide(int number1, int number2)
        {
            Console.WriteLine("Calculator.Divide invoked");
            return number1/number2;
        }
    }
}

