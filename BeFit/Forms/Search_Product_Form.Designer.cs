namespace BeFit.Forms
{
    partial class Search_Product_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Product_Form));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Meal_ComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Category_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.Search_Button = new MetroFramework.Controls.MetroButton();
            this.Product_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.MealsMetro_Panel = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.Meal_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Category_Combobox);
            this.splitContainer1.Panel1.Controls.Add(this.Search_Button);
            this.splitContainer1.Panel1.Controls.Add(this.Product_Textbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.MealsMetro_Panel);
            this.splitContainer1.Size = new System.Drawing.Size(511, 461);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel3.Location = new System.Drawing.Point(14, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(121, 23);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Szukana fraza:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel2.Location = new System.Drawing.Point(141, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 23);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Kategoria:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel1.Location = new System.Drawing.Point(268, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 23);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Posiłek:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // Meal_ComboBox
            // 
            this.Meal_ComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.Meal_ComboBox.FormattingEnabled = true;
            this.Meal_ComboBox.ItemHeight = 23;
            this.Meal_ComboBox.Location = new System.Drawing.Point(268, 36);
            this.Meal_ComboBox.Name = "Meal_ComboBox";
            this.Meal_ComboBox.Size = new System.Drawing.Size(121, 29);
            this.Meal_ComboBox.TabIndex = 3;
            this.Meal_ComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Meal_ComboBox.UseSelectable = true;
            // 
            // Category_Combobox
            // 
            this.Category_Combobox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.Category_Combobox.FormattingEnabled = true;
            this.Category_Combobox.ItemHeight = 23;
            this.Category_Combobox.Location = new System.Drawing.Point(141, 36);
            this.Category_Combobox.Name = "Category_Combobox";
            this.Category_Combobox.Size = new System.Drawing.Size(121, 29);
            this.Category_Combobox.TabIndex = 2;
            this.Category_Combobox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Category_Combobox.UseSelectable = true;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(395, 36);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(86, 29);
            this.Search_Button.TabIndex = 1;
            this.Search_Button.Text = "Szukaj";
            this.Search_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Search_Button.UseSelectable = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Product_Textbox
            // 
            // 
            // 
            // 
            this.Product_Textbox.CustomButton.Image = null;
            this.Product_Textbox.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.Product_Textbox.CustomButton.Name = "";
            this.Product_Textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.Product_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Product_Textbox.CustomButton.TabIndex = 1;
            this.Product_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Product_Textbox.CustomButton.UseSelectable = true;
            this.Product_Textbox.CustomButton.Visible = false;
            this.Product_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Product_Textbox.Lines = new string[0];
            this.Product_Textbox.Location = new System.Drawing.Point(15, 36);
            this.Product_Textbox.MaxLength = 32767;
            this.Product_Textbox.Name = "Product_Textbox";
            this.Product_Textbox.PasswordChar = '\0';
            this.Product_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Product_Textbox.SelectedText = "";
            this.Product_Textbox.SelectionLength = 0;
            this.Product_Textbox.SelectionStart = 0;
            this.Product_Textbox.ShortcutsEnabled = true;
            this.Product_Textbox.Size = new System.Drawing.Size(120, 29);
            this.Product_Textbox.TabIndex = 0;
            this.Product_Textbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Product_Textbox.UseSelectable = true;
            this.Product_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Product_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Product_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Product_Textbox_KeyPress);
            // 
            // MealsMetro_Panel
            // 
            this.MealsMetro_Panel.AutoScroll = true;
            this.MealsMetro_Panel.HorizontalScrollbar = true;
            this.MealsMetro_Panel.HorizontalScrollbarBarColor = true;
            this.MealsMetro_Panel.HorizontalScrollbarHighlightOnWheel = true;
            this.MealsMetro_Panel.HorizontalScrollbarSize = 10;
            this.MealsMetro_Panel.Location = new System.Drawing.Point(0, 0);
            this.MealsMetro_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.MealsMetro_Panel.Name = "MealsMetro_Panel";
            this.MealsMetro_Panel.Size = new System.Drawing.Size(509, 358);
            this.MealsMetro_Panel.Style = MetroFramework.MetroColorStyle.Black;
            this.MealsMetro_Panel.TabIndex = 1;
            this.MealsMetro_Panel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MealsMetro_Panel.UseCustomBackColor = true;
            this.MealsMetro_Panel.UseCustomForeColor = true;
            this.MealsMetro_Panel.UseStyleColors = true;
            this.MealsMetro_Panel.VerticalScrollbar = true;
            this.MealsMetro_Panel.VerticalScrollbarBarColor = false;
            this.MealsMetro_Panel.VerticalScrollbarHighlightOnWheel = true;
            this.MealsMetro_Panel.VerticalScrollbarSize = 10;
            // 
            // Search_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 541);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Product_Form";
            this.Resizable = false;
            this.Text = "Wyszukaj produkt";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroComboBox Category_Combobox;
        private MetroFramework.Controls.MetroButton Search_Button;
        private MetroFramework.Controls.MetroTextBox Product_Textbox;
        private MetroFramework.Controls.MetroComboBox Meal_ComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel MealsMetro_Panel;
    }
}