using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Operation
    {
        public double Multiple(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double Devide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Cannot divide by 0");
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
        //minus operation
        public double Minus(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //add operation
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
