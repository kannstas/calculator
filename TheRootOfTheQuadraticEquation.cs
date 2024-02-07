using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public class TheRootOfTheQuadraticEquation
    {
        int firstRoot = 0;
        int secondRoot = 0;
        int flag = 0;

        public (int flag, int firstRoot, int secondRoot) CalculateRootsOfTheQuadraticEquation
         (int coefficientA, int coefficientB, int coefficientC)

        {
            int discriminant = (coefficientB * coefficientB) - 4 * coefficientA * coefficientC;


            if (discriminant < 0 || coefficientA < 0)
            {

                return (-1, 0, 0);
            }
            else if (discriminant == 0)
            {
                firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
                return (0, firstRoot, firstRoot);
            }

            else

            {
                firstRoot = (int)(((-1) * coefficientB) + Math.Sqrt(discriminant)) / 2 * coefficientA;
                secondRoot = (int)(((-1) * coefficientB) - Math.Sqrt(discriminant)) / 2 * coefficientA;

                return (1, firstRoot, secondRoot);

            }

        }



    }

}