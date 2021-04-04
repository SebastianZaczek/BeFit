namespace BeFit.User_Controls
{
    partial class IngredientsPercentAndTotalValue_Progressbar
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
            this.GramValue_Label = new MetroFramework.Controls.MetroLabel();
            this.PercentValue_ProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.OverHunder_Label = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // GramValue_Label
            // 
            this.GramValue_Label.BackColor = System.Drawing.Color.Transparent;
            this.GramValue_Label.FontSize = MetroFramework.MetroLabelSize.Small;
            this.GramValue_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.GramValue_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.GramValue_Label.Location = new System.Drawing.Point(0, 0);
            this.GramValue_Label.Name = "GramValue_Label";
            this.GramValue_Label.Size = new System.Drawing.Size(65, 25);
            this.GramValue_Label.TabIndex = 12;
            this.GramValue_Label.Text = "value";
            this.GramValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GramValue_Label.UseCustomBackColor = true;
            this.GramValue_Label.UseCustomForeColor = true;
            // 
            // PercentValue_ProgressBar
            // 
            this.PercentValue_ProgressBar.FontSize = MetroFramework.MetroProgressBarSize.Tall;
            this.PercentValue_ProgressBar.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.PercentValue_ProgressBar.Location = new System.Drawing.Point(71, 0);
            this.PercentValue_ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.PercentValue_ProgressBar.Name = "PercentValue_ProgressBar";
            this.PercentValue_ProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.PercentValue_ProgressBar.Size = new System.Drawing.Size(106, 25);
            this.PercentValue_ProgressBar.Style = MetroFramework.MetroColorStyle.Orange;
            this.PercentValue_ProgressBar.TabIndex = 16;
            this.PercentValue_ProgressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PercentValue_ProgressBar.UseCustomBackColor = true;
            this.PercentValue_ProgressBar.Value = 50;
            // 
            // OverHunder_Label
            // 
            this.OverHunder_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OverHunder_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OverHunder_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.OverHunder_Label.Location = new System.Drawing.Point(177, 0);
            this.OverHunder_Label.Margin = new System.Windows.Forms.Padding(0);
            this.OverHunder_Label.Name = "OverHunder_Label";
            this.OverHunder_Label.Size = new System.Drawing.Size(62, 25);
            this.OverHunder_Label.TabIndex = 17;
            this.OverHunder_Label.Text = "100%";
            this.OverHunder_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OverHunder_Label.UseCustomBackColor = true;
            this.OverHunder_Label.UseCustomForeColor = true;
            this.OverHunder_Label.UseStyleColors = true;
            // 
            // IngredientsPercentAndTotalValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.GramValue_Label);
            this.Controls.Add(this.OverHunder_Label);
            this.Controls.Add(this.PercentValue_ProgressBar);
            this.Name = "IngredientsPercentAndTotalValue";
            this.Size = new System.Drawing.Size(242, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel GramValue_Label;
        private MetroFramework.Controls.MetroProgressBar PercentValue_ProgressBar;
        private MetroFramework.Controls.MetroLabel OverHunder_Label;
    }
}
