using System;
using System.Collections.Generic;

namespace RefactorMe
{
    public enum MathsType
    {
        Type1,
        Type2,
        Type3,
        Type4
    }


    public static class MathClass
    {
        public static KeyValuePair<string, double>? DoSomeMaths(int a, int b, MathsType type)
        {
            Calculator calculator = null;
            if (type is MathsType.Type1) 
                calculator = new Calculator(new Type1());
            else if (type is MathsType.Type2)
                calculator = new Calculator(new Type2());
            else if (type is MathsType.Type3)
                calculator = new Calculator(new Type3());
            else if (type is MathsType.Type4)
                calculator = new Calculator(new Type4());
                        
            return calculator.Calculate(a,b,type);
        }

    }
}
