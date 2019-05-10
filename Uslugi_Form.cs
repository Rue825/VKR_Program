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
    public partial class Uslugi_Form : MetroFramework.Forms.MetroForm
    {
        public Uslugi_Form()
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

        private void Uslugi_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.melans_LLCDataSet.Uslugi);

        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            metroTextBoxID.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            metroTextBoxNameUslug.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            metroTextBoxOpisUslug.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            metroTextBoxCenaUslug.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            metroTextBoxDateCreateUslug.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            metroTextBoxCreateTimeUslug.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Korzina _K = new Korzina();
            if (metroTextBoxNameUslug.Text == string.Empty || metroTextBoxOpisUslug.Text == string.Empty || metroTextBoxDateCreateUslug.Text == string.Empty || metroTextBoxCenaUslug.Text == string.Empty || metroTextBoxCreateTimeUslug.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Выберите услугу!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Program.Znach_Korzina_1 != null || Program.Znach_Korzina_2 != null || Program.Znach_Korzina_3 != null || Program.Znach_Korzina_4 != null || Program.Znach_Korzina_5 != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Услуга уже выбрана!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (_K.metroLabelNameUslug.Text == string.Empty || _K.metroLabelOpisUslug.Text == string.Empty || _K.metroLabelDateCreateUslug.Text == string.Empty || _K.metroLabelTimeCreateUslug.Text == string.Empty)
                {
                    Program.Znach_Korzina_1 = this.metroTextBoxNameUslug.Text;
                    Program.Znach_Korzina_2 = this.metroTextBoxOpisUslug.Text;
                    Program.Znach_Korzina_3 = this.metroTextBoxDateCreateUslug.Text;
                    Program.Znach_Korzina_4 = this.metroTextBoxCreateTimeUslug.Text;
                    Program.Znach_Korzina_5 = this.metroTextBoxCenaUslug.Text;
                    Program.Uslug_ID = Convert.ToInt32(this.metroTextBoxID.Text);
                    MetroFramework.MetroMessageBox.Show(this, "Услуга добавлена в корзину", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
