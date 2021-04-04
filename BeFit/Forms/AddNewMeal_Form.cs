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
    public partial class AddNewMeal_Form : MetroFramework.Forms.MetroForm
    {
        public string MealName;
        public bool IsValid { get; set; } = false;
        public AddNewMeal_Form(int meals_count)
        {
            InitializeComponent();
            meals_count++;
            MealName_Textbox.Text = "Posiłek nr. " + meals_count.ToString();
            MealName_Textbox.SelectAll();
        }

        private void AddNewMeal_Button_Click(object sender, EventArgs e)
        {
            MealName = MealName_Textbox.Text;
            IsValid = true;
            this.Close();
        }
    }
}
