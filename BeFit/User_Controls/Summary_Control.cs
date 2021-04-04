using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeFit;
using ProgressBarSample;
using BeFit.Classes;

namespace BeFit.User_Controls
{
    public partial class Summary_Control : UserControl
    {
        public Summary_Control(Day_Meals daymeal)
        {
            InitializeComponent();
            OwnInitializeCompomponents(daymeal);
        }

        private void OwnInitializeCompomponents(Day_Meals daymeal)
        {
            KcalDemand_Label.Text = Math.Round(daymeal.CaloricDemand, 1).ToString() + " kcal";
            FatDemand_Label.Text = Math.Round(daymeal.FatDemand, 1).ToString() + " g";
            CarboDemand_Label.Text = Math.Round(daymeal.CarboDemand, 1).ToString() + " g";
            ProteinDemand_Label.Text = Math.Round(daymeal.ProteinDemand, 1).ToString() + " g";
            double kcal = 0, fat = 0, carbo = 0, protein = 0;
            foreach (Meal meal in daymeal.Meals)
            {
                foreach (Product_Mass product in meal.Products)
                {
                    kcal += product.Product.Total_kcal_per_100 * (product.Mass / 100);
                    fat += product.Product.Fat_Total * (product.Mass / 100);
                    carbo += product.Product.Carbohydrates * (product.Mass / 100);
                    protein += product.Product.Protein * (product.Mass / 100);
                }
            }
            KcalEaten_Label.Text = Math.Round(kcal, 1).ToString() + " kcal";
            FatEaten_Label.Text = Math.Round(fat, 1).ToString() + " g";
            CarboEaten_Label.Text = Math.Round(carbo, 1).ToString() + " g";
            ProteinEaten_Label.Text = Math.Round(protein, 1).ToString() + " g";

            double accuracy = ((AccuracyAbs.ReturnDiffrence(kcal / (daymeal.CaloricDemand / 100))) +
                (AccuracyAbs.ReturnDiffrence(fat / (daymeal.FatDemand / 100))) +
                (AccuracyAbs.ReturnDiffrence(carbo / (daymeal.CarboDemand / 100))) +
                 (AccuracyAbs.ReturnDiffrence(protein / (daymeal.ProteinDemand / 100)))) / 4;

            Accuracy_TextProgressBar.CustomText = daymeal.Date.Date.ToShortDateString() + " | " + ((int)accuracy).ToString() + " %";
            Accuracy_TextProgressBar.ProgressColor = ReturnColorProgress.ReturnColor(accuracy);
            Accuracy_TextProgressBar.Value = (int)accuracy;
        }
    }
}
