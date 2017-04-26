using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorMe
{
    /// <summary>
    /// Purpose: Perform math operations on Operands A, B, and result. Also log the operations details.
    /// </summary>
    public static class MathOperations
    {

        private const string START = "Starting";
        private const string ADD2_A = "\nAdded 2 to a";
        private const string ADD_B = "\nAdded b to result";
        private const string MULT_4_MIN_A = "\nMultiplied the result by 4 minus a";
        private const string DIV_A_MIN_HALF_B = "\nDivided the result by the difference of a and half of b";
        private const string ROUND_2_DIGIT = "\nRounded to 2 decimals";



        /// <summary>
        /// Add 2 to operand A
        /// </summary>
        /// <param name="operandA">operand A</param>
        /// <param name="result">current result</param>
        /// <param name="log">log containing operation details</param>
        public static void AddTwoToOperandA(int operandA, ref double result, ref StringBuilder log)
        {

            result = operandA + 2;
            log.Append(ADD2_A);
        }


        /// <summary>
        /// Add Operand B to Result
        /// </summary>
        /// <param name="operandB">operand B</param>
        /// <param name="result">current result</param>
        /// <param name="log">log containing operation details</param>
        public static void AddOperandBToResult(int operandB, ref double result, ref StringBuilder log)
        {

            result += operandB;
            log.Append(ADD_B);
        }


        /// <summary>
        /// Multiply the result by 4 minus operand A
        /// </summary>
        /// <param name="operandA">operand A</param>
        /// <param name="result">current result</param>
        /// <param name="log">log containing operation details</param>
        public static void MultResultBy4MinOperandA(int operandA, ref double result, ref StringBuilder log)
        {
            result *= 4 - operandA;
            log.Append(MULT_4_MIN_A);
          
        }


        /// <summary>
        /// Divide Result by four minus operand A
        /// </summary>
        /// <param name="operandA">operand A</param>
        /// <param name="operandB">operand B</param>
        /// <param name="result">current result</param>
        /// <param name="log">log containing operation details</param>
        public static void DivideResultBy4MinOperandA(int operandA,int operandB, ref double result, ref StringBuilder log)
        {

            //TODO: exception handling reminder
            //TODO: maybe able to rewrite this statment for clarity
           
            try
            {
                result /= operandA - .5 * operandB;
                log.Append(DIV_A_MIN_HALF_B);
            }
            catch (Exception)
            {
                //TODO: (In real Project.) Perform logging here (usually ELMAH)
                //TODO: possible divide by zero
                throw;
            }
        }


        /// <summary>
        /// Round the result to Digits
        /// </summary>
        /// <param name="result">current result</param>
        /// <param name="log">log containing operation details</param>
        public static void RoundResultTo2Digits(ref double result, ref StringBuilder log)
        {

            result = Math.Round(result, 2);
            log.Append(ROUND_2_DIGIT);

        }




    }
}
