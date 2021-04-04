namespace BeFit
{
    partial class StartBeFit
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartBeFit));
            this.NewProfile_Button = new MetroFramework.Controls.MetroButton();
            this.LoadButton = new MetroFramework.Controls.MetroButton();
            this.AddProfile_Button = new MetroFramework.Controls.MetroButton();
            this.ConfirmLoad_Button = new MetroFramework.Controls.MetroButton();
            this.Quit_Button = new MetroFramework.Controls.MetroButton();
            this.NewProfile_Panel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProfileName_TextBox = new System.Windows.Forms.TextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.FatGramValue_Label = new MetroFramework.Controls.MetroLabel();
            this.ProteinGramValue_Label = new MetroFramework.Controls.MetroLabel();
            this.CarboGramValue_Label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.Percent_Label = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.ProteinDemand_Textbox = new System.Windows.Forms.TextBox();
            this.CaloricDemand_Textbox = new System.Windows.Forms.TextBox();
            this.CarboDemand_Textbox = new System.Windows.Forms.TextBox();
            this.FatDemand_Textbox = new System.Windows.Forms.TextBox();
            this.Profiles_ListBox = new System.Windows.Forms.ListView();
            this.Tooltip_Picturebox = new System.Windows.Forms.PictureBox();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.NewProfile_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tooltip_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProfile_Button
            // 
            this.NewProfile_Button.BackColor = System.Drawing.Color.Transparent;
            this.NewProfile_Button.Location = new System.Drawing.Point(8, 65);
            this.NewProfile_Button.Name = "NewProfile_Button";
            this.NewProfile_Button.Size = new System.Drawing.Size(150, 40);
            this.NewProfile_Button.TabIndex = 0;
            this.NewProfile_Button.Text = "Nowy Profil";
            this.NewProfile_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NewProfile_Button.UseSelectable = true;
            this.NewProfile_Button.Click += new System.EventHandler(this.NewProfile_Button_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadButton.Location = new System.Drawing.Point(8, 135);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(150, 40);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Wczytaj postęp";
            this.LoadButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoadButton.UseSelectable = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AddProfile_Button
            // 
            this.AddProfile_Button.Location = new System.Drawing.Point(9, 343);
            this.AddProfile_Button.Name = "AddProfile_Button";
            this.AddProfile_Button.Size = new System.Drawing.Size(114, 40);
            this.AddProfile_Button.TabIndex = 5;
            this.AddProfile_Button.Text = "Stwórz";
            this.AddProfile_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AddProfile_Button.UseSelectable = true;
            this.AddProfile_Button.Click += new System.EventHandler(this.AddProfile_Button_Click);
            // 
            // ConfirmLoad_Button
            // 
            this.ConfirmLoad_Button.Location = new System.Drawing.Point(371, 367);
            this.ConfirmLoad_Button.Name = "ConfirmLoad_Button";
            this.ConfirmLoad_Button.Size = new System.Drawing.Size(114, 40);
            this.ConfirmLoad_Button.TabIndex = 6;
            this.ConfirmLoad_Button.Text = "Zatwierdź";
            this.ConfirmLoad_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConfirmLoad_Button.UseSelectable = true;
            this.ConfirmLoad_Button.Visible = false;
            this.ConfirmLoad_Button.Click += new System.EventHandler(this.ConfirmLoad_Button_Click);
            // 
            // Quit_Button
            // 
            this.Quit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Quit_Button.Location = new System.Drawing.Point(8, 205);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(150, 40);
            this.Quit_Button.TabIndex = 1;
            this.Quit_Button.Text = "Zakończ";
            this.Quit_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Quit_Button.UseSelectable = true;
            this.Quit_Button.Click += new System.EventHandler(this.Quit_Button_Click);
            // 
            // NewProfile_Panel
            // 
            this.NewProfile_Panel.Controls.Add(this.Tooltip_Picturebox);
            this.NewProfile_Panel.Controls.Add(this.metroLabel1);
            this.NewProfile_Panel.Controls.Add(this.ProfileName_TextBox);
            this.NewProfile_Panel.Controls.Add(this.metroLabel17);
            this.NewProfile_Panel.Controls.Add(this.metroLabel16);
            this.NewProfile_Panel.Controls.Add(this.FatGramValue_Label);
            this.NewProfile_Panel.Controls.Add(this.ProteinGramValue_Label);
            this.NewProfile_Panel.Controls.Add(this.CarboGramValue_Label);
            this.NewProfile_Panel.Controls.Add(this.metroLabel5);
            this.NewProfile_Panel.Controls.Add(this.metroLabel12);
            this.NewProfile_Panel.Controls.Add(this.metroLabel13);
            this.NewProfile_Panel.Controls.Add(this.Percent_Label);
            this.NewProfile_Panel.Controls.Add(this.metroLabel15);
            this.NewProfile_Panel.Controls.Add(this.ProteinDemand_Textbox);
            this.NewProfile_Panel.Controls.Add(this.CaloricDemand_Textbox);
            this.NewProfile_Panel.Controls.Add(this.CarboDemand_Textbox);
            this.NewProfile_Panel.Controls.Add(this.FatDemand_Textbox);
            this.NewProfile_Panel.Controls.Add(this.AddProfile_Button);
            this.NewProfile_Panel.Location = new System.Drawing.Point(164, 24);
            this.NewProfile_Panel.Name = "NewProfile_Panel";
            this.NewProfile_Panel.Size = new System.Drawing.Size(201, 393);
            this.NewProfile_Panel.TabIndex = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel1.Location = new System.Drawing.Point(115, 112);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "kcal";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ProfileName_TextBox
            // 
            this.ProfileName_TextBox.BackColor = System.Drawing.Color.Black;
            this.ProfileName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProfileName_TextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ProfileName_TextBox.Location = new System.Drawing.Point(9, 55);
            this.ProfileName_TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ProfileName_TextBox.MaxLength = 10;
            this.ProfileName_TextBox.Name = "ProfileName_TextBox";
            this.ProfileName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.ProfileName_TextBox.TabIndex = 27;
            this.ProfileName_TextBox.Text = "Profil";
            this.ProfileName_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel17
            // 
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel17.Location = new System.Drawing.Point(9, 35);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(100, 20);
            this.metroLabel17.TabIndex = 26;
            this.metroLabel17.Text = "Nazwa profilu";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel17.UseCustomBackColor = true;
            this.metroLabel17.UseCustomForeColor = true;
            this.metroLabel17.UseStyleColors = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel16.Location = new System.Drawing.Point(9, 87);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(100, 20);
            this.metroLabel16.TabIndex = 25;
            this.metroLabel16.Text = "Kalorie:";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            this.metroLabel16.UseStyleColors = true;
            // 
            // FatGramValue_Label
            // 
            this.FatGramValue_Label.AutoSize = true;
            this.FatGramValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.FatGramValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FatGramValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.FatGramValue_Label.Location = new System.Drawing.Point(115, 165);
            this.FatGramValue_Label.Name = "FatGramValue_Label";
            this.FatGramValue_Label.Size = new System.Drawing.Size(21, 19);
            this.FatGramValue_Label.TabIndex = 23;
            this.FatGramValue_Label.Text = "%";
            this.FatGramValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FatGramValue_Label.UseCustomBackColor = true;
            this.FatGramValue_Label.UseCustomForeColor = true;
            this.FatGramValue_Label.UseStyleColors = true;
            // 
            // ProteinGramValue_Label
            // 
            this.ProteinGramValue_Label.AutoSize = true;
            this.ProteinGramValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.ProteinGramValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ProteinGramValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.ProteinGramValue_Label.Location = new System.Drawing.Point(115, 275);
            this.ProteinGramValue_Label.Name = "ProteinGramValue_Label";
            this.ProteinGramValue_Label.Size = new System.Drawing.Size(21, 19);
            this.ProteinGramValue_Label.TabIndex = 22;
            this.ProteinGramValue_Label.Text = "%";
            this.ProteinGramValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProteinGramValue_Label.UseCustomBackColor = true;
            this.ProteinGramValue_Label.UseCustomForeColor = true;
            this.ProteinGramValue_Label.UseStyleColors = true;
            // 
            // CarboGramValue_Label
            // 
            this.CarboGramValue_Label.AutoSize = true;
            this.CarboGramValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.CarboGramValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CarboGramValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.CarboGramValue_Label.Location = new System.Drawing.Point(115, 222);
            this.CarboGramValue_Label.Name = "CarboGramValue_Label";
            this.CarboGramValue_Label.Size = new System.Drawing.Size(21, 19);
            this.CarboGramValue_Label.TabIndex = 21;
            this.CarboGramValue_Label.Text = "%";
            this.CarboGramValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CarboGramValue_Label.UseCustomBackColor = true;
            this.CarboGramValue_Label.UseCustomForeColor = true;
            this.CarboGramValue_Label.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel5.Location = new System.Drawing.Point(9, 252);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 20);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Białko";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel12.Location = new System.Drawing.Point(9, 197);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(100, 20);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Węglowodany";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel13.Location = new System.Drawing.Point(9, 142);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(100, 20);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "Tluszcz";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            this.metroLabel13.UseStyleColors = true;
            // 
            // Percent_Label
            // 
            this.Percent_Label.BackColor = System.Drawing.Color.Transparent;
            this.Percent_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Percent_Label.ForeColor = System.Drawing.Color.Green;
            this.Percent_Label.Location = new System.Drawing.Point(105, 307);
            this.Percent_Label.Name = "Percent_Label";
            this.Percent_Label.Size = new System.Drawing.Size(47, 19);
            this.Percent_Label.TabIndex = 15;
            this.Percent_Label.Text = "0";
            this.Percent_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Percent_Label.UseCustomBackColor = true;
            this.Percent_Label.UseCustomForeColor = true;
            this.Percent_Label.UseStyleColors = true;
            this.Percent_Label.TextChanged += new System.EventHandler(this.Percent_Label_TextChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel15.Location = new System.Drawing.Point(9, 307);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(81, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "Pozostało %";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            this.metroLabel15.UseStyleColors = true;
            // 
            // ProteinDemand_Textbox
            // 
            this.ProteinDemand_Textbox.BackColor = System.Drawing.Color.Black;
            this.ProteinDemand_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProteinDemand_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.ProteinDemand_Textbox.Location = new System.Drawing.Point(9, 275);
            this.ProteinDemand_Textbox.MaxLength = 3;
            this.ProteinDemand_Textbox.Name = "ProteinDemand_Textbox";
            this.ProteinDemand_Textbox.Size = new System.Drawing.Size(100, 21);
            this.ProteinDemand_Textbox.TabIndex = 10;
            this.ProteinDemand_Textbox.Text = "34";
            this.ProteinDemand_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProteinDemand_Textbox.TextChanged += new System.EventHandler(this.CheckNullValues);
            this.ProteinDemand_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyIntNumber);
            // 
            // CaloricDemand_Textbox
            // 
            this.CaloricDemand_Textbox.BackColor = System.Drawing.Color.Black;
            this.CaloricDemand_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaloricDemand_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.CaloricDemand_Textbox.Location = new System.Drawing.Point(9, 110);
            this.CaloricDemand_Textbox.MaxLength = 4;
            this.CaloricDemand_Textbox.Name = "CaloricDemand_Textbox";
            this.CaloricDemand_Textbox.Size = new System.Drawing.Size(100, 21);
            this.CaloricDemand_Textbox.TabIndex = 7;
            this.CaloricDemand_Textbox.Text = "2000";
            this.CaloricDemand_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CaloricDemand_Textbox.TextChanged += new System.EventHandler(this.CheckNullValuesForKcal);
            this.CaloricDemand_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyIntNumber);
            // 
            // CarboDemand_Textbox
            // 
            this.CarboDemand_Textbox.BackColor = System.Drawing.Color.Black;
            this.CarboDemand_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CarboDemand_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.CarboDemand_Textbox.Location = new System.Drawing.Point(9, 220);
            this.CarboDemand_Textbox.MaxLength = 3;
            this.CarboDemand_Textbox.Name = "CarboDemand_Textbox";
            this.CarboDemand_Textbox.Size = new System.Drawing.Size(100, 21);
            this.CarboDemand_Textbox.TabIndex = 9;
            this.CarboDemand_Textbox.Text = "33";
            this.CarboDemand_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CarboDemand_Textbox.TextChanged += new System.EventHandler(this.CheckNullValues);
            this.CarboDemand_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyIntNumber);
            // 
            // FatDemand_Textbox
            // 
            this.FatDemand_Textbox.BackColor = System.Drawing.Color.Black;
            this.FatDemand_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FatDemand_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.FatDemand_Textbox.Location = new System.Drawing.Point(9, 165);
            this.FatDemand_Textbox.MaxLength = 3;
            this.FatDemand_Textbox.Name = "FatDemand_Textbox";
            this.FatDemand_Textbox.Size = new System.Drawing.Size(100, 21);
            this.FatDemand_Textbox.TabIndex = 8;
            this.FatDemand_Textbox.Text = "33";
            this.FatDemand_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FatDemand_Textbox.TextChanged += new System.EventHandler(this.CheckNullValues);
            this.FatDemand_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyIntNumber);
            // 
            // Profiles_ListBox
            // 
            this.Profiles_ListBox.Font = new System.Drawing.Font("Arial Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Profiles_ListBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Profiles_ListBox.HideSelection = false;
            this.Profiles_ListBox.Location = new System.Drawing.Point(371, 59);
            this.Profiles_ListBox.MultiSelect = false;
            this.Profiles_ListBox.Name = "Profiles_ListBox";
            this.Profiles_ListBox.Size = new System.Drawing.Size(194, 277);
            this.Profiles_ListBox.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Profiles_ListBox.TabIndex = 14;
            this.Profiles_ListBox.UseCompatibleStateImageBehavior = false;
            this.Profiles_ListBox.View = System.Windows.Forms.View.List;
            // 
            // Tooltip_Picturebox
            // 
            this.Tooltip_Picturebox.BackColor = System.Drawing.Color.Transparent;
            this.Tooltip_Picturebox.BackgroundImage = global::BeFit.Properties.Resources.ToolTip_Image;
            this.Tooltip_Picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tooltip_Picturebox.Location = new System.Drawing.Point(127, 52);
            this.Tooltip_Picturebox.Name = "Tooltip_Picturebox";
            this.Tooltip_Picturebox.Size = new System.Drawing.Size(25, 25);
            this.Tooltip_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tooltip_Picturebox.TabIndex = 34;
            this.Tooltip_Picturebox.TabStop = false;
            // 
            // Tooltip
            // 
            this.Tooltip.AutoPopDelay = 5000;
            this.Tooltip.InitialDelay = 1;
            this.Tooltip.ReshowDelay = 100;
            this.Tooltip.Style = MetroFramework.MetroColorStyle.Black;
            this.Tooltip.StyleManager = null;
            this.Tooltip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // StartBeFit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 430);
            this.ControlBox = false;
            this.Controls.Add(this.Profiles_ListBox);
            this.Controls.Add(this.NewProfile_Panel);
            this.Controls.Add(this.ConfirmLoad_Button);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.Quit_Button);
            this.Controls.Add(this.NewProfile_Button);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartBeFit";
            this.Resizable = false;
            this.Text = "BeFit";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.NewProfile_Panel.ResumeLayout(false);
            this.NewProfile_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tooltip_Picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton NewProfile_Button;
        private MetroFramework.Controls.MetroButton LoadButton;
        private MetroFramework.Controls.MetroButton AddProfile_Button;
        private MetroFramework.Controls.MetroButton ConfirmLoad_Button;
        private MetroFramework.Controls.MetroButton Quit_Button;
        private System.Windows.Forms.Panel NewProfile_Panel;
        private System.Windows.Forms.TextBox ProfileName_TextBox;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel FatGramValue_Label;
        private MetroFramework.Controls.MetroLabel ProteinGramValue_Label;
        private MetroFramework.Controls.MetroLabel CarboGramValue_Label;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel Percent_Label;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.TextBox ProteinDemand_Textbox;
        private System.Windows.Forms.TextBox CaloricDemand_Textbox;
        private System.Windows.Forms.TextBox CarboDemand_Textbox;
        private System.Windows.Forms.TextBox FatDemand_Textbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView Profiles_ListBox;
        private System.Windows.Forms.PictureBox Tooltip_Picturebox;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}

