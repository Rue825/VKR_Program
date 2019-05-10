using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Melans_LLC
{
    public partial class Settings_Interface : MetroForm
    {
        Dlya_Administratora _DA = new Dlya_Administratora();
        public Settings_Interface()
        {
            InitializeComponent();
            if (GetSetStyleTheme.color == default || GetSetStyleTheme.theme == default)
            {
                this.StyleManager = MSMMain;
            }
            else
            {
                this.BackImage = GetSetStyleTheme.logo;
                MSMMain.Style = GetSetStyleTheme.color;
                MSMMain.Theme = GetSetStyleTheme.theme;
                this.StyleManager = MSMMain;
            }

        }
        private void Settings_Interface_Load(object sender, EventArgs e)
        {
          
        }

        private void Settings_Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
