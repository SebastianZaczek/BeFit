using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeFit.Classes
{
    public static class CalculateDemandInGrams
    {
        public static double[] CaltulateIngredients(double kcal, double fat, double carbo, double protein)
        {
            double[] tab = new double[3];
            tab[0] = Math.Round(kcal / 100 * fat / 9);
            tab[1] = Math.Round(kcal / 100 * carbo / 4);
            tab[2] = Math.Round(kcal / 100 * protein / 4);
            return tab;

        }
    }
}
