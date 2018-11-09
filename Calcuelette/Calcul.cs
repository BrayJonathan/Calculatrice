using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcuelette
{
    class Calcul
    {
        public double Calcule(string completeCalculString)
        {
            int cpt = 0;
            double resultTemp = 0;
            List<double> numbers = new List<double>();
            List<string> NumbersAndDelimsList = completeCalculString.SplitAndKeepForPlusAndMinus(new char[] {'+','-','*','/'});

            while (cpt < NumbersAndDelimsList.Count)
            {
                if (cpt == 0)
                {
                    double number1 = Convert.ToDouble(NumbersAndDelimsList[cpt]);
                    double number2 = Convert.ToDouble(NumbersAndDelimsList[cpt + 2]);
                    resultTemp = TestOperantorAndExecuteCalcul(NumbersAndDelimsList[cpt + 1], number1, number2);
                    cpt += 3;
                }
                else
                {
                    double number2 = Convert.ToDouble(NumbersAndDelimsList[cpt + 1]);
                    resultTemp = TestOperantorAndExecuteCalcul(NumbersAndDelimsList[cpt], resultTemp, number2);
                    cpt += 2;
                }
            }
            return resultTemp;
        }


        private double TestOperantorAndExecuteCalcul(string mathOperator, double number1, double number2)
        {
            double result = 0;
            Operation op = new Operation();
            switch (mathOperator)
            {
                case "+":
                    result = op.Addition(number1,  number2);
                    break;
                case "-":
                    result = op.Substraction(number1, number2);
                    break;
                case "*":
                    result = op.Multiplication(number1, number2);
                    break;
                case "/":
                    result = op.Division(number1, number2);
                    break;
            }
            return result;
        }
    }
}
