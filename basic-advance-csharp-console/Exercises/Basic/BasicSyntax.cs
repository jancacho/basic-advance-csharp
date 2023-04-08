using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_advance_csharp_console.Exercises.Basic
{
    public class BasicSyntax
    {
        int sampleInt = 2;
        string sampleString = "THIS IS VARIABLE STRING";
        double sampleDouble = 25.254;
        bool sampleBoolean = true;
        


        public void ViewResult()
        {

            Console.WriteLine("THIS IS SAMPLE OF DATA TYPE INT IN METHOD: " + SampleInt());
            Console.WriteLine("THIS IS SAMPLE OF DATA TYPE INT IN VARIABLE: " + sampleInt);
            Console.WriteLine(StringAppendLine());
            Console.WriteLine("THIS IS SAMPLE OF STRING BUILDER METHOD: " + SampleStringBuilder());
            Console.WriteLine("THIS IS SAMPLE OF STRING IN VARIABLE: " + sampleString);
            Console.WriteLine(StringAppendLine());
            Console.WriteLine("THIS SAMPLE OF DOUBLE METHOD WITH SIMPLE LOGIC: " + SampleDouble()) ;
            Console.WriteLine("THIS SAMPLE OF DOUBLE IN VARIABLE: " + sampleDouble);
            Console.WriteLine(StringAppendLine());
            Console.WriteLine("THIS IS SAMPLE OF BOOLEAN METHOD: " + SampleBoolean());
            Console.WriteLine("THIS IS SAMPLE OF BOOLEAN IN VARIABLE: " + sampleBoolean);
            Console.WriteLine(StringAppendLine());

            Console.ReadKey();

        }



        private int SampleInt()
        {
            return 1;
        }

        private string SampleStringBuilder()
        {
            var sb = new StringBuilder();

            sb.Append(">>>>THIS IS STRING BUILDER SAMPLE");
            return sb.ToString();
        }


        private string StringAppendLine()
        {
            var sb = new StringBuilder();

            sb.AppendLine("");

            return sb.ToString();

        }

        private double SampleDouble()
        {
            double one;
            double two;
            float three;

            one = 1.25;
            two = 2;
            three = 10564f;
        
            return one + two +  three;
        }


        private bool SampleBoolean()
        {
            return false;
        }

    }
}
