using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMe
{
    public class Type1 :  Type
    {
        public override KeyValuePair<string, double>? DoSomeMaths(int a, int b)           
        {
            
            var result = base.DoSomeMaths(a, b);           
            result =  Type.AddBToResult(result.Value.Value, b, result.Value.Key);
            result = Type.Multipliedtheresultby4SubtA(result.Value.Value, a, result.Value.Key);
            result = Type.DividedResultbyDiffAndHalfofB(result.Value.Value, a, b, result.Value.Key);
            
            return Type.Round2Decimal(result.Value.Value, result.Value.Key);
            
        }
    }
}
