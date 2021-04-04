using BeFit.Classes;
using BeFit.Model;
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
using MetroFramework.Controls;
using System.Data.Entity;

namespace BeFit.Forms
{
    public partial class Search_Product_Form : MetroFramework.Forms.MetroForm
    {
        public bool IsFinished = false;
        public int IndexMeal { get; set; }
        private int DisplayedProducts = 0;

        public Product_Mass Product_mass;
        public List<Meal> Meals;
        public Search_Product_Form(List<Product_Category> categories, List<Meal> meals)
        {
            Meals = meals;
            InitializeComponent();
            Category_Combobox.Items.Add("Wszystkie");
            Category_Combobox.SelectedIndex = 0;
            foreach (Product_Category cat in categories)
            {
                Category_Combobox.Items.Add(cat.Name);
            }
            foreach (Meal meal in meals)
            {
                Meal_ComboBox.Items.Add(meal.MealName);
            }
            Meal_ComboBox.SelectedIndex = meals.Count - 1;
            Category_Combobox.SelectedIndex = 0;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();

            DisplayedProducts = 0;
            List<Product> products = new List<Product>();
            if (Category_Combobox.Text == "Wszystkie")
            {
                products = SearchProductsWithoutCategory();
            }
            else
            {
                products = SearchProductsWitCategory(Category_Combobox.Text);
            }

            foreach (Product p in products)
            {
                SearchedProducts_Control s = new SearchedProducts_Control(p);

                s.Location = new Point(20, (s.Size.Height * DisplayedProducts) + 10);
                splitContainer1.Panel2.Controls.Add(s);


                DisplayedProducts++;
                s.AddButton.Click += new EventHandler(AddProductToProfile);
                s.RemoveFromDB_Button.Click += new EventHandler(RemoveProductFromDB);

            }


        }

        private void RemoveProductFromDB(object sender, EventArgs e)
        {
            Product product = ((sender as MetroButton).Parent as SearchedProducts_Control).Product;
            GiveUserInfo_Form form = new GiveUserInfo_Form("Czy chcesz trwale usunąć element '" + product.Name
                + "' z bazy?");
            if (form.DialogResult == DialogResult.OK)
            {
                using (var db = new DB_Model())
                {
                    db.Entry(product).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                splitContainer1.Panel2.Controls.Clear();

            }
        }

        private void AddProductToProfile(object sender, EventArgs e)
        {

            if (((sender as Button).Parent as SearchedProducts_Control).IsValidWeight) // walidacja textboxa z waga
            {
                Product_mass = ((sender as Button).Parent as SearchedProducts_Control).Product_Mass;
                IndexMeal = Meals.FindIndex(x => x.MealName == Meal_ComboBox.Text);
                IsFinished = true;
                this.Close();
            }
            else
            {
                new GiveUserInfo_Form(true, "Wprowadzono nieprawidłową masę produktu");

            }
        }

        private List<Product> SearchProductsWitCategory(string category)
        {
            using (DB_Model db = new DB_Model())
            {
                var products = db.Product
                    .Where(x => x.Name.ToLower().Contains(Product_Textbox.Text.ToLower()) &&
                    x.Product_Category.Name == category)  //dorobic walidacje nulla

                    .ToList();
                if (products.Count == 0)
                {
                    NoProductFound();
                }
                return products;
            }

        }

        private List<Product> SearchProductsWithoutCategory()
        {
            using (DB_Model db = new DB_Model())
            {
                var products = db.Product
                    .Where(x => x.Name.ToLower().Contains(Product_Textbox.Text.ToLower()))  //dorobic walidacje nulla
                    .ToList();
                if (products.Count == 0)
                {
                    NoProductFound();
                }
                return products;
            }

        }
        private void NoProductFound()
        {
            new GiveUserInfo_Form(false, "Nie znaleziono produktów na podstawie wprowadzonej nazwy bądź kategorii");
        }

        private void Product_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)  //event wcisniecia buttona szukajacego produktu po nacisnieciu enter
            {
                e.Handled = true;
                Search_Button_Click(this, EventArgs.Empty);
            }
        }
    }
}
