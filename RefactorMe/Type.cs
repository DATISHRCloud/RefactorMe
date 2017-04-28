using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMe
{
    public class Type : IDoSomeMathCalculation
    {
        public virtual KeyValuePair<string, double>? DoSomeMaths(int a, int b)
        {      
            
            return Added2toA(a,2, "");
        }

        protected static KeyValuePair<string, double>? Round2Decimal(double r,string s)
        {
            r = Math.Round(r,2);
            s += "\nRounded to 2 decimals";
            return new KeyValuePair<string, double>(s, r);

        }


        protected static KeyValuePair<string, double>? Added2toA(double a, double _const, string value)
        {
            var r = 0.0d;
            var s = "Starting";
            r = a + 2;
            s += "\nAdded 2 to a";
          
            return new KeyValuePair<string, double>(s, r);

        }



        protected static KeyValuePair<string, double>? AddBToResult(double r, double b, string s)
        {
            r += b;
            s += "\nAdded b to result";
            return new KeyValuePair<string, double>(s, r);
            
        }


        protected static KeyValuePair<string, double>? Multipliedtheresultby4SubtA(double r, double a, string s)
        {

            r *= 4 - a;
            s += "\nMultiplied the result by 4 minus a";

            return new KeyValuePair<string, double>(s, r);
        }


        protected static KeyValuePair<string, double>? DividedResultbyDiffAndHalfofB(double r, double a, double b, string s)
        {
            r /= a - .5 * b;
            s += "\nDivided the result by the difference of a and half of b";
           
            return new KeyValuePair<string, double>(s, r);


        }
    }
}
