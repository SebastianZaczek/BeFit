namespace BeFit.User_Controls
{
    partial class ProductInMeal_Control
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
            this.KcalValue_Label = new MetroFramework.Controls.MetroLabel();
            this.KcalLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.RemoveProduct_Button = new MetroFramework.Controls.MetroButton();
            this.Fat_Label = new MetroFramework.Controls.MetroLabel();
            this.FatValue_Label = new MetroFramework.Controls.MetroLabel();
            this.Carbo_Label = new MetroFramework.Controls.MetroLabel();
            this.CarboValue_Label = new MetroFramework.Controls.MetroLabel();
            this.Protein_Label = new MetroFramework.Controls.MetroLabel();
            this.ProteinValue_Label = new MetroFramework.Controls.MetroLabel();
            this.ProductPicture = new System.Windows.Forms.PictureBox();
            this.ToolTip = new MetroFramework.Components.MetroToolTip();
            this.Weight_Label = new MetroFramework.Controls.MetroLabel();
            this.StaticLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // KcalValue_Label
            // 
            this.KcalValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.KcalValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KcalValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.KcalValue_Label.Location = new System.Drawing.Point(236, 3);
            this.KcalValue_Label.Name = "KcalValue_Label";
            this.KcalValue_Label.Size = new System.Drawing.Size(83, 19);
            this.KcalValue_Label.TabIndex = 11;
            this.KcalValue_Label.Text = "kcal /100 ";
            this.KcalValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KcalValue_Label.UseCustomBackColor = true;
            this.KcalValue_Label.UseCustomForeColor = true;
            this.KcalValue_Label.UseStyleColors = true;
            // 
            // KcalLabel
            // 
            this.KcalLabel.BackColor = System.Drawing.Color.Transparent;
            this.KcalLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KcalLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.KcalLabel.Location = new System.Drawing.Point(97, 3);
            this.KcalLabel.Name = "KcalLabel";
            this.KcalLabel.Size = new System.Drawing.Size(95, 19);
            this.KcalLabel.TabIndex = 10;
            this.KcalLabel.Text = "KCAL";
            this.KcalLabel.UseCustomBackColor = true;
            this.KcalLabel.UseCustomForeColor = true;
            this.KcalLabel.UseStyleColors = true;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.NameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.NameLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.NameLabel.Location = new System.Drawing.Point(3, 101);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(414, 26);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "name";
            this.NameLabel.UseCustomBackColor = true;
            this.NameLabel.UseCustomForeColor = true;
            this.NameLabel.UseStyleColors = true;
            // 
            // RemoveProduct_Button
            // 
            this.RemoveProduct_Button.BackColor = System.Drawing.Color.DimGray;
            this.RemoveProduct_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.RemoveProduct_Button.Location = new System.Drawing.Point(325, 3);
            this.RemoveProduct_Button.Name = "RemoveProduct_Button";
            this.RemoveProduct_Button.Size = new System.Drawing.Size(92, 44);
            this.RemoveProduct_Button.Style = MetroFramework.MetroColorStyle.Red;
            this.RemoveProduct_Button.TabIndex = 16;
            this.RemoveProduct_Button.Text = "Usuń";
            this.RemoveProduct_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RemoveProduct_Button.UseSelectable = true;
            this.RemoveProduct_Button.UseStyleColors = true;
            
            // 
            // Fat_Label
            // 
            this.Fat_Label.BackColor = System.Drawing.Color.Transparent;
            this.Fat_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Fat_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Fat_Label.Location = new System.Drawing.Point(97, 28);
            this.Fat_Label.Name = "Fat_Label";
            this.Fat_Label.Size = new System.Drawing.Size(95, 19);
            this.Fat_Label.TabIndex = 18;
            this.Fat_Label.Text = "Tluszcz";
            this.Fat_Label.UseCustomBackColor = true;
            this.Fat_Label.UseCustomForeColor = true;
            this.Fat_Label.UseStyleColors = true;
            // 
            // FatValue_Label
            // 
            this.FatValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.FatValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FatValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.FatValue_Label.Location = new System.Drawing.Point(236, 28);
            this.FatValue_Label.Name = "FatValue_Label";
            this.FatValue_Label.Size = new System.Drawing.Size(83, 19);
            this.FatValue_Label.TabIndex = 19;
            this.FatValue_Label.Text = "value";
            this.FatValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FatValue_Label.UseCustomBackColor = true;
            this.FatValue_Label.UseCustomForeColor = true;
            this.FatValue_Label.UseStyleColors = true;
            // 
            // Carbo_Label
            // 
            this.Carbo_Label.BackColor = System.Drawing.Color.Transparent;
            this.Carbo_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Carbo_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Carbo_Label.Location = new System.Drawing.Point(97, 53);
            this.Carbo_Label.Name = "Carbo_Label";
            this.Carbo_Label.Size = new System.Drawing.Size(104, 19);
            this.Carbo_Label.TabIndex = 20;
            this.Carbo_Label.Text = "Węglowodany";
            this.Carbo_Label.UseCustomBackColor = true;
            this.Carbo_Label.UseCustomForeColor = true;
            this.Carbo_Label.UseStyleColors = true;
            // 
            // CarboValue_Label
            // 
            this.CarboValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.CarboValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.CarboValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.CarboValue_Label.Location = new System.Drawing.Point(236, 53);
            this.CarboValue_Label.Name = "CarboValue_Label";
            this.CarboValue_Label.Size = new System.Drawing.Size(83, 19);
            this.CarboValue_Label.TabIndex = 21;
            this.CarboValue_Label.Text = "value";
            this.CarboValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CarboValue_Label.UseCustomBackColor = true;
            this.CarboValue_Label.UseCustomForeColor = true;
            this.CarboValue_Label.UseStyleColors = true;
            // 
            // Protein_Label
            // 
            this.Protein_Label.BackColor = System.Drawing.Color.Transparent;
            this.Protein_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Protein_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Protein_Label.Location = new System.Drawing.Point(97, 81);
            this.Protein_Label.Name = "Protein_Label";
            this.Protein_Label.Size = new System.Drawing.Size(95, 19);
            this.Protein_Label.TabIndex = 22;
            this.Protein_Label.Text = "Białko";
            this.Protein_Label.UseCustomBackColor = true;
            this.Protein_Label.UseCustomForeColor = true;
            this.Protein_Label.UseStyleColors = true;
            // 
            // ProteinValue_Label
            // 
            this.ProteinValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.ProteinValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ProteinValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.ProteinValue_Label.Location = new System.Drawing.Point(236, 81);
            this.ProteinValue_Label.Name = "ProteinValue_Label";
            this.ProteinValue_Label.Size = new System.Drawing.Size(83, 19);
            this.ProteinValue_Label.TabIndex = 23;
            this.ProteinValue_Label.Text = "value";
            this.ProteinValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProteinValue_Label.UseCustomBackColor = true;
            this.ProteinValue_Label.UseCustomForeColor = true;
            this.ProteinValue_Label.UseStyleColors = true;
            // 
            // ProductPicture
            // 
            this.ProductPicture.Location = new System.Drawing.Point(3, 3);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.Size = new System.Drawing.Size(75, 75);
            this.ProductPicture.TabIndex = 8;
            this.ProductPicture.TabStop = false;
            // 
            // ToolTip
            // 
            this.ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.ToolTip.StyleManager = null;
            this.ToolTip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Weight_Label
            // 
            this.Weight_Label.BackColor = System.Drawing.Color.Transparent;
            this.Weight_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Weight_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Weight_Label.Location = new System.Drawing.Point(329, 72);
            this.Weight_Label.Name = "Weight_Label";
            this.Weight_Label.Size = new System.Drawing.Size(88, 19);
            this.Weight_Label.TabIndex = 26;
            this.Weight_Label.Text = "100 g";
            this.Weight_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Weight_Label.UseCustomBackColor = true;
            this.Weight_Label.UseCustomForeColor = true;
            this.Weight_Label.UseStyleColors = true;
            // 
            // StaticLabel2
            // 
            this.StaticLabel2.BackColor = System.Drawing.Color.Transparent;
            this.StaticLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.StaticLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.StaticLabel2.Location = new System.Drawing.Point(329, 53);
            this.StaticLabel2.Name = "StaticLabel2";
            this.StaticLabel2.Size = new System.Drawing.Size(88, 19);
            this.StaticLabel2.TabIndex = 27;
            this.StaticLabel2.Text = "Spożyto:";
            this.StaticLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StaticLabel2.UseCustomBackColor = true;
            this.StaticLabel2.UseCustomForeColor = true;
            this.StaticLabel2.UseStyleColors = true;
            // 
            // TodaysMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.StaticLabel2);
            this.Controls.Add(this.Weight_Label);
            this.Controls.Add(this.ProteinValue_Label);
            this.Controls.Add(this.Protein_Label);
            this.Controls.Add(this.CarboValue_Label);
            this.Controls.Add(this.Carbo_Label);
            this.Controls.Add(this.FatValue_Label);
            this.Controls.Add(this.Fat_Label);
            this.Controls.Add(this.RemoveProduct_Button);
            this.Controls.Add(this.KcalValue_Label);
            this.Controls.Add(this.KcalLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ProductPicture);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "TodaysMeal";
            this.Size = new System.Drawing.Size(430, 132);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel KcalValue_Label;
        private MetroFramework.Controls.MetroLabel KcalLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private System.Windows.Forms.PictureBox ProductPicture;
        private MetroFramework.Controls.MetroLabel Fat_Label;
        private MetroFramework.Controls.MetroLabel FatValue_Label;
        private MetroFramework.Controls.MetroLabel Carbo_Label;
        private MetroFramework.Controls.MetroLabel CarboValue_Label;
        private MetroFramework.Controls.MetroLabel Protein_Label;
        private MetroFramework.Controls.MetroLabel ProteinValue_Label;
        public MetroFramework.Controls.MetroButton RemoveProduct_Button;
        private MetroFramework.Components.MetroToolTip ToolTip;
        private MetroFramework.Controls.MetroLabel Weight_Label;
        private MetroFramework.Controls.MetroLabel StaticLabel2;
    }
}
