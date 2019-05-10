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
        Dlya_Administratora _DA = new Dlya_Administratora();
        Reg_Info _RI = new Reg_Info();
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSetNewVariant.Registracia_polzovatelya". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelyaTableAdapter.Fill(this.melans_LLCDataSetNewVariant.Registracia_polzovatelya);
            MainWindow _MW = new MainWindow();
            _MW.Button_Admin.Visible = false;
            _MW.Button_Injener.Visible = false;
            _MW.Button_Otdel_Kadrov.Visible = false;
            _MW.Button_Sys_Admin.Visible = false;
            //_CB.CheckZadachPolzProcessZaversh();   
            //if (Program.Status_RegPolzOsv == "Работает" || Program.Status_RegPolzOsv == "Свободен")
            //{
            //    _CB.CheckStatus("Занят", "В процессе");
            //    return;
            //}
            //if (Program.Status_RegPolzZav == "Занят")
            //{
            //    _CB.CheckStatus("Свободен", "Завершена");
            //    return;
            //}
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            try
            {
                if (LoginReg.Text == string.Empty)
                {
                    pictureBox4.Visible = false;
                    MetroFramework.MetroMessageBox.Show(this, "Введите логин!", "Пустое значение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        if (DateTime.Parse(Program.NachRab_RegPolz) > DateTime.Parse(Program.TimeNow) || DateTime.Parse(Program.OkonchRab_RegPolz) < DateTime.Parse(Program.TimeNow))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Вы не можете приступить к работе, так как Вы работаете с " + Program.NachRab_RegPolz + " до " + Program.OkonchRab_RegPolz + ".", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
                            pictureBox4.Visible = false;
                            return;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.OK;
                            bunifuFlatButton1.Enabled = false;
                            bunifuFlatButton2.Enabled = false;
                            bunifuFlatButton3.Enabled = false;
                            PasswordReg.Enabled = false;
                            _CB.EditStatPolz(Convert.ToInt32(Program.Auth_Polz), "Работает");
                            _CB.UpdateRegPolz(_DA.metroGrid18);
                            _RI.Reg_Set(LoginReg.Text, PasswordReg.Text);
                            Program.Log_Polz = LoginReg.Text;
                            Program.Pass_Polz = PasswordReg.Text;
                            _MW.toolStripLabel2.Text = "Вы вошли как: " + LoginReg.Text;
                            _MW.Show();
                            this.Hide();
                            pictureBox4.Visible = false;                                              
                        }
                    }
                    else MetroFramework.MetroMessageBox.Show(this, "Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox4.Visible = false;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message,"Сообщение");
                pictureBox4.Visible = false;
                bunifuFlatButton1.Enabled = true;
                bunifuFlatButton2.Enabled = true;
                bunifuFlatButton3.Enabled = true;
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
                    _CB.StatusCheckPolz();
                    if (Program.Status_ExitSaveStat == 0)
                    {
                        _CB.CheckStatus(Convert.ToInt32(Program.Auth_Polz), Program.StatusRegPolz_Osv);
                    }
                    else
                    {
                        _CB.CheckStatus(Convert.ToInt32(Program.Auth_Polz), Program.StatusRegPolz_Zanyat);
                    }
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
