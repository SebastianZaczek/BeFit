using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeFit.Model;
using System.IO;
using BeFit.Classes;
using System.Data.Entity;

namespace BeFit.User_Controls
{
    public partial class SearchedProducts_Control : UserControl
    {
        private bool _IsValidWeight { get; set; }
        public bool IsValidWeight { get => _IsValidWeight; private set => _IsValidWeight = value; }
        public Product Product { get; set; }
        public Product_Mass Product_Mass { get; set; }
        public SearchedProducts_Control(Product product)
        {
            InitializeComponent();
            Product = product;
            _IsValidWeight = false;
            OwnInitializeComponents();
        }

        private void OwnInitializeComponents()
        {
            try
            {
                picturebox.Image = Image.FromFile(ReturnProjectDirectory.GetProductImagePath(Product.Name));
            }
            catch
            {
                picturebox.Image = Properties.Resources.default_meal;
            }
            NameLabel.Text = Product.Name;
            KcalLabel.Text = Product.Total_kcal_per_100.ToString() + "kcal na 100(g|ml)";
            Tip_Label.Text = Product.Tip;

            ToolTip.SetToolTip(this.NameLabel, Product.Name);
            ToolTip.SetToolTip(this.Tip_Label, Product.Tip);
            ToolTip.SetToolTip(this.KcalLabel, Product.Total_kcal_per_100 + " kcal" + Environment.NewLine
                + Product.Fat_Total + "g tłuszczu" + Environment.NewLine +
                Product.Carbohydrates + "g węglowodanów" + Environment.NewLine +
                Product.Protein + "g białka");

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Weight_TextBox.Text != "")
            {
                double weight = Convert.ToDouble(Weight_TextBox.Text);
                Product_Mass = new Product_Mass(Product, weight);
                IsValidWeight = true;
            }



        }

        private void Weight_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


    }
}
