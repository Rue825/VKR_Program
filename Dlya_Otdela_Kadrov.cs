using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class Dlya_Otdela_Kadrov : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();
        public Dlya_Otdela_Kadrov()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.InsertSobes(metroDateTime1.Text, metroDateTime4.Text, Convert.ToInt32(metroYes2.Checked), Convert.ToInt32(metroComboBox1.SelectedValue), Convert.ToInt32(metroComboBox2.SelectedValue));
                _CB.UpdateSobes(metroGrid1);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Dlya_Otdela_Kadrov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.melans_LLCDataSet.Doljnost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Mesto_raboti". При необходимости она может быть перемещена или удалена.
            this.mesto_rabotiTableAdapter.Fill(this.melans_LLCDataSet.Mesto_raboti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Prinyatie_documenta". При необходимости она может быть перемещена или удалена.
            this.prinyatie_documentaTableAdapter.Fill(this.melans_LLCDataSet.Prinyatie_documenta);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Rabotodatel_otdela_kadrov". При необходимости она может быть перемещена или удалена.
            this.rabotodatel_otdela_kadrovTableAdapter.Fill(this.melans_LLCDataSet.Rabotodatel_otdela_kadrov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Grafik_Raboti". При необходимости она может быть перемещена или удалена.
            this.grafik_RabotiTableAdapter.Fill(this.melans_LLCDataSet.Grafik_Raboti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Soiskatel". При необходимости она может быть перемещена или удалена.
            this.soiskatelTableAdapter.Fill(this.melans_LLCDataSet.Soiskatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Pasport". При необходимости она может быть перемещена или удалена.
            this.pasportTableAdapter.Fill(this.melans_LLCDataSet.Pasport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Sobesedovanie". При необходимости она может быть перемещена или удалена.
            this.sobesedovanieTableAdapter.Fill(this.melans_LLCDataSet.Sobesedovanie);
            metroGrid1.Columns[0].Visible = false;
            metroGrid2.Columns[0].Visible = false;
            metroGrid3.Columns[0].Visible = false;
            metroGrid4.Columns[0].Visible = false;
            metroGrid10.Columns[0].Visible = false;
            metroGrid11.Columns[0].Visible = false;
            metroGrid14.Columns[0].Visible = false;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.EditSobes(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()), metroDateTime2.Text, metroDateTime3.Text, Convert.ToInt32(metroYes2.Checked), Convert.ToInt32(metroComboBox6.SelectedValue), Convert.ToInt32(metroComboBox5.SelectedValue));
                _CB.UpdateSobes(metroGrid1);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroGrid1_Click(object sender, EventArgs e)
        {
            metroDateTime2.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            metroDateTime3.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            switch (metroGrid1.CurrentRow.Cells[3].Value)
            {
                case 0:
                    metroNo2.Checked = true;
                    break;
                case 1:
                    metroYes2.Checked = true;
                    break;
            }
            metroComboBox6.SelectedValue = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            metroComboBox5.SelectedValue = metroGrid1.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteSobes(Convert.ToInt32(metroGrid1.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateSobes(metroGrid1);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Для того, чтобы определить время, необходимо кликнуть левой кнопкой мыши и клавишами со стрелками определять время в часах и в минутах, в противном случае можно использовать Num Lock из набора цифр.", "Подсказка для правильного составления времени", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroGrid2_Click(object sender, EventArgs e)
        {
            metroTextBox5.Text = metroGrid2.CurrentRow.Cells[1].Value.ToString();
            metroTextBox6.Text = metroGrid2.CurrentRow.Cells[2].Value.ToString();
            metroTextBox7.Text = metroGrid2.CurrentRow.Cells[3].Value.ToString();
            metroTextBox8.Text = metroGrid2.CurrentRow.Cells[4].Value.ToString();
            metroDateTime8.Text = metroGrid2.CurrentRow.Cells[5].Value.ToString();
            metroDateTime7.Text = metroGrid2.CurrentRow.Cells[6].Value.ToString();
            metroComboBox7.SelectedValue = metroGrid2.CurrentRow.Cells[7].Value.ToString();
        }

        private void metroGrid3_Click(object sender, EventArgs e)
        {
            metroTextBox18.Text = metroGrid3.CurrentRow.Cells[1].Value.ToString();
            metroTextBox17.Text = metroGrid3.CurrentRow.Cells[2].Value.ToString();
            metroTextBox13.Text = metroGrid3.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroGrid4_Click(object sender, EventArgs e)
        {
            metroTextBox19.Text = metroGrid4.CurrentRow.Cells[1].Value.ToString();
            metroDateTime14.Text = metroGrid4.CurrentRow.Cells[2].Value.ToString();
            metroDateTime13.Text = metroGrid4.CurrentRow.Cells[3].Value.ToString();
            metroDateTime12.Text = metroGrid4.CurrentRow.Cells[4].Value.ToString();
            metroComboBox8.SelectedValue = metroGrid4.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroGrid10_Click(object sender, EventArgs e)
        {
            metroTextBox30.Text = metroGrid10.CurrentRow.Cells[1].Value.ToString();
            metroTextBox29.Text = metroGrid10.CurrentRow.Cells[2].Value.ToString();
            metroTextBox26.Text = metroGrid10.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroGrid11_Click(object sender, EventArgs e)
        {
            metroTextBox34.Text = metroGrid11.CurrentRow.Cells[1].Value.ToString();
            metroTextBox33.Text = metroGrid11.CurrentRow.Cells[2].Value.ToString();
            metroDateTime15.Text = metroGrid11.CurrentRow.Cells[3].Value.ToString();
            metroComboBox12.SelectedValue = metroGrid11.CurrentRow.Cells[4].Value.ToString();
            metroComboBox10.SelectedValue = metroGrid11.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroGrid14_Click(object sender, EventArgs e)
        {
            metroTextBox37.Text = metroGrid14.CurrentRow.Cells[1].Value.ToString();
            metroDateTime20.Text = metroGrid14.CurrentRow.Cells[2].Value.ToString();
            metroDateTime18.Text = metroGrid14.CurrentRow.Cells[3].Value.ToString();
            metroComboBox14.SelectedValue = metroGrid14.CurrentRow.Cells[4].Value.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox12.Text == string.Empty || metroTextBox11.Text == string.Empty || metroTextBox10.Text == string.Empty || metroTextBox9.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertPasp(metroTextBox12.Text, metroTextBox11.Text, metroTextBox10.Text, metroTextBox9.Text, metroDateTime6.Text, metroDateTime5.Text, Convert.ToInt32(metroComboBox3.SelectedValue));
                    _CB.UpdatePasp(metroGrid2);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox5.Text == string.Empty || metroTextBox6.Text == string.Empty || metroTextBox7.Text == string.Empty || metroTextBox8.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditPasp(Convert.ToInt32(metroGrid2.CurrentRow.Cells[0].Value.ToString()), metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text, metroTextBox8.Text, metroDateTime8.Text, metroDateTime7.Text, Convert.ToInt32(metroComboBox7.SelectedValue));
                    _CB.UpdatePasp(metroGrid2);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeletePasp(Convert.ToInt32(metroGrid2.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdatePasp(metroGrid2);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox16.Text == string.Empty || metroTextBox15.Text == string.Empty || metroTextBox14.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertSoisk(metroTextBox16.Text, metroTextBox15.Text, metroTextBox14.Text);
                    _CB.UpdateSoisk(metroGrid3);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox18.Text == string.Empty || metroTextBox17.Text == string.Empty || metroTextBox13.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditSoisk(Convert.ToInt32(metroGrid3.CurrentRow.Cells[0].Value.ToString()), metroTextBox18.Text, metroTextBox17.Text, metroTextBox13.Text);
                    _CB.UpdateSoisk(metroGrid3);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteSoisk(Convert.ToInt32(metroGrid3.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateSoisk(metroGrid3);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox23.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (metroDateTime9.Value >= metroDateTime11.Value)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Время начала работы не должна превышать окончания работы!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _CB.InsertGrafRabot(metroTextBox23.Text, metroDateTime10.Text, metroDateTime9.Text, metroDateTime11.Text, Convert.ToInt32(metroComboBox4.SelectedValue));
                        _CB.UpdateGrafRabot(metroGrid4);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox19.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (metroDateTime13.Value >= metroDateTime12.Value)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Время начала работы не должна превышать окончания работы!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _CB.EditGrafRabot(Convert.ToInt32(metroGrid4.CurrentRow.Cells[0].Value.ToString()), metroTextBox19.Text, metroDateTime14.Text, metroDateTime13.Text, metroDateTime12.Text, Convert.ToInt32(metroComboBox8.SelectedValue));
                        _CB.UpdateGrafRabot(metroGrid4);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteGrafRabot(Convert.ToInt32(metroGrid4.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateGrafRabot(metroGrid4);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox25.Text == string.Empty || metroTextBox24.Text == string.Empty || metroTextBox20.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertRabotodatelOK(metroTextBox25.Text, metroTextBox24.Text, metroTextBox20.Text);
                    _CB.UpdateRabotodatelOK(metroGrid10);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox30.Text == string.Empty || metroTextBox29.Text == string.Empty || metroTextBox26.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditRabotodatelOK(Convert.ToInt32(metroGrid10.CurrentRow.Cells[0].Value.ToString()), metroTextBox30.Text, metroTextBox29.Text, metroTextBox26.Text);
                    _CB.UpdateRabotodatelOK(metroGrid10);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteRabotodatelOK(Convert.ToInt32(metroGrid10.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateRabotodatelOK(metroGrid10);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox36.Text == string.Empty || metroTextBox35.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertPrinDOC(metroTextBox36.Text, metroTextBox35.Text, metroDateTime16.Text, Convert.ToInt32(metroComboBox9.SelectedValue), Convert.ToInt32(metroComboBox11.SelectedValue));
                    _CB.UpdatePrinDOC(metroGrid11);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void metroButton17_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox34.Text == string.Empty || metroTextBox33.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditPrinDOC(Convert.ToInt32(metroGrid11.CurrentRow.Cells[0].Value.ToString()), metroTextBox34.Text, metroTextBox33.Text, metroDateTime15.Text, Convert.ToInt32(metroComboBox12.SelectedValue), Convert.ToInt32(metroComboBox10.SelectedValue));
                    _CB.UpdatePrinDOC(metroGrid11);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeletePrinDOC(Convert.ToInt32(metroGrid11.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdatePrinDOC(metroGrid11);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox38.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (metroDateTime17.Value >= metroDateTime19.Value)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Дата принятия работы не должна превышать увольнению работы!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _CB.InsertMr(metroTextBox38.Text, metroDateTime17.Text, metroDateTime19.Text, Convert.ToInt32(metroComboBox13.SelectedValue));
                        _CB.UpdateMr(metroGrid14);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox37.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (metroDateTime20.Value >= metroDateTime18.Value)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Дата принятия работы не должна превышать увольнению работы!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _CB.EditMr(Convert.ToInt32(metroGrid14.CurrentRow.Cells[0].Value.ToString()), metroTextBox37.Text, metroDateTime20.Text, metroDateTime18.Text, Convert.ToInt32(metroComboBox14.SelectedValue));
                        _CB.UpdateMr(metroGrid14);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteMr(Convert.ToInt32(metroGrid14.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateMr(metroGrid14);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Export_Data_To_PDF(DataGridView DGW, string filename) //Экспорт данных в формате PDF
        {
            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF");
            BaseFont BF = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfPTable pdftable = new PdfPTable(DGW.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(BF, 10, iTextSharp.text.Font.NORMAL);

            //Добавление текста
            foreach (DataGridViewColumn column in DGW.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdftable.AddCell(cell);
            }
            //Добавление ячейки
            foreach (DataGridViewRow row in DGW.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefilledialoge = new SaveFileDialog();
            savefilledialoge.FileName = filename;
            savefilledialoge.DefaultExt = ".pdf";
            savefilledialoge.Filter = "PDF Documents (*.pdf)|*.pdf";
            if (savefilledialoge.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefilledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Файл занят другим процессом");
                }
            }
        }
        private void Export_Data_To_XLSX(DataGridView DGW, string filename) //Экспорт данных в Excel
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Вывод данных";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;
 
                for (int i = 0; i < DGW.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGW.Columns.Count; j++)
                    {

                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGW.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGW.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Сохранение документа
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = filename;
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MetroFramework.MetroMessageBox.Show(this, "Документ успешно сохранен", "Успешный экспорт", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        public void Export_Data_To_DOCX(DataGridView DGV, string filename) //Экспорт данных в Word
        {

            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //Добавления ячеек
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;
                //Ориентация страницы
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }
                //Формат таблицы
                oRange.Text = oTemp;
                object oMissing = Missing.Value;
                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                //Стиль текста ячейки
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
                //Добавление ячейки
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //Стиль таблицы
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //Тест
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Отчет";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                try
                {
                    //Сохранение файла
                    oDoc.SaveAs(filename, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Нельзя сохранять документ в запущенном процессе!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid1, "ExportToPDFSobes");
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxSobes.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid1, sfd.FileName);
            }
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid1, "ExportToSobes");
        }

        private void metroButton28_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid2, "ExportToPDFPasp");
        }

        private void metroButton27_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxPasp.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid2, sfd.FileName);
            }
        }

        private void metroButton26_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid2, "ExportToXlsxPasp");
        }

        private void metroButton31_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid3, "ExportToPDFSoisk");
        }

        private void metroButton30_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxSoisk.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid3, sfd.FileName);
            }
        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid3, "ExportToXlsxSoisk");
        }

        private void metroButton34_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid4, "ExportToPDFGrafRabot");
        }

        private void metroButton33_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxGrafRabot.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid4, sfd.FileName);
            }
        }

        private void metroButton32_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid4, "ExportToXlsxGrafRabot");
        }

        private void metroButton37_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid10, "ExportToPDFRabotodatelOK");
        }

        private void metroButton36_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxRabotodatelOK.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid10, sfd.FileName);
            }
        }

        private void metroButton35_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid10, "ExportToXlsxRabotodatelOK");
        }

        private void metroButton40_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid11, "ExportToPDFPrinDOC");
        }

        private void metroButton39_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxPrinDOC.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid11, sfd.FileName);
            }
        }

        private void metroButton38_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid11, "ExportToXlsxPrinDOC");
        }

        private void metroButton43_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid14, "ExportToPDFMr");
        }

        private void metroButton42_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxMr.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid14, sfd.FileName);
            }
        }

        private void metroButton41_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid14, "ExportToXlsxMr");
        }
    }
}
