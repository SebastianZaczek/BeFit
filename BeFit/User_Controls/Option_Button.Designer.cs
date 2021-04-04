namespace BeFit.User_Controls
{
    partial class Option_Button
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
            this.Main_Tile = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Main_Tile
            // 
            this.Main_Tile.ActiveControl = null;
            this.Main_Tile.BackColor = System.Drawing.Color.DimGray;
            this.Main_Tile.ForeColor = System.Drawing.Color.LightGray;
            this.Main_Tile.Location = new System.Drawing.Point(5, 5);
            this.Main_Tile.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Tile.Name = "Main_Tile";
            this.Main_Tile.Size = new System.Drawing.Size(140, 70);
            this.Main_Tile.Style = MetroFramework.MetroColorStyle.Silver;
            this.Main_Tile.TabIndex = 0;
            this.Main_Tile.Text = "Szukaj";
            this.Main_Tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Main_Tile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Main_Tile.TileImage = global::BeFit.Properties.Resources.ok;
            this.Main_Tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Main_Tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Main_Tile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Main_Tile.UseCustomBackColor = true;
            this.Main_Tile.UseCustomForeColor = true;
            this.Main_Tile.UseSelectable = true;
            this.Main_Tile.UseStyleColors = true;
            this.Main_Tile.UseTileImage = true;
            this.Main_Tile.Click += new System.EventHandler(this.Click_Event);
            // 
            // Option_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Main_Tile);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Option_Button";
            this.Size = new System.Drawing.Size(152, 82);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UseCustomBackColor = true;
            this.EnabledChanged += new System.EventHandler(this.Option_Button_EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Main_Tile;
    }
}
