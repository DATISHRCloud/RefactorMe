using System;
using System.Collections.Generic;
using System.Text;

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
        private const string START = "Starting";

        public static KeyValuePair<string, double>? DoSomeMaths(int operandA, int operandB, MathsType type)
        {
            try
            {
                var log = new StringBuilder();
                var result = 0.0d;
                log.Append(START);

                
                switch (type)
                {
                    case MathsType.Type1:
                        return HandleType1(operandA, operandB, ref result, ref log);
                      
                    case MathsType.Type2:
                        return HandleType2(operandA, operandB, ref result, ref log);
                      
                    case MathsType.Type3:
                        return HandleType3(operandA, operandB, ref result, ref log);
                        
                    case MathsType.Type4:
                        return HandleType4(operandA, operandB, ref result, ref log);
                    default:
                        return null;
                }

                
            }
            catch (Exception)
            {

                //TODO: (In a real Project.) Perform logging here (usually ELMAH)
                throw;
            }
        }


        private static KeyValuePair<string, double> HandleType1(int operandA, int operandB, ref double result, ref StringBuilder log)
        {

            MathOperations.AddTwoToOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.RoundResultTo2Digits(ref result, ref log);

            return new KeyValuePair<string, double>(log.ToString(), result);
        }
        private static KeyValuePair<string, double> HandleType2(int operandA, int operandB, ref double result, ref StringBuilder log)
        {
            MathOperations.AddTwoToOperandA(operandA, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.RoundResultTo2Digits(ref result, ref log);


            return new KeyValuePair<string, double>(log.ToString(), result);
         
        }

        private static KeyValuePair<string, double> HandleType3(int operandA, int operandB, ref double result, ref StringBuilder log)
        {

            MathOperations.AddTwoToOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.RoundResultTo2Digits(ref result, ref log);


            return new KeyValuePair<string, double>(log.ToString(), result);
            

        }

        private static KeyValuePair<string, double> HandleType4(int operandA, int operandB, ref double result, ref StringBuilder log) 
        {

            MathOperations.AddTwoToOperandA(operandA, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.AddOperandBToResult(operandB, ref result, ref log);
            MathOperations.DivideResultBy4MinOperandA(operandA, operandB, ref result, ref log);
            MathOperations.MultResultBy4MinOperandA(operandA, ref result, ref log);
            MathOperations.RoundResultTo2Digits(ref result, ref log);


            return  new KeyValuePair<string, double>(log.ToString(), result);

        }

    }
}
