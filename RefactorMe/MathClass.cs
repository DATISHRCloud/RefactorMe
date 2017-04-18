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
         if (type == MathsType.Type1)
         {
            var r = 0.0d;
            var s = "Starting";

            r = a + 2;
            s += "\nAdded 2 to a";
            r += b;
            s += "\nAdded b to result";
            r *= 4 - a;
            s += "\nMultiplied the result by 4 minus a";
            r /= a - .5 * b;
            s += "\nDivided the result by the difference of a and half of b";

            var rv = new KeyValuePair<string, double>(s, r);
            return rv;
         }
         else if (type == MathsType.Type2)
         {
            var r = 0.0d;
            var s = "Starting";

            r = a - b;
            s += "\nSubtracted b from a";
            r *= b;
            s += "\nMultiplied the result by b";
            r *= b;
            s += "\nMultiplied the result by b again";
            r /= 3 * a;
            s += "\nDivided the result by 3 times a";
            r -= .2 * a;
            s += "\nSubtracted one-fifth of a from the result";

            var rv = new KeyValuePair<string, double>(s, r);
            return rv;
         }
         else if (type == MathsType.Type3)
         {
            var r = 0.0d;
            var s = "Starting";

            r = a + 2;
            s += "\nAdded 2 to a";
            r += b;
            s += "\nAdded b to result";
            r *= 4 - a;
            s += "\nMultiplied the result by 4 minus a";
            r /= a - .5 * b;
            s += "\nDivided the result by the difference of a and half of b";

            var rv = new KeyValuePair<string, double>(s, r);
            return rv;
         }
         else if (type == MathsType.Type4)
         {
            var r = 0.0d;
            var s = "Starting";

            r = a + 2;
            s += "\nAdded 2 to a";
            r += b;
            s += "\nAdded b to result";
            r *= 4 - a;
            s += "\nMultiplied the result by 4 minus a";
            r /= a - .5 * b;
            s += "\nDivided the result by the difference of a and half of b";

            var rv = new KeyValuePair<string, double>(s, r);
            return rv;
         }

         return null;
      }

   }
}
