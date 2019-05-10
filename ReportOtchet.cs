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
    public partial class ReportOtchet : MetroFramework.Forms.MetroForm
    {
        public ReportOtchet()
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

        private void ReportOtchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Melans_LLCDataSet.Zadachi". При необходимости она может быть перемещена или удалена.
            this.ZadachiTableAdapter.Fill(this.Melans_LLCDataSet.Zadachi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "Melans_LLCDataSet.Registracia_polzovatelya_RegPolzInj". При необходимости она может быть перемещена или удалена.
            this.Registracia_polzovatelya_RegPolzInjTableAdapter.Fill(this.Melans_LLCDataSet.Registracia_polzovatelya_RegPolzInj);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
