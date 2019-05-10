﻿using System;
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
    public partial class AddZadach : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base(); //Доступ к классу подключения
        Dlya_Injenera _DJ = new Dlya_Injenera();
        Dlya_Administratora _DA = new Dlya_Administratora();
        public AddZadach() //Перед инициализацией определяем первоначальную тему, а так же последующую, если она была изменена
        {
            InitializeComponent();
            if (GetSetStyleTheme.color == default || GetSetStyleTheme.theme == default)
            {
                this.StyleManager = metroStyleManager1;
            }
            else
            {
                metroStyleManager1.Style = GetSetStyleTheme.color;
                metroStyleManager1.Theme = GetSetStyleTheme.theme;
                this.numericUpDown1.BackColor = GetSetStyleTheme.BackColorMasked;
                this.numericUpDown1.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.numericUpDown2.BackColor = GetSetStyleTheme.BackColorMasked;
                this.numericUpDown2.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.numericUpDown3.BackColor = GetSetStyleTheme.BackColorMasked;
                this.numericUpDown3.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.numericUpDown4.BackColor = GetSetStyleTheme.BackColorMasked;
                this.numericUpDown4.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.StyleManager = metroStyleManager1;
            }
        }

        private void AddZadach_Load(object sender, EventArgs e) //Когда запускается форма выгружаются данные из DataSet
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Zayavk_Info". При необходимости она может быть перемещена или удалена.
            this.zayavk_InfoTableAdapter.Fill(this.melans_LLCDataSet.Zayavk_Info);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet1.Zayavki_NewNum". При необходимости она может быть перемещена или удалена.
            this.zayavki_NewNumTableAdapter.Fill(this.melans_LLCDataSet1.Zayavki_NewNum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_InjSvobodn". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_InjSvobodnTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_InjSvobodn);
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e) //Изменение выбора кнопки в зависимости от выбранного времени
        {
            if (metroRadioButton1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e) //Изменение выбора кнопки в зависимости от выбранного времени
        {
            if (metroRadioButton2.Checked == true)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
            }
        }

        private void metroRadioButton3_CheckedChanged(object sender, EventArgs e) //Изменение выбора кнопки в зависимости от выбранного времени
        {
            if (metroRadioButton3.Checked == true)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Определяем текст в зависимости распределения значений (В часах)
        {
            if (numericUpDown1.Value == 1 || numericUpDown1.Value == 21)
            {
                metroLabel3.Text = "час";
                return;
            }
           
            if (numericUpDown1.Value >= 2 && numericUpDown1.Value <= 4 || numericUpDown1.Value >= 22 && numericUpDown1.Value <= 24)
            {
                metroLabel3.Text = "часа";
                return;
            }

            if (numericUpDown1.Value >= 5 && numericUpDown1.Value <= 20)
            {
                metroLabel3.Text = "часов";
                return;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //Определяем текст в зависимости распределения значений (В минутах)
        {
            if (numericUpDown2.Value == 1 || numericUpDown2.Value == 21 || numericUpDown2.Value == 31 || numericUpDown2.Value == 41 || numericUpDown2.Value == 51)
            {
                metroLabel4.Text = "минута";
                return;
            }
            if (numericUpDown2.Value >= 2 && numericUpDown2.Value <= 4 || numericUpDown2.Value >= 22 && numericUpDown2.Value <= 24 || numericUpDown2.Value >= 32 && numericUpDown2.Value <= 34 || numericUpDown2.Value >= 42 && numericUpDown2.Value <= 44 || numericUpDown2.Value >= 52 && numericUpDown2.Value <= 54)
            {
                metroLabel4.Text = "минуты";
                return;
            }
            if (numericUpDown2.Value >= 5 && numericUpDown2.Value <= 20 || numericUpDown2.Value >= 25 && numericUpDown2.Value <= 30 || numericUpDown2.Value >= 35 && numericUpDown2.Value <= 40 || numericUpDown2.Value >= 45 && numericUpDown2.Value <= 50 || numericUpDown2.Value >= 55 && numericUpDown2.Value <= 60)
            {
                metroLabel4.Text = "минут";
                return;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e) //Определяем текст в зависимости распределения значений (В часах)
        {
            if (numericUpDown4.Value == 1 || numericUpDown4.Value == 21)
            {
                metroLabel6.Text = "час";
                return;
            }

            if (numericUpDown4.Value >= 2 && numericUpDown4.Value <= 4 || numericUpDown4.Value >= 22 && numericUpDown4.Value <= 24)
            {
                metroLabel6.Text = "часа";
                return;
            }

            if (numericUpDown4.Value >= 5 && numericUpDown4.Value <= 20)
            {
                metroLabel6.Text = "часов";
                return;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e) //Определяем текст в зависимости распределения значений (В минутах)
        {
            if (numericUpDown3.Value == 1 || numericUpDown3.Value == 21 || numericUpDown3.Value == 31 || numericUpDown3.Value == 41 || numericUpDown3.Value == 51)
            {
                metroLabel5.Text = "минута";
                return;
            }
            if (numericUpDown3.Value >= 2 && numericUpDown3.Value <= 4 || numericUpDown3.Value >= 22 && numericUpDown3.Value <= 24 || numericUpDown3.Value >= 32 && numericUpDown3.Value <= 34 || numericUpDown3.Value >= 42 && numericUpDown3.Value <= 44 || numericUpDown3.Value >= 52 && numericUpDown3.Value <= 54)
            {
                metroLabel5.Text = "минуты";
                return;
            }
            if (numericUpDown3.Value >= 5 && numericUpDown3.Value <= 20 || numericUpDown3.Value >= 25 && numericUpDown3.Value <= 30 || numericUpDown3.Value >= 35 && numericUpDown3.Value <= 40 || numericUpDown3.Value >= 45 && numericUpDown3.Value <= 50 || numericUpDown3.Value >= 55 && numericUpDown3.Value <= 60)
            {
                metroLabel5.Text = "минут";
                return;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Today;
            DateTime Time = DateTime.Now;
            metroTextBoxDate.Text = Day.ToString("dd.MM.yyyy");
            metroTextBoxTime.Text = Time.ToString("HH:mm");
            if (metroTextBox1.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (metroTextBox1.Text.Length < 5)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле c наименованием задачи должно быть не меньше 5 символов", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (metroComboBox1.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поле должно быть выбрано!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (metroComboBox2.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поле должно быть выбрано!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (metroRadioButton1.Checked == true)
                {
                    _CB.InsertZadachiZHour(metroTextBox1.Text, metroTextBoxDate.Text, metroTextBoxTime.Text, numericUpDown1.Value + " " + metroLabel3.Text, "В процессе", Convert.ToInt32(metroComboBox2.SelectedValue), Convert.ToString(numericUpDown1.Value), Convert.ToInt32(metroComboBox1.SelectedValue));
                    _CB.UpdateZadachi(_DJ.metroGrid1);
                    _CB.CheckStatus(Convert.ToInt32(metroComboBox1.SelectedValue), "Занят");
                    _CB.UpdateRegPolz(_DA.metroGrid18);
                    switch (MetroFramework.MetroMessageBox.Show(this, "Задача добавлена успешно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        case DialogResult.OK:
                            this.Close();
                            break;
                    }
                    return;
                }
                if (metroRadioButton2.Checked == true)
                {
                    _CB.InsertZadachiZMinutes(metroTextBox1.Text, metroTextBoxDate.Text, metroTextBoxTime.Text, numericUpDown2.Value + " " + metroLabel4.Text, "В процессе", Convert.ToInt32(metroComboBox2.SelectedValue), Convert.ToString(numericUpDown2.Value), Convert.ToInt32(metroComboBox1.SelectedValue));
                    _CB.UpdateZadachi(_DJ.metroGrid1);
                    _CB.CheckStatus(Convert.ToInt32(metroComboBox1.SelectedValue), "Занят");
                    _CB.UpdateRegPolz(_DA.metroGrid18);
                    switch (MetroFramework.MetroMessageBox.Show(this, "Задача добавлена успешно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        case DialogResult.OK:
                            this.Close();
                            break;
                    }
                    return;
                }
                if (metroRadioButton3.Checked == true)
                {
                    _CB.InsertZadachiZHourAndMinutes(metroTextBox1.Text, metroTextBoxDate.Text, metroTextBoxTime.Text, numericUpDown4.Value + " " + metroLabel6.Text + " " +numericUpDown3.Value +" "+ metroLabel5.Text, "В процессе", Convert.ToInt32(metroComboBox2.SelectedValue), Convert.ToString(numericUpDown3.Value), Convert.ToString(numericUpDown4.Value), Convert.ToInt32(metroComboBox1.SelectedValue));
                    _CB.UpdateZadachi(_DJ.metroGrid1);
                    _CB.CheckStatus(Convert.ToInt32(metroComboBox1.SelectedValue), "Занят");
                    _CB.UpdateRegPolz(_DA.metroGrid18);
                    switch (MetroFramework.MetroMessageBox.Show(this, "Задача добавлена успешно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        case DialogResult.OK:
                            this.Close();
                            break;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Такая задача уже существует!"+ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Если поле с инженером было пустое, то в этом случае необходимо посмотреть подробную информацию об инженерах. Если свободных инженеров нету, то задачу невозможно добавить до тех пор, пока не освободится инженер и не примет данную задачу.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            Injeneri _Inj = new Injeneri();
            _CB.UpdateRegInj(_Inj.metroGrid1);
            _Inj.ShowDialog();
        }
    }
}