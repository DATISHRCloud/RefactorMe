using System;
using Xunit;
using System.Collections.Generic;

namespace RefactorMe
{
   public class MathClassTests
   {
      [Fact]
      public void TestMathsType1()
      {
         //Arrange
         var a = 7;
         var b = 3;
         var s = "Starting\nAdded 2 to a\nAdded b to result\nMultiplied the result by 4 minus a\nDivided the result by the difference of a and half of b\nRounded to 2 decimals";
         var r = -6.55;
         KeyValuePair<string, double> expected = new KeyValuePair<string, double>(s, r);

         //Act
         var testResult = MathClass.DoSomeMaths(7, 3, MathsType.Type1);
         Console.WriteLine(testResult.Value.Key);
         Console.WriteLine(testResult.Value.Value);

         //Assert
         Assert.Equal(testResult.Value.Key, expected.Key);
         Assert.Equal(testResult.Value.Value, expected.Value);
      }
   }
}
