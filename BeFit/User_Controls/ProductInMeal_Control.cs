using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeFit.Classes;

namespace BeFit.User_Controls
{
    public partial class ProductInMeal_Control : UserControl
    {
        public Product_Mass Product { get; set; }
        public ProductInMeal_Control(Product_Mass product)
        {
            InitializeComponent();
            Product = product;
            ToolTip.SetToolTip(this.NameLabel, Product.Product.Name);
            NameLabel.Text = Product.Product.Name;
            KcalValue_Label.Text = Convert.ToString(Math.Round(Product.Product.Total_kcal_per_100 * (Product.Mass / 100), 1)) + " kcal";
            FatValue_Label.Text = Convert.ToString(Math.Round(Product.Product.Fat_Total * (Product.Mass / 100), 1)) + " g";
            ProteinValue_Label.Text = Convert.ToString(Math.Round(Product.Product.Protein * (Product.Mass / 100), 1)) + " g";
            CarboValue_Label.Text = Convert.ToString(Math.Round(Product.Product.Carbohydrates * (Product.Mass / 100), 1)) + " g";
            Weight_Label.Text = Product.Mass.ToString() + " g | ml";
            try
            {
                ProductPicture.Image = Image.FromFile(ReturnProjectDirectory.GetProductImagePath(Product.Product.Name));
            }
            catch
            {
                ProductPicture.Image = Properties.Resources.default_meal;
            }
        }



        private void RemoveProduct_Button_Click(object sender, EventArgs e)
        {
            // this.Dispose();
        }
    }
}
