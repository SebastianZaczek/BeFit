namespace BeFit.Forms
{
    partial class GiveUserInfo_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveUserInfo_Form));
            this.Info_Label = new MetroFramework.Controls.MetroLabel();
            this.OK_Button = new MetroFramework.Controls.MetroButton();
            this.Cancel_Button = new MetroFramework.Controls.MetroButton();
            this.Tooltip = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // Info_Label
            // 
            this.Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.Info_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Info_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Info_Label.ForeColor = System.Drawing.Color.DarkGray;
            this.Info_Label.Location = new System.Drawing.Point(23, 75);
            this.Info_Label.Name = "Info_Label";
            this.Info_Label.Size = new System.Drawing.Size(355, 82);
            this.Info_Label.TabIndex = 0;
            this.Info_Label.Text = "metroLabel1";
            this.Info_Label.UseCustomBackColor = true;
            this.Info_Label.UseCustomForeColor = true;
            this.Info_Label.WrapToLine = true;
            // 
            // OK_Button
            // 
            this.OK_Button.BackColor = System.Drawing.Color.Transparent;
            this.OK_Button.BackgroundImage = global::BeFit.Properties.Resources.ok;
            this.OK_Button.Location = new System.Drawing.Point(300, 170);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(50, 50);
            this.OK_Button.TabIndex = 2;
            this.OK_Button.UseSelectable = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click_1);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.BackgroundImage = global::BeFit.Properties.Resources.cancel_icon;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(370, 170);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(50, 50);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.UseSelectable = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
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
            // GiveUserInfo
            // 
            this.AcceptButton = this.OK_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(447, 226);
            this.Controls.Add(this.OK_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Info_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiveUserInfo";
            this.Resizable = false;
            this.Text = "GiveUserInfo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.GiveUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Info_Label;
        private MetroFramework.Controls.MetroButton Cancel_Button;
        private MetroFramework.Controls.MetroButton OK_Button;
        private MetroFramework.Components.MetroToolTip Tooltip;
    }
}