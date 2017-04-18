using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RefactorMe.Tests
{
    [TestClass]
    public class MathsTests
    {
        [TestMethod]
        public void TestMathsType1()
        {
         //Arrange
         var a = 7;
         var b = 3;
         KeyValuePair<string, double> expected;

         //Act
         var testResult = MathClass.DoSomeMaths(7, 3, MathsType.Type1);

         //Assert
         Assert.AreEqual(testResult.Value.Key, expected.Key, "Keys not equal!");
         Assert.AreEqual(testResult.Value.Value, expected.Value, "Values not equal!");
      }
    }
}
