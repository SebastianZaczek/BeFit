using BeFit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BeFit.Forms
{
    public partial class AddProductToDataBase_Form : MetroFramework.Forms.MetroForm
    {
        private readonly List<Product_Category> List_Category = new List<Product_Category>();
        private Image ProductImage;
        public AddProductToDataBase_Form(List<Product_Category> list_Category)
        {
            InitializeComponent();
            List_Category = list_Category;
            AddCategoriesToComboBox();
            SetToolTips();
        }

        private void SetToolTips()
        {
            ToolTip.SetToolTip(this.Tooltip1_label, "Pole opcjonalne");
            ToolTip.SetToolTip(this.Tooltip2_label, "Pole opcjonalne");
            ToolTip.SetToolTip(this.Tooltip3_Tip_label, "  Pole opcjonalne. Maksymalnie 30 znaków.  ");
            ToolTip.SetToolTip(this.Tooltip4_Picture_label, "  Pole opcjonalne. Dodany obraz zmieni rozmiar do 75x75 px  ");
        }

        private void AddCategoriesToComboBox()
        {
            foreach (Product_Category p in List_Category)
            {
                Category_Combobox.Items.Add(p.Name);

            }
            Category_Combobox.SelectedIndex = 0;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FatSat_Textbox.Text == "")
                    FatSat_Textbox.Text = "0";
                if (CarboSugar_Textbox.Text == "")
                    CarboSugar_Textbox.Text = "0";
                var category = List_Category.Find(x => x.Name == (Category_Combobox.SelectedItem.ToString()));
                var product = new Product()
                {
                    Name = Name_Textbox.Text,
                    Total_kcal_per_100 = Double.Parse(Kcal_Textbox.Text, CultureInfo.InvariantCulture),
                    Fat_Total = Double.Parse(Fat_Textbox.Text, CultureInfo.InvariantCulture),
                    Fat_Saturated = Double.Parse(FatSat_Textbox.Text, CultureInfo.InvariantCulture),
                    Carbohydrates = Double.Parse(Carbo_Textbox.Text, CultureInfo.InvariantCulture),
                    Carbo_Sugar = Double.Parse(CarboSugar_Textbox.Text, CultureInfo.InvariantCulture),
                    Protein = Double.Parse(Protein_Textbox.Text, CultureInfo.InvariantCulture),
                    Tip = Tip_Textbox.Text,
                    Id_Category = category.Id
                };

                if (ProductImage != null)
                {
                    SaveImageToFile(product.Name);
                }
                AddRecordToDataBase(product);
            }
            catch (Exception ex)
            {
                new GiveUserInfo_Form(true, "Wypełnij wymagane pola.");
                MessageBox.Show(ex.ToString());
            }

        }

        private void AddRecordToDataBase(Product product)
        {
            using (DB_Model db = new DB_Model())
            {
                db.Product.Add(product);
                db.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveImageToFile(string product_name)
        {

            string path = Application.StartupPath + @"\Product_Images\" + product_name + ".jpeg";

            Product_Picturebox.Image.Save(path, ImageFormat.Jpeg);
        }

        private void Kcal_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            AcceptFloatNumbers(sender, e);

        }
        private void AcceptFloatNumbers(object sender, KeyPressEventArgs e)
        {
            // jesli nie jest digit ani control ani '.'
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.') // jesli jest '.' sprawdza czy nie ma drugiego takiego samego znaku
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                {
                    e.Handled = true;
                }
            }
        }
        private void Fat_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptFloatNumbers(sender, e);
        }

        private void FatSat_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptFloatNumbers(sender, e);
        }

        private void Carbo_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptFloatNumbers(sender, e);
        }

        private void CarboSugar_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptFloatNumbers(sender, e);
        }

        private void Protein_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AcceptFloatNumbers(sender, e);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog_Image.ShowDialog() == DialogResult.OK)
            {
                ProductImage = new Bitmap(OpenFileDialog_Image.FileName);
                Bitmap btm = new Bitmap(ProductImage, new Size(75, 75));
                Product_Picturebox.Image = btm;
                RemovePicture_Button.Visible = true;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ilewazy.pl/");
        }

        private void Help_Link2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kalkulatorkalorii.net/kalkulator-kalorii");
        }

        private void RemovePicture_Button_Click(object sender, EventArgs e)
        {
            this.RemovePicture_Button.Visible = false;
            Product_Picturebox.Image = null;
        }
    }
}
