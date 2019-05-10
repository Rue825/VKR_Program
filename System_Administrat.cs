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
    public partial class System_Administrat : MetroFramework.Forms.MetroForm
    {
        public System_Administrat()
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

        private void System_Administrat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_FullStatusSysAdm". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_FullStatusSysAdmTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_FullStatusSysAdm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_FullStatusSysAdm". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_FullStatusSysAdmTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_FullStatusSysAdm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_ZayavkSysStat". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_ZayavkSysStatTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_ZayavkSysStat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_SysAdmin". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_SysAdminTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_SysAdmin);

        }
    }
}
