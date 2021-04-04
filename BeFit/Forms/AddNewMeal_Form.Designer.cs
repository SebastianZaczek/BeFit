namespace BeFit.Forms
{
    partial class AddNewMeal_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMeal_Form));
            this.AddNewMeal_Button = new MetroFramework.Controls.MetroButton();
            this.MealName_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // AddNewMeal_Button
            // 
            this.AddNewMeal_Button.BackColor = System.Drawing.Color.Transparent;
            this.AddNewMeal_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.AddNewMeal_Button.Location = new System.Drawing.Point(220, 86);
            this.AddNewMeal_Button.Name = "AddNewMeal_Button";
            this.AddNewMeal_Button.Size = new System.Drawing.Size(91, 26);
            this.AddNewMeal_Button.Style = MetroFramework.MetroColorStyle.Blue;
            this.AddNewMeal_Button.TabIndex = 1;
            this.AddNewMeal_Button.Text = "Dodaj";
            this.AddNewMeal_Button.UseCustomBackColor = true;
            this.AddNewMeal_Button.UseCustomForeColor = true;
            this.AddNewMeal_Button.UseSelectable = true;
            this.AddNewMeal_Button.UseStyleColors = true;
            this.AddNewMeal_Button.Click += new System.EventHandler(this.AddNewMeal_Button_Click);
            // 
            // MealName_Textbox
            // 
            this.MealName_Textbox.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.MealName_Textbox.CustomButton.Image = null;
            this.MealName_Textbox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.MealName_Textbox.CustomButton.Name = "";
            this.MealName_Textbox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MealName_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MealName_Textbox.CustomButton.TabIndex = 1;
            this.MealName_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MealName_Textbox.CustomButton.UseSelectable = true;
            this.MealName_Textbox.CustomButton.Visible = false;
            this.MealName_Textbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MealName_Textbox.ForeColor = System.Drawing.Color.DarkGray;
            this.MealName_Textbox.Lines = new string[0];
            this.MealName_Textbox.Location = new System.Drawing.Point(39, 87);
            this.MealName_Textbox.MaxLength = 32767;
            this.MealName_Textbox.Name = "MealName_Textbox";
            this.MealName_Textbox.PasswordChar = '\0';
            this.MealName_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MealName_Textbox.SelectedText = "";
            this.MealName_Textbox.SelectionLength = 0;
            this.MealName_Textbox.SelectionStart = 0;
            this.MealName_Textbox.ShortcutsEnabled = true;
            this.MealName_Textbox.Size = new System.Drawing.Size(150, 25);
            this.MealName_Textbox.TabIndex = 2;
            this.MealName_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MealName_Textbox.UseCustomBackColor = true;
            this.MealName_Textbox.UseCustomForeColor = true;
            this.MealName_Textbox.UseSelectable = true;
            this.MealName_Textbox.UseStyleColors = true;
            this.MealName_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MealName_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddNewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 145);
            this.Controls.Add(this.MealName_Textbox);
            this.Controls.Add(this.AddNewMeal_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewMeal";
            this.Resizable = false;
            this.Text = "Nazwa posiłku:";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton AddNewMeal_Button;
        private MetroFramework.Controls.MetroTextBox MealName_Textbox;
    }
}