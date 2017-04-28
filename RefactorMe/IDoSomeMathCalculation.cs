using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMe
{
    public interface IDoSomeMathCalculation
    {              
        KeyValuePair<string, double>? DoSomeMaths(int a, int b);
    }

   
}
