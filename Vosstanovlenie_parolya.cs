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
    public partial class Vosstanovlenie_parolya : Form
    {
        Con_Base _CB = new Con_Base();
        public Vosstanovlenie_parolya()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поле не может быть пустым!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (_CB.Email(metroTextBox1.Text) == 1)
                    {
                        metroTextBox2.Text = Convert.ToString(Program.Login_RegPolz);
                        metroTabPage1.Parent = null;
                        metroTabPage2.Parent = metroTabControl1;
                        this.metroTabControl1.SelectedIndex = 1;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Такая электронная почта не существует!");
                    }
                }
                catch (Exception)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Такая электронная почта не существует!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Vosstanovlenie_parolya_Load(object sender, EventArgs e)
        {
            metroTabPage2.Parent = null;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text == string.Empty || metroTextBox4.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поля пароля не могут быть пустыми!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (metroTextBox3.Text == metroTextBox4.Text)
                {
                    try
                    {
                        _CB.EditPassAutoriz(metroTextBox2.Text, metroTextBox4.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Пароль успешно изменен", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metroTextBox3.ReadOnly = true;
                        metroTextBox4.ReadOnly = true;
                        metroButton2.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля не совпадают!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
