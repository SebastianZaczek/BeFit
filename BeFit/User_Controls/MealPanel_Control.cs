using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit.User_Controls
{
    public partial class MealPanel_Control : MetroFramework.Controls.MetroUserControl
    {
        private bool IsCollapsed;
        private double _TotalKcal;

        private double TotalKcal
        {
            set
            {
                _TotalKcal = value;
                ChangeTotalKcal();
            }

            get => _TotalKcal;
        }

        private void ChangeTotalKcal()
        {
            KcalTotal_Label.Text = TotalKcal.ToString() + "kcal";
        }
        [Browsable(false)]
        public bool ISCollapsed
        {
            get => IsCollapsed;

            set
            {
                ExpandPanel();
            }
        }
        private const int SplitterDistance = 45;
        private int ProductCount { get; set; }
        public MealPanel_Control(string name)
        {

            InitializeComponent();
            TotalKcal = 0;
            Title_Label.Text = name;
            IsCollapsed = false;
            ProductCount = 0;
            ExpandPanel();  // is collapsed na true automatycznie
            this.Height = 46;
        }
        public MealPanel_Control()
        {
            InitializeComponent();
            IsCollapsed = false;
            ProductCount = 0;
            ExpandPanel();  // is collapsed na true automatycznie
            this.Height = 46;
        }
        public void AddProductToMealControl(ProductInMeal_Control meal)
        {

            meal.Location = new Point(0, ((ProductCount) * 130));

            ProductCount++;
            this.Height = 48 + (130 * ProductCount);
            this.SplitContainer.SplitterDistance = SplitterDistance;


            this.SplitContainer.Panel2.Controls.Add(meal);

            TotalKcal += meal.Product.Mass * meal.Product.Product.Total_kcal_per_100 / 100;
            meal.RemoveProduct_Button.Click += new EventHandler(RemovePanel);
        }

        private void RemovePanel(object sender, EventArgs e)
        {
            ProductCount = 0;
            TotalKcal = 0;
            List<ProductInMeal_Control> meals = new List<ProductInMeal_Control>();
            foreach (ProductInMeal_Control todaymeal in this.SplitContainer.Panel2.Controls)
            {
                meals.Add(todaymeal);
            }
            this.SplitContainer.Panel2.Controls.Clear();
            foreach (ProductInMeal_Control todaymeal in meals)
            {
                AddProductToMealControl(todaymeal);
            }
        }

        private void Expand_Button_Click(object sender, EventArgs e)
        {
            ExpandPanel();

        }
        public void ExpandPanel()
        {
            if (IsCollapsed == false)
            {

                SplitContainer.Panel2.Hide();
                IsCollapsed = true;
                Expand_Button.Text = "Rozwiń";
            }
            else
            {
                if (ProductCount != 0)
                {
                    SplitContainer.Panel2.Show();
                }
                IsCollapsed = false;
                Expand_Button.Text = "Zwiń";
            }
        }
    }
}
