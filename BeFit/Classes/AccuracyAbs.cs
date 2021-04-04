using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public static class AccuracyAbs
    {
        //wartosc bezwzgledna miedzy precyzja a liczba 100
        //dla 70 = 70
        //dla 130 = 70 
        public static double ReturnDiffrence(double mainvalue)
        {
            if (mainvalue > 100)
            {
                return 100 - (mainvalue - 100);
            }
            else
            {
                return mainvalue;
            }

        }
    }
}
