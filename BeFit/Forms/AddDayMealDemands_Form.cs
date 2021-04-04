using BeFit.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit.Forms
{
    public partial class AddDayMealDemands_Form : MetroFramework.Forms.MetroForm
    {
        public Day_Meals DayMeal { get; set; }
        public List<Day_Meals> ListOfDayMeals { get; set; }
        public AddDayMealDemands_Form(List<Day_Meals> list)
        {
            InitializeComponent();
            ListOfDayMeals = list;
            if (ListOfDayMeals.Count == 0)
            {
                LoadLastDemands.Enabled = false;
            }
            AddEventHandlers();
        }
        private void AddEventHandlers()
        {
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeFatGramLabel);
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeCarboGramLabel);
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeProteinGramLabel);
            FatDemand_Textbox.TextChanged += new EventHandler(ChangeFatGramLabel);
            CarboDemand_Textbox.TextChanged += new EventHandler(ChangeCarboGramLabel);
            ProteinDemand_Textbox.TextChanged += new EventHandler(ChangeProteinGramLabel);
        }
        private void ChangeFatGramLabel(object sender, EventArgs e)
        {
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double fat = Convert.ToDouble(FatDemand_Textbox.Text);
            FatGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * fat / 9), 1).ToString() + "g";
        }
        private void ChangeCarboGramLabel(object sender, EventArgs e)
        {
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double carbo = Convert.ToDouble(CarboDemand_Textbox.Text);
            CarboGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * carbo / 4), 1).ToString() + "g";
        }
        private void ChangeProteinGramLabel(object sender, EventArgs e)
        {
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double protein = Convert.ToDouble(ProteinDemand_Textbox.Text);
            ProteinGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * protein / 4), 1).ToString() + "g";
        }

        private void CheckNullValuesForKcal(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
                (sender as TextBox).SelectionStart = 0;
                (sender as TextBox).SelectionLength = (sender as TextBox).Text.Length;
            }

        }
        private void AddProfile_Button_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Percent_Label.Text) != 0)
            {
                new GiveUserInfo_Form(true, "Wprowadź prawidłowy procentowy rozkład makroskładników");
            }
            else
            {

                double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
                DayMeal = new Day_Meals(kcal,
                             kcal / 100 * Convert.ToDouble(FatDemand_Textbox.Text) / 9, kcal / 100 * Convert.ToDouble(CarboDemand_Textbox.Text) / 4,
                             kcal / 100 * Convert.ToDouble(ProteinDemand_Textbox.Text) / 4);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        public void AcceptOnlyIntNumber(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void CheckNullValues(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = "0";
                (sender as TextBox).SelectionStart = 0;
                (sender as TextBox).SelectionLength = (sender as TextBox).Text.Length;
            }
            else CheckPercentValues(sender, e);
        }
        private void CheckPercentValues(object sender, EventArgs e)
        {
            if (Convert.ToInt32((sender as TextBox).Text) > 100)
                (sender as TextBox).Text = "0";
            UpdatePercentLeftValue();

        }
        private void UpdatePercentLeftValue()
        {
            int PercentLeft = Convert.ToInt32(Percent_Label.Text);
            PercentLeft = 100 - Convert.ToInt32(FatDemand_Textbox.Text)
                - Convert.ToInt32(CarboDemand_Textbox.Text) - Convert.ToInt32(ProteinDemand_Textbox.Text);
            Percent_Label.Text = PercentLeft.ToString();
        }

        private void LoadLastDemands_Click(object sender, EventArgs e)
        {

            ListOfDayMeals.Sort((x, y) => x.Date.CompareTo(y.Date)); //sprawdzic czy przesylane listy sa posortowane
            Day_Meals p = ListOfDayMeals[ListOfDayMeals.Count - 1];
            DayMeal = new Day_Meals(p.CaloricDemand, p.FatDemand, p.CarboDemand, p.ProteinDemand);
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void Percent_Label_TextChanged(object sender, EventArgs e)
        {
            if (this.Percent_Label.Text == "0")
            {
                this.Percent_Label.ForeColor = Color.Green;
            }
            else
            {
                this.Percent_Label.ForeColor = Color.Red;
            }
        }
    }
}
