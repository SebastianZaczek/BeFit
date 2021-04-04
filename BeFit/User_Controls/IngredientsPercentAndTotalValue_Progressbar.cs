using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using BeFit.Classes;

namespace BeFit.User_Controls
{
    public partial class IngredientsPercentAndTotalValue_Progressbar : UserControl
    {
        public IngredientsPercentAndTotalValue_Progressbar()
        {
            InitializeComponent();
        }


        public void ChangeControlValue_Accuracy(double accuracy)
        {
            accuracy = AccuracyAbs.ReturnDiffrence(accuracy);
            this.PercentValue_ProgressBar.Style = ReturnColorProgress.ReturnMetroColor(accuracy);

            this.GramValue_Label.Text = "";
            this.OverHunder_Label.Text = ((int)accuracy).ToString() + "%";
            if (accuracy > 100)  // cap na value progress bar
            {
                accuracy = 100;
            }
            else if (accuracy < 0)
            {
                accuracy = 100;
            }
            this.PercentValue_ProgressBar.Value = (int)accuracy;
        }

        public void ChangeControlValue(double value, double gramsdemand, string suffix)
        {
            double percents = value / (gramsdemand / 100);

            this.PercentValue_ProgressBar.Style = ReturnColorProgress.ReturnMetroColor(percents);


            if (percents > 100)
            {
                this.PercentValue_ProgressBar.Value = 100;
            }
            else
            {
                this.PercentValue_ProgressBar.Value = (int)percents;
            }
            this.GramValue_Label.Text = Math.Round(value, 1).ToString() + " " + suffix;
            this.OverHunder_Label.Text = ((int)percents).ToString() + "%";




        }
    }
}
