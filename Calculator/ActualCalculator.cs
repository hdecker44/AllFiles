using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ActualCalculator
    {
        public double AddTwoNumbers(double doubleAddOne, double doubleAddTwo)
        {
            return doubleAddOne + doubleAddTwo;
        }
        public double SubtractTwoNumbers(double doubleSubOne, double doubleSubTwo)
        {
            return doubleSubOne - doubleSubTwo;
        }
        public double MultiplyTwoNumbers(double doubleMultiplyOne, double doubleMultiplyTwo)
        {
            return doubleMultiplyOne * doubleMultiplyTwo;
        }
        public double DivideTwoNumbers(double doubleDivideOne, double doubleDivideTwo)
        {
            return doubleDivideOne / doubleDivideTwo;
        }
    }
}
