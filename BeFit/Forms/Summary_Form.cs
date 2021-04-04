using BeFit.Classes;
using BeFit.User_Controls;
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
    public partial class Summary_Form : MetroFramework.Forms.MetroForm
    {
        private readonly List<Day_Meals> day_meals;
        private int mealsCount = 0;
        private const int SplitterDistance = 52;
        private const int Form_MaxHeight = 940;
        private const int SummaryControlHeight = 150;
        public Summary_Form(List<Day_Meals> daymeals)
        {
            InitializeComponent();
            day_meals = daymeals;
            InitializeComboBoxItems();
            MainContainer.Panel2.Hide();

        }

        private void InitializeComboBoxItems()
        {
            for (int i = 1; i <= 30; i++)
            {
                BalancePeroid_Combobox.Items.Add(i);
            }
            BalancePeroid_Combobox.SelectedIndex = 0;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            this.MainContainer.Panel2.Controls.Clear();
            var secondlist = day_meals.Where(x => x.Date.Date >
            DateTime.Now.AddDays(-Convert.ToDouble(BalancePeroid_Combobox.Text))
            && x.Date.Date != DateTime.Now.Date);
            if (secondlist.Count() == 0)
            {
                new GiveUserInfo_Form(false, "Nie znaleziono żadnego bilansu na podstawie wprowadzonego okresu czasu");
            }
            else
            {
                secondlist = secondlist.OrderByDescending(x => x.Date);
                mealsCount = 0;

                foreach (Day_Meals _daymeal in secondlist)
                {
                    MainContainer.Panel2.Show();
                    Summary_Control control = new Summary_Control(_daymeal);

                    control.Location = new Point(15, 10 + (mealsCount * SummaryControlHeight) +
                        (mealsCount * 10));

                    this.MainContainer.Panel2.Controls.Add(control);

                    mealsCount++;

                }
                if (mealsCount > 5)
                {

                    this.Height = Form_MaxHeight;
                }
                else
                {
                    this.Height = 140 + (mealsCount * SummaryControlHeight) + (mealsCount * 10);
                    this.MainContainer.Panel2.AutoScroll = true;
                }
                this.MainContainer.SplitterDistance = SplitterDistance;
            }

        }

        private void BalancePeroid_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BalancePeroid_Combobox.SelectedIndex == 0)
            {
                DaysStatic_Label.Text = "ostatniego dnia";
            }
            else
            {
                DaysStatic_Label.Text = "ostatnich dni";
            }
        }
    }
}
