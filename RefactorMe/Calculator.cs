using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactorMe
{
    public class Calculator
    {
        private readonly IDoSomeMathCalculation _doSomeMathCalculation;

        public Calculator(IDoSomeMathCalculation doSomeMathCalculation) {
           this._doSomeMathCalculation = doSomeMathCalculation;
        }

        public KeyValuePair<string, double>? Calculate(int a, int b) {
           return _doSomeMathCalculation.DoSomeMaths(a,b);
        }

    }
}
