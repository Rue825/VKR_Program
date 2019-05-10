using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class Injeneri : MetroFramework.Forms.MetroForm
    {
        public Injeneri()
        {
            InitializeComponent();
            if (GetSetStyleTheme.color == default || GetSetStyleTheme.theme == default)
            {
                this.StyleManager = metroStyleManager1;
            }
            else
            {
                this.BackImage = GetSetStyleTheme.logo;
                metroStyleManager1.Style = GetSetStyleTheme.color;
                metroStyleManager1.Theme = GetSetStyleTheme.theme;
                this.StyleManager = metroStyleManager1;
            }
        }

        private void Injeneri_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_InjFullStatus". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_InjFullStatusTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_InjFullStatus);

        }
    }
}
