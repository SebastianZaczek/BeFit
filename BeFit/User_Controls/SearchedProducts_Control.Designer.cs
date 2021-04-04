namespace BeFit.User_Controls
{
    partial class SearchedProducts_Control
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.KcalLabel = new MetroFramework.Controls.MetroLabel();
            this.AddButton = new MetroFramework.Controls.MetroButton();
            this.Weight_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.StaticLabel2 = new MetroFramework.Controls.MetroLabel();
            this.StaticLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Tip_Label = new MetroFramework.Controls.MetroLabel();
            this.RemoveFromDB_Button = new MetroFramework.Controls.MetroButton();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.NameLabel.Location = new System.Drawing.Point(3, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(245, 19);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "product_name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameLabel.UseCustomBackColor = true;
            this.NameLabel.UseCustomForeColor = true;
            // 
            // KcalLabel
            // 
            this.KcalLabel.BackColor = System.Drawing.Color.Transparent;
            this.KcalLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KcalLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.KcalLabel.Location = new System.Drawing.Point(101, 3);
            this.KcalLabel.Name = "KcalLabel";
            this.KcalLabel.Size = new System.Drawing.Size(286, 19);
            this.KcalLabel.TabIndex = 2;
            this.KcalLabel.Text = "kcal value";
            this.KcalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KcalLabel.UseCustomBackColor = true;
            this.KcalLabel.UseCustomForeColor = true;
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.Color.DarkGray;
            this.AddButton.Location = new System.Drawing.Point(393, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 41);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseCustomBackColor = true;
            this.AddButton.UseSelectable = true;
            this.AddButton.UseStyleColors = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Weight_TextBox
            // 
            this.Weight_TextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // 
            // 
            this.Weight_TextBox.CustomButton.Image = null;
            this.Weight_TextBox.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.Weight_TextBox.CustomButton.Name = "";
            this.Weight_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Weight_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Weight_TextBox.CustomButton.TabIndex = 1;
            this.Weight_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Weight_TextBox.CustomButton.UseSelectable = true;
            this.Weight_TextBox.CustomButton.Visible = false;
            this.Weight_TextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.Weight_TextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.Weight_TextBox.Lines = new string[0];
            this.Weight_TextBox.Location = new System.Drawing.Point(319, 81);
            this.Weight_TextBox.MaxLength = 4;
            this.Weight_TextBox.Name = "Weight_TextBox";
            this.Weight_TextBox.PasswordChar = '\0';
            this.Weight_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Weight_TextBox.SelectedText = "";
            this.Weight_TextBox.SelectionLength = 0;
            this.Weight_TextBox.SelectionStart = 0;
            this.Weight_TextBox.ShortcutsEnabled = true;
            this.Weight_TextBox.Size = new System.Drawing.Size(75, 23);
            this.Weight_TextBox.TabIndex = 5;
            this.Weight_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Weight_TextBox.UseCustomBackColor = true;
            this.Weight_TextBox.UseCustomForeColor = true;
            this.Weight_TextBox.UseSelectable = true;
            this.Weight_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Weight_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Weight_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_TextBox_KeyPress);
            // 
            // StaticLabel2
            // 
            this.StaticLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.StaticLabel2.Location = new System.Drawing.Point(254, 81);
            this.StaticLabel2.Name = "StaticLabel2";
            this.StaticLabel2.Size = new System.Drawing.Size(59, 23);
            this.StaticLabel2.TabIndex = 6;
            this.StaticLabel2.Text = "Spożyto:";
            this.StaticLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StaticLabel2.UseCustomBackColor = true;
            this.StaticLabel2.UseCustomForeColor = true;
            // 
            // StaticLabel3
            // 
            this.StaticLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.StaticLabel3.Location = new System.Drawing.Point(400, 81);
            this.StaticLabel3.Name = "StaticLabel3";
            this.StaticLabel3.Size = new System.Drawing.Size(41, 23);
            this.StaticLabel3.TabIndex = 7;
            this.StaticLabel3.Text = "g/ml";
            this.StaticLabel3.UseCustomBackColor = true;
            this.StaticLabel3.UseCustomForeColor = true;
            // 
            // Tip_Label
            // 
            this.Tip_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tip_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Tip_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Tip_Label.Location = new System.Drawing.Point(101, 33);
            this.Tip_Label.Name = "Tip_Label";
            this.Tip_Label.Size = new System.Drawing.Size(286, 19);
            this.Tip_Label.TabIndex = 8;
            this.Tip_Label.Text = "tip_text";
            this.Tip_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tip_Label.UseCustomBackColor = true;
            this.Tip_Label.UseCustomForeColor = true;
            // 
            // RemoveFromDB_Button
            // 
            this.RemoveFromDB_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.RemoveFromDB_Button.Location = new System.Drawing.Point(393, 47);
            this.RemoveFromDB_Button.Name = "RemoveFromDB_Button";
            this.RemoveFromDB_Button.Size = new System.Drawing.Size(50, 28);
            this.RemoveFromDB_Button.Style = MetroFramework.MetroColorStyle.Red;
            this.RemoveFromDB_Button.TabIndex = 9;
            this.RemoveFromDB_Button.Text = "Usuń";
            this.RemoveFromDB_Button.UseCustomBackColor = true;
            this.RemoveFromDB_Button.UseSelectable = true;
            this.RemoveFromDB_Button.UseStyleColors = true;
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(20, 3);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(75, 75);
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // SearchedProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.RemoveFromDB_Button);
            this.Controls.Add(this.Tip_Label);
            this.Controls.Add(this.StaticLabel3);
            this.Controls.Add(this.StaticLabel2);
            this.Controls.Add(this.Weight_TextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.KcalLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.picturebox);
            this.Name = "SearchedProducts";
            this.Size = new System.Drawing.Size(446, 111);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private MetroFramework.Controls.MetroLabel KcalLabel;
        private MetroFramework.Controls.MetroTextBox Weight_TextBox;
        private MetroFramework.Controls.MetroLabel StaticLabel2;
        private MetroFramework.Controls.MetroLabel StaticLabel3;
        public MetroFramework.Controls.MetroButton AddButton;
        private MetroFramework.Controls.MetroLabel Tip_Label;
        public MetroFramework.Controls.MetroButton RemoveFromDB_Button;
        private MetroFramework.Components.MetroToolTip ToolTip;
    }
}
