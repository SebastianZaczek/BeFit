using BeFit.Classes;
using BeFit.Forms;
using BeFit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit
{
    public partial class StartBeFit : MetroFramework.Forms.MetroForm
    {
        private string[] Files { get; set; }

        public StartBeFit()
        {
            InitializeComponent();
            Files = GetProfilesNames();
            OwnInitializeComponents();
            AddEventHandlers();
        }

        private void OwnInitializeComponents()
        {
            Profiles_ListBox.BackColor = this.BackColor;
            FontFamily fontfamily = new FontFamily("Arial");
            Profiles_ListBox.Font = new Font(fontfamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);

            this.Size = new Size(170, 430);
            foreach (string file in Files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
                Profiles_ListBox.Items.Add(filename);
            }
            ConfirmLoad_Button.Location = new Point(227, 360);
            Profiles_ListBox.Location = new Point(170, 65);
            this.Icon = Properties.Resources.form_icon;
            this.Tooltip.SetToolTip(Tooltip_Picturebox, "Wprowadź procentowy podział makroskładników." + Environment.NewLine +
                "   Podział opiera się na kaloryczności nie na gramaturze. Kaloryczność w przybliżeniu:   " + Environment.NewLine +
                "Tłuszcze: 9 kcal | 1g" + Environment.NewLine +
                "Węglowodany 4 kcal | 1g" + Environment.NewLine +
                "Białko 4 kcal | 1g");
        }

        private void AddEventHandlers()
        {
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeFatGramLabel);
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeCarboGramLabel);
            CaloricDemand_Textbox.TextChanged += new EventHandler(ChangeProteinGramLabel);
            FatDemand_Textbox.TextChanged += new EventHandler(ChangeFatGramLabel);
            CarboDemand_Textbox.TextChanged += new EventHandler(ChangeCarboGramLabel);
            ProteinDemand_Textbox.TextChanged += new EventHandler(ChangeProteinGramLabel);
            ChangeCarboGramLabel(this, EventArgs.Empty);
            ChangeFatGramLabel(this, EventArgs.Empty);
            ChangeProteinGramLabel(this, EventArgs.Empty);
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (Files.Count() == 0)
            {
                new GiveUserInfo_Form(true, "Nie znaleziono lokalnych zapisów profilu.");
            }
            else
            {
                ConfirmLoad_Button.Visible = true;
                Profiles_ListBox.Visible = true;
                NewProfile_Panel.Visible = false;
                this.Size = new Size(380, 430);
            }
        }

        private void NewProfile_Button_Click(object sender, EventArgs e)
        {
            Profiles_ListBox.Visible = false;
            ConfirmLoad_Button.Visible = false;
            NewProfile_Panel.Visible = true;
            this.Size = new Size(380, 430);
        }

        private void AddProfile_Button_Click(object sender, EventArgs e)
        {
            bool IsNameValid = true;
            string[] files = GetProfilesNames();
            string pom;
            string name = ProfileName_TextBox.Text;
            if (name.Length < 3)
            {
                new GiveUserInfo_Form(true, "Nazwa powinna składać się przynajmniej z 3 znaków");

            }
            else if (Convert.ToInt32(Percent_Label.Text) != 0)
            {
                new GiveUserInfo_Form(true, "Wprowadź prawidłowy procentowy rozkład makroskładników");
            }

            else
            {
                foreach (string s in files) // sprawdza czy nie ma takiej nazwy profilu
                {
                    pom = Path.GetFileNameWithoutExtension(s);
                    if (name == pom)
                    {
                        IsNameValid = false;
                        new GiveUserInfo_Form(true, "Wprowadzona nazwa profilu już istnieje");
                        break;

                    }
                }
                if (IsNameValid == true)
                {
                    double[] tab = CalculateDemandInGrams.CaltulateIngredients(Convert.ToDouble(CaloricDemand_Textbox.Text), Convert.ToDouble(FatDemand_Textbox.Text),
                    Convert.ToDouble(CarboDemand_Textbox.Text), Convert.ToDouble(ProteinDemand_Textbox.Text));
                    Day_Meals DayMeal = new Day_Meals(Convert.ToDouble(CaloricDemand_Textbox.Text), tab[0], tab[1], tab[2]);
                    Profile profile = new Profile(name);
                    profile.List_Of_meals.Add(DayMeal);
                    BeFit_Form form = new BeFit_Form(profile);
                    form.Show();
                    this.Close();
                }
            }
        }
        private string[] GetProfilesNames()
        {

            string path = ReturnProjectDirectory.GetProfilesPath();

            string[] files = Directory.GetFiles(path, "*json");

            return files;
        }

        private void ConfirmLoad_Button_Click(object sender, EventArgs e)
        {
            if (Profiles_ListBox.SelectedItems.Count != 0)
            {
                Profile profile = new Profile(Profiles_ListBox.SelectedItems[0].Text);
                profile.LoadProfileFromJson();
                BeFit_Form form = new BeFit_Form(profile);
                form.Show();
                this.Close();
            }
            else
            {
                new GiveUserInfo_Form(true, "Zaznacz profil który ma być załadowany");
            }
        }

        public void AcceptOnlyIntNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        private void ChangeFatGramLabel(object sender, EventArgs e)
        {
            if (CaloricDemand_Textbox.Text == "") CaloricDemand_Textbox.Text = "0";
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double fat = Convert.ToDouble(FatDemand_Textbox.Text);
            FatGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * fat / 9), 1).ToString() + "g";
        }
        private void ChangeCarboGramLabel(object sender, EventArgs e)
        {
            if (CaloricDemand_Textbox.Text == "") CaloricDemand_Textbox.Text = "0";
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double carbo = Convert.ToDouble(CarboDemand_Textbox.Text);
            CarboGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * carbo / 4), 1).ToString() + "g";
        }
        private void ChangeProteinGramLabel(object sender, EventArgs e)
        {
            if (CaloricDemand_Textbox.Text == "") CaloricDemand_Textbox.Text = "0";
            double kcal = Convert.ToDouble(CaloricDemand_Textbox.Text);
            double protein = Convert.ToDouble(ProteinDemand_Textbox.Text);
            ProteinGramValue_Label.Text = "%  =" + Math.Round((kcal / 100 * protein / 4), 1).ToString() + "g";
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
