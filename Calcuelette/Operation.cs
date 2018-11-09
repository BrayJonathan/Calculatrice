using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuelette
{
    class Operation
    {
        public double Addition(double number1, double number2)
        {
            //ajout commentaire test push modif
            return number1 + number2;
        }

        public double Substraction(double number1, double number2)
        {
            //ajout commentaire de la part de Amine lol
            return number1 - number2;
        }

        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Division(double number1, double number2)
        {
            try
            {
                if(number2 == 0)
                {
                    throw new DivideByZeroException("Division par zéro impossible");
                }
                return number1 / number2;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
