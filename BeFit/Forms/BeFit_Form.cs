using BeFit.Classes;
using BeFit.Model;
using BeFit.User_Controls;
using MetroFramework.Controls;

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
    public partial class BeFit_Form : MetroFramework.Forms.MetroForm
    {
        public Profile ActiveProfile;
        public List<Product_Category> List_Category = new List<Product_Category>();
        private int MealsCount = 0;
        private bool _IsChangedProfile = false;
        private bool _ExistMeals = false;
        protected bool ExistMeals
        {
            get
            {
                return _ExistMeals;
            }
            set
            {
                _ExistMeals = value;
                if (_ExistMeals) // jesli istnieja posilki
                {

                    SearchDisabled_Picturebox.Visible = false;
                    SearchProduct_Button.Enabled = true;
                    if (SearchProduct_Button.Tile_Image == null)
                    {
                        SearchProduct_Button.Tile_Image = Properties.Resources.search_icon1;
                    }
                }
                else // jesli nie ma posilkow
                {
                    SearchDisabled_Tooltip.SetToolTip(this.SearchDisabled_Picturebox, "  Dodaj posiłek przed dodaniem do niego produktów  ");
                    SearchDisabled_Picturebox.Location = new Point(120, 90);
                    SearchProduct_Button.Enabled = false;
                    SearchDisabled_Picturebox.Visible = true;
                }

            }
        }
        protected bool IsChangedProfile
        {
            get
            {
                return _IsChangedProfile;
            }
            set
            {
                _IsChangedProfile = value;
                UpdateSaveIcon();
            }
        }

        private void UpdateSaveIcon()
        {
            if (!IsChangedProfile)
            {
                SaveProfile_Button.Tile_Image = Properties.Resources.ok;

            }
            else
            {
                SaveProfile_Button.Tile_Image = Properties.Resources.save_icon;
            }
            SaveProfile_Button.Refresh();
        }


        public BeFit_Form(Profile profile)
        {
            InitializeComponent();
            ActiveProfile = profile;

            LoadCategories();
            ProfileName_Label.Text = "Profil: " + ActiveProfile.Name;
            CheckTodaysMeal();
            RefreshControlsMeal();
            SummarizeToday();
            profile.SaveProfileToJson();
            this.Icon = Properties.Resources.form_icon;


        }

        private void RefreshControlsMeal()
        {
            splitContainer3.Panel2.Controls.Clear();

            MealsCount = 0;
            int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
            // int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today); 
            foreach (Meal meal in ActiveProfile.List_Of_meals[index].Meals)
            {
                MealPanel_Control p = new MealPanel_Control(meal.MealName);
                foreach (Product_Mass product in meal.Products)
                {
                    ProductInMeal_Control t = new ProductInMeal_Control(product);
                    p.AddProductToMealControl(t);
                    t.RemoveProduct_Button.Click += new EventHandler(RemoveControlMeal);

                }
                p.Location = new Point(50, 15 + (MealsCount * 47));
                MealsCount++;
                splitContainer3.Panel2.Controls.Add(p);
                p.BringToFront();
                p.Expand_Button.Click += new EventHandler(ExpandMeal);
            }
        }

        private void RemoveControlMeal(object sender, EventArgs e)
        {
            GiveUserInfo_Form form = new GiveUserInfo_Form("Czy chcesz usunąć '" + (((sender as MetroButton).Parent as ProductInMeal_Control).Product.Product.Name) +
                "'?");
            if (form.DialogResult == DialogResult.OK)
            {
                // index -> znalezienie dzisiejszego daymeala
                //  int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today);
                int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
                //index2 - > znalezienie meala po nazwie w dzisiejszym daymealu
                int index2 = ActiveProfile.List_Of_meals[index].Meals.FindIndex(x => x.MealName ==
               ((sender as MetroButton).Parent.Parent.Parent.Parent as MealPanel_Control).Title_Label.Text);
                //index3 -> znalezienie produktu ktory ma byc usuniety
                int index3 = ActiveProfile.List_Of_meals[index].Meals[index2].Products.FindIndex(x => x ==
                ((sender as MetroButton).Parent as ProductInMeal_Control).Product);
                // finito
                ActiveProfile.List_Of_meals[index].Meals[index2].Products.RemoveAt(index3);
                //refreszo
                RefreshControlsMeal();
                SummarizeToday();
                IsChangedProfile = true;
            }

        }

        private void SummarizeToday()
        {
            int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
            // int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today); 
            Day_Meals day_meal = ActiveProfile.List_Of_meals[index];
            double KCAL = 0, Fat = 0, Carbo = 0, Protein = 0, Sugar = 0, FatSaturated = 0;
            foreach (Meal meal in day_meal.Meals)
            {
                foreach (Product_Mass product in meal.Products)
                {
                    KCAL += product.Product.Total_kcal_per_100 * (product.Mass / 100);
                    Fat += product.Product.Fat_Total * (product.Mass / 100);
                    Carbo += product.Product.Carbohydrates * (product.Mass / 100);
                    Protein += product.Product.Protein * (product.Mass / 100);
                    Sugar += (double)product.Product.Carbo_Sugar * (product.Mass / 100);
                    FatSaturated += (double)product.Product.Fat_Saturated * (product.Mass / 100);
                }
            }

            Kcal_Progressbar.ChangeControlValue(KCAL, day_meal.CaloricDemand, "kcal");
            FatProgressBar.ChangeControlValue(Fat, day_meal.FatDemand, "g");
            Protein_ProgressBar.ChangeControlValue(Protein, day_meal.ProteinDemand, "g");
            Carbo_Progressbar.ChangeControlValue(Carbo, day_meal.CarboDemand, "g");
            double accuracy = ((AccuracyAbs.ReturnDiffrence(KCAL / (day_meal.CaloricDemand / 100))) +
            (AccuracyAbs.ReturnDiffrence(Fat / (day_meal.FatDemand / 100))) +
            (AccuracyAbs.ReturnDiffrence(Carbo / (day_meal.CarboDemand / 100))) +
            (AccuracyAbs.ReturnDiffrence(Protein / (day_meal.ProteinDemand / 100)))) / 4;

            AvarageAccuracy_ProgressBar.ChangeControlValue_Accuracy(accuracy);
            TodayFatSat_Label.Text = Math.Round(FatSaturated, 1).ToString() + " g";
            TodayCarboSugar_Label.Text = Math.Round(Sugar, 1).ToString() + " g";
        }

        private void ExpandMeal(object sender, EventArgs e)
        {
            MealPanel_Control prevPanel = new MealPanel_Control();

            bool IsSearched = false;
            bool IsSearchedFirst = false;
            List<MealPanel_Control> list = new List<MealPanel_Control>();
            foreach (MealPanel_Control mp in splitContainer3.Panel2.Controls)
            {
                list.Add(mp);
            }
            IEnumerable<MealPanel_Control> panels = list.OrderBy(panel => panel.Top); // sortowanie wedlug polozenia
            list = panels.ToList();

            foreach (MealPanel_Control mp in list)
            {
                if ((sender as MetroButton).Parent.Parent.Parent == mp)
                { // znaleziony klikniety panel
                    prevPanel = mp;
                    IsSearched = true;
                    int index = list.IndexOf(mp) + 1;
                    if (index < list.Count) // jesli nie jest to ostatni panel
                    {
                        if (mp.ISCollapsed)
                        {
                            list[index].Top = mp.Top + 47;
                        }
                        else
                        {
                            list[index].Top = mp.Bottom;
                        }
                        prevPanel = list[index];
                        IsSearchedFirst = true;
                        continue;
                    }
                    else
                        continue;

                }
                if (IsSearchedFirst)   // pominiecie pierwszego panelu
                {
                    IsSearchedFirst = false;
                    continue;
                }
                if (IsSearched)  //reszta paneli 
                {
                    if (prevPanel.ISCollapsed)
                    {
                        mp.Top = prevPanel.Top + 47;

                    }
                    else
                    {
                        mp.Top = prevPanel.Bottom;
                    }
                    mp.BringToFront();
                    prevPanel = mp;

                }
            }
        }

        private void LoadCategories()
        {
            using (DB_Model db = new DB_Model())
            {
                List_Category = db.Product_Category
                    .ToList();
            }
        }


        public void test_method()
        {
            Product_Category cat = new Product_Category();
            using (DB_Model db = new DB_Model())
            {

                cat = db.Product_Category
                   .Where(x => x.Id == 1)
                   .FirstOrDefault();

                MessageBox.Show(cat.Name);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddProductToDataBase_Form form = new AddProductToDataBase_Form(List_Category);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                new GiveUserInfo_Form(false, "Pomyślnie dodano produkt do bazy");
            }
        }

        private void SearchProduct_Button_Click(object sender, EventArgs e)
        {
            //int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today);
            int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
            Search_Product_Form form = new Search_Product_Form(List_Category, ActiveProfile.List_Of_meals[index].Meals);
            form.ShowDialog();

            if (form.IsFinished)
            {
                ActiveProfile.List_Of_meals[index].Meals[form.IndexMeal].AddProductMass(form.Product_mass);
                SummarizeToday();
                RefreshControlsMeal();
                IsChangedProfile = true;
            }

        }

        private void AddMeal_Button_Click(object sender, EventArgs e)
        {
            //argument dla formy -> ilość dzisiejszych zapisanych posiłków
            AddNewMeal_Form form =
                new AddNewMeal_Form(ActiveProfile.List_Of_meals[List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals)].Meals.Count);
            form.ShowDialog();
            if (form.IsValid)
            {
                //walidajca -> posilek nie moze sie tak samo nazywac
                // int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today);
                int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
                if (!ActiveProfile.List_Of_meals[index].Meals.Exists(x => x.MealName == form.MealName))
                {
                    ActiveProfile.List_Of_meals[index].Meals.Add(new Meal(form.MealName));

                    RefreshControlsMeal();
                    ExistMeals = true;
                    IsChangedProfile = true;
                }
                else
                {
                    new GiveUserInfo_Form(true, "Nazwy posiłków nie mogą się powtarzać");
                }
            }


        }
        private void CheckTodaysMeal()
        {
            // int index = ActiveProfile.List_Of_meals.FindIndex(x => x.Date.Date == DateTime.Today); 
            int index = List_Indexator.ReturnTodaysMealIndex(ActiveProfile.List_Of_meals);
            Day_Meals meal;
            // jesli nie znaleziono dzisiejszego zapotrzebowania
            if (index == -1)
            {

                AddDayMealDemands_Form form = new AddDayMealDemands_Form(ActiveProfile.List_Of_meals);
                while (form.DialogResult != DialogResult.OK)
                {
                    form.ShowDialog();
                }
                ExistMeals = false;
                meal = form.DayMeal;
                ActiveProfile.List_Of_meals.Add(meal);
                IsChangedProfile = true;
            }
            else
            {
                //jesli w dzisiejszym daymealu znajduja sie posilki

                if (ActiveProfile.List_Of_meals[index].Meals.Count != 0)
                {
                    ExistMeals = true;
                }
                else
                {
                    ExistMeals = false;
                }

                meal = ActiveProfile.List_Of_meals[index];
                IsChangedProfile = false;

            }

            KcalValue_Label.Text = meal.CaloricDemand.ToString() + " kcal";
            FatValue_Label.Text = "  " + Math.Round(meal.FatDemand, 1).ToString() + "g";
            CarboValue_Label.Text = "  " + Math.Round(meal.CarboDemand).ToString() + "g";
            ProteinValue_Label.Text = "  " + Math.Round(meal.ProteinDemand).ToString() + "g";

        }

        private void SaveProfile_Button_Click(object sender, EventArgs e)
        {
            ActiveProfile.SaveProfileToJson();
            IsChangedProfile = false;
        }

        private void Summary_Button_Click(object sender, EventArgs e)
        {
            Summary_Form form = new Summary_Form(ActiveProfile.List_Of_meals);
            form.ShowDialog();
        }

        private void BeFit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsChangedProfile)
            {
                GiveUserInfo_Form form = new GiveUserInfo_Form("Czy chcesz zapisać profil przed wyjściem?");
                if (form.DialogResult == DialogResult.OK)
                {
                    InvokeOnClick(SaveProfile_Button, EventArgs.Empty);
                }

            }
            Application.Exit();
        }


    }
}
