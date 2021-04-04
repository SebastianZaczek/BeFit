using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit.User_Controls
{
    public partial class Option_Button : MetroFramework.Controls.MetroUserControl
    {
        [Bindable(true)]
        [Localizable(true)]
        public Image Tile_Image
        {
            get => this.Main_Tile.TileImage;
            set => this.Main_Tile.TileImage = value;
        }
        public string TileText
        {
            get => this.Main_Tile.Text;
            set => this.Main_Tile.Text = value;
        }


        public Option_Button()
        {
            InitializeComponent();
            this.Width = 152;
            this.Height = 82;
            this.Main_Tile.Location = new Point(5, 5);
            this.Main_Tile.Size = new Size(140, 70);

        }
        public Option_Button(string tile_text, Image image)
        {
            InitializeComponent();
            this.Main_Tile.Text = tile_text;
            this.Main_Tile.TileImage = image;
        }

        private void Click_Event(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void Option_Button_EnabledChanged(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                this.Main_Tile.BackColor = MetroFramework.MetroColors.Black;

            }


            else
            {
                this.Main_Tile.BackColor = Color.DimGray;
            }
        }
    }
}
