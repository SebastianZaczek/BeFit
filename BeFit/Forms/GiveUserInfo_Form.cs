using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFit.Forms
{
    public partial class GiveUserInfo_Form : MetroFramework.Forms.MetroForm
    {
        public GiveUserInfo_Form(bool IsError, string info)
        {
            InitializeComponent();
            Cancel_Button.Visible = false;
            OK_Button.Location = Cancel_Button.Location;
            Info_Label.Text = info;
            if (!IsError)
            {
                this.ForeColor = Color.LightGreen;
                this.Text = "Info";
            }
            else
            {
                this.Text = "Błąd";
            }
            this.ShowDialog();
        }
        public GiveUserInfo_Form(string info)
        {
            InitializeComponent();
            this.Text = "Potwierdź:";
            Info_Label.Text = info;
            this.ShowDialog();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
            this.Close();
        }

        private void OK_Button_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            this.Close();
        }

        private void GiveUserInfo_Load(object sender, EventArgs e)
        {
            Tooltip.SetToolTip(this.OK_Button, "OK");
            Tooltip.SetToolTip(this.Cancel_Button, "Anuluj");
        }
    }
}
