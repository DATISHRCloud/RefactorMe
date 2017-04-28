using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMe
{
    class Type3 :  Type
    {
        public override KeyValuePair<string, double>? DoSomeMaths(int a, int b)
        {
            var item = base.DoSomeMaths(a, b);
            //var item = Type.Added2toA(a, 2, "");
            item = Type.AddBToResult(item.Value.Value, b, item.Value.Key);
            item = Type.DividedResultbyDiffAndHalfofB(item.Value.Value, a, b, item.Value.Key);
            item = Type.Multipliedtheresultby4SubtA(item.Value.Value, a, item.Value.Key);
            item = Type.AddBToResult(item.Value.Value, b, item.Value.Key);
            item = Type.DividedResultbyDiffAndHalfofB(item.Value.Value, a, b, item.Value.Key);
            item = Type.Multipliedtheresultby4SubtA(item.Value.Value, a, item.Value.Key);
            item = Type.AddBToResult(item.Value.Value, b, item.Value.Key);
            item = Type.DividedResultbyDiffAndHalfofB(item.Value.Value, a, b, item.Value.Key);
            item = Type.Multipliedtheresultby4SubtA(item.Value.Value, a, item.Value.Key);
            item = Type.AddBToResult(item.Value.Value, b, item.Value.Key);
            item = Type.DividedResultbyDiffAndHalfofB(item.Value.Value, a, b, item.Value.Key);
            item = Type.Multipliedtheresultby4SubtA(item.Value.Value, a, item.Value.Key);
            item = Type.AddBToResult(item.Value.Value, b, item.Value.Key);

            return Type.Round2Decimal(item.Value.Value, item.Value.Key);
                        
        }
    }
}
