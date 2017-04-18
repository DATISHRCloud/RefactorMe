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
         var testResult = MathClass.DoSomeMaths(a, b, MathsType.Type1);

         //Assert
         Assert.Equal(expected.Key, testResult.Value.Key);
         Assert.Equal(expected.Value, testResult.Value.Value);
      }
      [Fact]
      public void TestMathsType2()
      {
         //Arrange
         var a = 2;
         var b = 9;
         var s = "Starting\nAdded 2 to a\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nMultiplied the result by 4 minus a\nDivided the result by the difference of a and half of b\nAdded b to result\nRounded to 2 decimals";
         var r = 4.36;
         KeyValuePair<string, double> expected = new KeyValuePair<string, double>(s, r);

         //Act
         var testResult = MathClass.DoSomeMaths(a, b, MathsType.Type2);

         //Assert
         Assert.Equal(expected.Key, testResult.Value.Key);
         Assert.Equal(expected.Value, testResult.Value.Value);
      }
      [Fact]
      public void TestMathsType3()
      {
         //Arrange
         var a = 7;
         var b = 13;
         var s = "Starting\nAdded 2 to a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nRounded to 2 decimals";
         var r = 26107;
         KeyValuePair<string, double> expected = new KeyValuePair<string, double>(s, r);

         //Act
         var testResult = MathClass.DoSomeMaths(a, b, MathsType.Type3);

         //Assert
         Assert.Equal(expected.Key, testResult.Value.Key);
         Assert.Equal(expected.Value, testResult.Value.Value);
      }
      [Fact]
      public void TestMathsType4()
      {
         //Arrange
         var a = 11;
         var b = 2;
         var s = "Starting\nAdded 2 to a\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nAdded b to result\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nAdded b to result\nDivided the result by the difference of a and half of b\nAdded b to result\nAdded b to result\nDivided the result by the difference of a and half of b\nMultiplied the result by 4 minus a\nRounded to 2 decimals";
         var r = -3.2;
         KeyValuePair<string, double> expected = new KeyValuePair<string, double>(s, r);

         //Act
         var testResult = MathClass.DoSomeMaths(a, b, MathsType.Type4);
         Console.WriteLine("Test 4");
         Console.WriteLine(testResult.Value.Key);
         Console.WriteLine(testResult.Value.Value);

         //Assert
         Assert.Equal(expected.Key, testResult.Value.Key);
         Assert.Equal(expected.Value, testResult.Value.Value);
      }
   }
}
