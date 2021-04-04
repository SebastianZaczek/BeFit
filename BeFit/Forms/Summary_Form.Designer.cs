namespace BeFit.Forms
{
    partial class Summary_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary_Form));
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.BalancePeroid_Combobox = new MetroFramework.Controls.MetroComboBox();
            this.Search_Button = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DaysStatic_Label = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(20, 60);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.DaysStatic_Label);
            this.MainContainer.Panel1.Controls.Add(this.metroLabel2);
            this.MainContainer.Panel1.Controls.Add(this.Search_Button);
            this.MainContainer.Panel1.Controls.Add(this.BalancePeroid_Combobox);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.AutoScroll = true;
            this.MainContainer.Size = new System.Drawing.Size(684, 88);
            this.MainContainer.SplitterDistance = 49;
            this.MainContainer.TabIndex = 0;
            // 
            // BalancePeroid_Combobox
            // 
            this.BalancePeroid_Combobox.DropDownHeight = 200;
            this.BalancePeroid_Combobox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.BalancePeroid_Combobox.FormattingEnabled = true;
            this.BalancePeroid_Combobox.IntegralHeight = false;
            this.BalancePeroid_Combobox.ItemHeight = 23;
            this.BalancePeroid_Combobox.Location = new System.Drawing.Point(169, 12);
            this.BalancePeroid_Combobox.Name = "BalancePeroid_Combobox";
            this.BalancePeroid_Combobox.Size = new System.Drawing.Size(158, 29);
            this.BalancePeroid_Combobox.TabIndex = 3;
            this.BalancePeroid_Combobox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BalancePeroid_Combobox.UseSelectable = true;
            this.BalancePeroid_Combobox.SelectedIndexChanged += new System.EventHandler(this.BalancePeroid_Combobox_SelectedIndexChanged);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(489, 12);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(116, 29);
            this.Search_Button.TabIndex = 4;
            this.Search_Button.Text = "Szukaj";
            this.Search_Button.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Search_Button.UseSelectable = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel2.Location = new System.Drawing.Point(17, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(147, 29);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Wyszukaj bilans z :";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // DaysStatic_Label
            // 
            this.DaysStatic_Label.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.DaysStatic_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.DaysStatic_Label.Location = new System.Drawing.Point(333, 12);
            this.DaysStatic_Label.Name = "DaysStatic_Label";
            this.DaysStatic_Label.Size = new System.Drawing.Size(140, 29);
            this.DaysStatic_Label.TabIndex = 7;
            this.DaysStatic_Label.Text = "ostatnich dni.";
            this.DaysStatic_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DaysStatic_Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DaysStatic_Label.UseCustomBackColor = true;
            this.DaysStatic_Label.UseCustomForeColor = true;
            // 
            // Summary_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(724, 168);
            this.Controls.Add(this.MainContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Summary_Form";
            this.Resizable = false;
            this.Text = "Podsumowanie:";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainContainer;
        private MetroFramework.Controls.MetroComboBox BalancePeroid_Combobox;
        private MetroFramework.Controls.MetroButton Search_Button;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel DaysStatic_Label;
    }
}