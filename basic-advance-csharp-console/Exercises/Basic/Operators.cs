using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_advance_csharp_console.Exercises.Basic
{
    public class Operators
    {

        double _a, _b, _c;


        public Operators(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public void ViewResult()
        {
            Console.WriteLine("THE VALUE OF FIRST NUMBER IS: " + _a + " AND THE VALUE OF SECOND NUMBER IS: " + _b);
            Console.WriteLine("THIS IS SAMPLE OF ADDITION LOGIC. THE RESULT OF FIRST NUMBER(" + _a + ") PLUS SECOND NUMBER(" + _b + ") IS: " + SampleAddition(_a, _b));
            Console.WriteLine("THIS IS SAMPLE OF SUBTRACTION LOGIC. THE RESULT OF FIRST NUMBER(" + _a + ") MINUS SECOND NUMBER(" + _b + ") IS: " + SampleSubtraction(_a, _b));
            Console.WriteLine("THIS IS SAMPLE OF MULTIPLICATION LOGIC. THE RESULT OF FIRST NUMBER(" + _a + ") TIMES SECOND NUMBER(" + _b + ") IS: " + SampleMultiplication(_a, _b));
            Console.WriteLine("THIS IS SAMPLE OF DIVIDE LOGIC. THE RESULT OF FIRST NUMBER(" + _a + ") DIVIDE SECOND NUMBER(" + _b + ") IS: " + SampleDivide(_a, _b));
           
        }

        public double SamplePublicDivide(double a, double c)
        {
            return a / c; 
        }

       
        private double SampleAddition(double a, double b)
        {
            return a + b;
        }

        private double SampleSubtraction(double a, double b)
        {
            return a - b;
        }

        private double SampleMultiplication(double a, double b)
        {
            return a * b; 
        }

        private double SampleDivide(double a, double b)
        {

            return a / b;


        }

    }
}
