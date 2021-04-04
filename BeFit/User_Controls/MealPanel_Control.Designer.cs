namespace BeFit.User_Controls
{
    partial class MealPanel_Control
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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.KcalTotal_Label = new MetroFramework.Controls.MetroLabel();
            this.Expand_Button = new MetroFramework.Controls.MetroButton();
            this.Title_Label = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.Panel1.Controls.Add(this.KcalTotal_Label);
            this.SplitContainer.Panel1.Controls.Add(this.Expand_Button);
            this.SplitContainer.Panel1.Controls.Add(this.Title_Label);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.Size = new System.Drawing.Size(430, 185);
            this.SplitContainer.SplitterDistance = 45;
            this.SplitContainer.SplitterWidth = 1;
            this.SplitContainer.TabIndex = 0;
            // 
            // KcalTotal_Label
            // 
            this.KcalTotal_Label.BackColor = System.Drawing.Color.Transparent;
            this.KcalTotal_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.KcalTotal_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KcalTotal_Label.ForeColor = System.Drawing.Color.DimGray;
            this.KcalTotal_Label.Location = new System.Drawing.Point(195, 4);
            this.KcalTotal_Label.Name = "KcalTotal_Label";
            this.KcalTotal_Label.Size = new System.Drawing.Size(100, 35);
            this.KcalTotal_Label.TabIndex = 2;
            this.KcalTotal_Label.Text = "value";
            this.KcalTotal_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KcalTotal_Label.UseCustomBackColor = true;
            this.KcalTotal_Label.UseCustomForeColor = true;
            // 
            // Expand_Button
            // 
            this.Expand_Button.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Expand_Button.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Expand_Button.ForeColor = System.Drawing.Color.DarkGray;
            this.Expand_Button.Location = new System.Drawing.Point(314, 4);
            this.Expand_Button.Name = "Expand_Button";
            this.Expand_Button.Size = new System.Drawing.Size(96, 35);
            this.Expand_Button.TabIndex = 1;
            this.Expand_Button.Text = "Rozwiń";
            this.Expand_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Expand_Button.UseCustomBackColor = true;
            this.Expand_Button.UseCustomForeColor = true;
            this.Expand_Button.UseSelectable = true;
            this.Expand_Button.UseStyleColors = true;
            this.Expand_Button.Click += new System.EventHandler(this.Expand_Button_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.BackColor = System.Drawing.Color.Transparent;
            this.Title_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Title_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Title_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Title_Label.Location = new System.Drawing.Point(3, 4);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(235, 35);
            this.Title_Label.TabIndex = 0;
            this.Title_Label.Text = "title";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_Label.UseCustomBackColor = true;
            this.Title_Label.UseCustomForeColor = true;
            // 
            // MealPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.SplitContainer);
            this.Name = "MealPanel";
            this.Size = new System.Drawing.Size(430, 185);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        public MetroFramework.Controls.MetroButton Expand_Button;
        private MetroFramework.Controls.MetroLabel KcalTotal_Label;
        public MetroFramework.Controls.MetroLabel Title_Label;
    }
}
