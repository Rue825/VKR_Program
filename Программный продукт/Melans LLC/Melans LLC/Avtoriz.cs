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
    public partial class Avtoriz : Form
    {
        Con_Base _CB = new Con_Base();
        private bool altF4 = false;
        public Avtoriz()
        {
            InitializeComponent();
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e) //Оформление панели
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground((sender as Panel), e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, (sender as Panel).BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelyaTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya);
            MainWindow _MW = new MainWindow();
            _MW.Button_Admin.Visible = false;
            _MW.Button_Injener.Visible = false;
            _MW.Button_Otdel_Kadrov.Visible = false;
            _MW.Button_Sys_Admin.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            try
            {
                if (LoginReg.Text == string.Empty)
                {
                    pictureBox4.Visible = false;
                    MetroFramework.MetroMessageBox.Show(this, "Введите пароль!", "Пустое значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (PasswordReg.Text == string.Empty)
                {
                    pictureBox4.Visible = false;
                    MetroFramework.MetroMessageBox.Show(this, "Введите пароль!", "Пустое значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MainWindow _MW = new MainWindow();
                switch (LoginReg.SelectedValue)
                {
                    case (1):
                        _MW.Button_Admin.Visible = true;
                        _MW.Button_Injener.Visible = true;
                        _MW.Button_Otdel_Kadrov.Visible = true;
                        _MW.Button_Sys_Admin.Visible = true;
                        break;
                    case (2):
                        _MW.Button_Admin.Visible = false;
                        _MW.Button_Injener.Visible = true;
                        _MW.Button_Otdel_Kadrov.Visible = false;
                        _MW.Button_Sys_Admin.Visible = false;
                        break;
                    case (3):
                        _MW.Button_Admin.Visible = false;
                        _MW.Button_Injener.Visible = false;
                        _MW.Button_Otdel_Kadrov.Visible = true;
                        _MW.Button_Sys_Admin.Visible = false;
                        break;
                    case (4):
                        _MW.Button_Admin.Visible = false;
                        _MW.Button_Injener.Visible = false;
                        _MW.Button_Otdel_Kadrov.Visible = false;
                        _MW.Button_Sys_Admin.Visible = true;
                        break;
                    case (5):
                        _MW.Button_Admin.Visible = false;
                        _MW.Button_Injener.Visible = false;
                        _MW.Button_Otdel_Kadrov.Visible = false;
                        _MW.Button_Sys_Admin.Visible = false;
                        break;
                }
                if (_CB.SearchRegPolz(LoginReg.Text, PasswordReg.Text) == 1)
                {
                    this.DialogResult = DialogResult.OK;
                    bunifuFlatButton1.Enabled = false;
                    PasswordReg.Enabled = false;
                    _MW.toolStripLabel2.Text = "Вы вошли как: " + LoginReg.Text;
                    _MW.Show();
                    this.Hide();
                }
                else MetroFramework.MetroMessageBox.Show(this,"Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pictureBox4.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void Avtoriz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                altF4 = true;
            }
        }

        private void Avtoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altF4)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                altF4 = false;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            switch (MetroFramework.MetroMessageBox.Show(this,"Завершить работу приложения?", "Melanc_LLC", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    this.Enabled = true;
                    break;
            }
        }

        private void Avtoriz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Vosstanovlenie_parolya _VP = new Vosstanovlenie_parolya();
            _VP.ShowDialog();
        }
    }
}
