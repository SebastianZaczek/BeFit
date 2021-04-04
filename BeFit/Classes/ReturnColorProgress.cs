using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit.Classes
{
    public static class ReturnColorProgress
    {
        public static MetroColorStyle ReturnMetroColor(double progress)
        {
            switch (progress)
            {
                case var x when (x < 30) || (x > 170):
                    {

                        return MetroColorStyle.Red;

                    }
                case var x when (x >= 30 && x < 60) || (x >= 140 && x < 170):
                    {
                        return MetroColorStyle.Orange;

                    }
                case var x when (x >= 60 && x < 90) || (x >= 110 && x < 140):
                    {
                        return MetroColorStyle.Yellow;

                    }
                case var x when x >= 90 && x < 110:
                    {
                        return MetroColorStyle.Green;

                    }
                default:
                    {
                        return MetroColorStyle.White;
                    }

            }

        }
        public static Color ReturnColor(double progress)
        {
            switch (progress)
            {
                case var x when (x < 30) || (x > 170):
                    {

                        return Color.Red;

                    }
                case var x when (x >= 30 && x < 60) || (x >= 140 && x < 170):
                    {
                        return Color.Orange;

                    }
                case var x when (x >= 60 && x < 90) || (x >= 110 && x < 140):
                    {
                        return Color.Yellow;

                    }
                case var x when x >= 90 && x < 110:
                    {
                        return Color.Green;

                    }
                default:
                    {
                        return Color.White;
                    }

            }
        }
    }
}
