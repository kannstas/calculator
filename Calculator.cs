using System.Reflection;

namespace Calculator
{


    using System;
    using System.Windows.Forms;
    using System.Numerics;


    public class CalcEngine : Form1
    {
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            eGrade = 5,
            eSquareRoot = 6,
            eSquareOfNumber = 7,
            eFactorial = 8,
            eReverse = 9,
            eCubicRoot = 10

        }

        private static Form1 form1;
        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }


        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer = stringAnswer + ".";
                else
                    stringAnswer = "0.";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called when = is pressed.
        //

        public static double Calculate(double firstNumber, double secondNumber, int calcOperation)
        {

            switch (calcOperation)
            {
                case (int)Operator.eUnknown:
                    break;

                case (int)Operator.eAdd:
                    numericAnswer = firstNumber + secondNumber;

                    break;

                case (int)Operator.eSubtract:
                    numericAnswer = firstNumber - secondNumber;

                    break;

                case (int)Operator.eMultiply:
                    numericAnswer = firstNumber * secondNumber;

                    break;

                case (int)Operator.eDivide:
                    numericAnswer = firstNumber / secondNumber;
                    break;

                case (int)Operator.eGrade:
                    numericAnswer = Math.Pow(firstNumber, secondNumber);
                    break;



                default:

                    break;
            }

            return numericAnswer;
        }

        public static double Calculate(double number, int calcOperation)
        {
            switch (calcOperation)
            {
                case (int)Operator.eSquareRoot:
                    numericAnswer = Math.Sqrt(number);
                    break;

                case (int)Operator.eSquareOfNumber:
                    numericAnswer = number * number;
                    break;

                case (int)Operator.eFactorial:
                    var factorial = new BigInteger(1);
                    for (int i = 1; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    return (double)factorial;

                case (int)Operator.eReverse:
                    numericAnswer = Math.Pow(number, -1);
                    break;

                case (int)Operator.eCubicRoot:
                    numericAnswer = Math.Pow(number, 1.0 / 3.0);
                    break;
            }
            return numericAnswer;
        }




        //
        // Resets the various module-level variables for the next calculation.
        //

        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = "";
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }
    }
}