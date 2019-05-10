using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class Registracia : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();
        Dlya_Administratora _DA = new Dlya_Administratora();
        public Registracia()
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
                this.maskedTextBoxTel_RegPolz.BackColor = GetSetStyleTheme.BackColorMasked;
                this.maskedTextBoxTel_RegPolz.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.StyleManager = metroStyleManager1;
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (metroCheckBox1.Checked)
            {
                case (true):
                    metroButton1.Enabled = true;
                    break;
                case (false):
                    metroButton1.Enabled = false;
                    break;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", RegexOptions.IgnoreCase);
            bool matched = reg.Match(metroTextBoxEmail_RegPolz.Text).Success;
            try
            {
                if (metroTextBoxF_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле фамилии не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (metroTextBoxI_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле имени не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (metroTextBoxO_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле отчества не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (metroTextBoxLog_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле логина не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (_CB.Log(metroTextBoxLog_RegPolz.Text) == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Такой логин уже существует!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (metroTextBoxPass_RegPolz.Text == string.Empty || metroTextBoxRepeatPass_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле с паролем не заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (metroTextBoxEmail_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле с электронной почтой не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (metroTextBoxPass_RegPolz.Text != metroTextBoxRepeatPass_RegPolz.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пароли не совпадают!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (matched == false)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Некорректный ввод электронной почты!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (metroTextBoxDolj_RegPolz.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле с должностью не заполнено", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (maskedTextBoxTel_RegPolz.MaskCompleted)
                {

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле с телефоном должно быть указано корректно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                switch (metroComboBoxRole_RegPolz.SelectedIndex)
                {
                    case 0:
                        {
                            metroTextBoxRole.Text = "1";
                            break;
                        }
                    case 1:
                        {
                            metroTextBoxRole.Text = "2";
                            break;
                        }
                    case 2:
                        {
                            metroTextBoxRole.Text = "3";
                            break;
                        }
                    case 3:
                        {
                            metroTextBoxRole.Text = "4";
                            break;
                        }
                    case 4:
                        {
                            metroTextBoxRole.Text = "5";
                            break;
                        }
                }
                if (_CB.CreateDolj(metroTextBoxDolj_RegPolz.Text) != 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Регистрация прошла успешно", "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroTextBoxDoljInt.Text = Convert.ToString(Program.Dolj_ID);
                    metroButton1.Enabled = false;
                    metroCheckBox1.Enabled = false;
                    if (_CB.CreateDanniePolz(metroTextBoxF_RegPolz.Text, metroTextBoxI_RegPolz.Text, metroTextBoxO_RegPolz.Text, metroTextBoxEmail_RegPolz.Text, maskedTextBoxTel_RegPolz.Text, metroTextBoxLog_RegPolz.Text, metroTextBoxPass_RegPolz.Text, Convert.ToInt32(metroTextBoxRole.Text), Convert.ToInt32(metroTextBoxDoljInt.Text), "Свободен", "09:00", "19:00", "0", Convert.ToInt32(metroComboTech_RegPolz.SelectedValue)) == 1)
                    {
                        _CB.UpdateDolj(_DA.metroGrid17);
                        _CB.UpdateRegPolz(_DA.metroGrid18);
                        this.Close();
                    }
                    return;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Регистрация не успешна, проверьте правильность написания полей и повторите попытку", "Предупреждение о некорректном вводе", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Registracia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSetNewVariant.Technika". При необходимости она может быть перемещена или удалена.
            this.technikaTableAdapter.Fill(this.melans_LLCDataSetNewVariant.Technika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.melans_LLCDataSet.Role);

        }
    }
}
