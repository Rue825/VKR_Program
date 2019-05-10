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
    public partial class Dlya_Systemnogo_Administratora : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();

        public Dlya_Systemnogo_Administratora() //Перед инициализацией определяем первоначальную тему, а так же последующую, если она была изменена
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

        private void Dlya_Systemnogo_Administratora_Load(object sender, EventArgs e) //
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Zayavki_New". При необходимости она может быть перемещена или удалена.
            this.zayavki_NewTableAdapter.Fill(this.melans_LLCDataSet.Zayavki_New);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSetNewVariant.Technika". При необходимости она может быть перемещена или удалена.
            this.technikaTableAdapter1.Fill(this.melans_LLCDataSetNewVariant.Technika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya.Fill(this.melans_LLCDataSet.Registracia_polzovatelya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_SysAdmin". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_SysAdminTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_SysAdmin);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Grafik_Raboti". При необходимости она может быть перемещена или удалена.
            this.grafik_RabotiTableAdapter.Fill(this.melans_LLCDataSet.Grafik_Raboti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.melans_LLCDataSet.Uslugi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.melans_LLCDataSet.Klient);
            
            metroGrid7.Columns[0].Visible = false;
            metroGrid8.Columns[0].Visible = false;
            metroGrid9.Columns[0].Visible = false;
            metroGrid15.Columns[0].Visible = false;
            metroGrid16.Columns[0].Visible = false;
        }

        private void metroGrid7_Click(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroGrid7.CurrentRow.Cells[1].Value.ToString();
            metroComboBox6.SelectedValue = metroGrid7.CurrentRow.Cells[4].Value.ToString();
            metroComboBox5.SelectedValue = metroGrid7.CurrentRow.Cells[6].Value.ToString();
            metroComboBox4.SelectedValue = metroGrid7.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroGrid8_Click(object sender, EventArgs e)
        {
            metroTextBox9.Text = metroGrid8.CurrentRow.Cells[1].Value.ToString();
            metroTextBox8.Text = metroGrid8.CurrentRow.Cells[2].Value.ToString();
            metroTextBox3.Text = metroGrid8.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroGrid9_Click(object sender, EventArgs e)
        {
            metroTextBox20.Text = metroGrid9.CurrentRow.Cells[1].Value.ToString();
            metroDateTime8.Text = metroGrid9.CurrentRow.Cells[2].Value.ToString();
            metroDateTime7.Text = metroGrid9.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroGrid16_Click(object sender, EventArgs e)
        {
            metroTextBox32.Text = metroGrid16.CurrentRow.Cells[1].Value.ToString();
            metroTextBox31.Text = metroGrid16.CurrentRow.Cells[2].Value.ToString();
            metroTextBox26.Text = metroGrid16.CurrentRow.Cells[3].Value.ToString();
            metroDateTime12.Text = metroGrid16.CurrentRow.Cells[4].Value.ToString();
            metroDateTime11.Text = metroGrid16.CurrentRow.Cells[5].Value.ToString();
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Для того, чтобы определить время, необходимо кликнуть левой кнопкой мыши и клавишами со стрелками определять время в часах и в минутах, в противном случае можно использовать Num Lock из набора цифр.", "Подсказка для правильного составления времени", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Today;
            DateTime Time = DateTime.Now;
            Program.DateZayavk = Day.ToString("dd.MM.yyyy");
            Program.TimeZayavk = Time.ToString("HH:mm");
            try
            {
                if (metroTextBox16.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertZayavk(metroTextBox16.Text, Program.DateZayavk, Program.TimeZayavk, Convert.ToInt32(metroComboBox2.SelectedValue), Convert.ToInt32(metroComboBox7.SelectedValue), Convert.ToInt32(metroComboBox3.SelectedValue));
                    _CB.UpdateZayavk(metroGrid7);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroTextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteZayavk(Convert.ToInt32(metroGrid7.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateZayavk(metroGrid7);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox2.Text == string.Empty || metroTextBox6.Text == string.Empty || metroTextBox7.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertKl(metroTextBox2.Text, metroTextBox6.Text, metroTextBox7.Text);
                    _CB.UpdateKl(metroGrid8);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox9.Text == string.Empty || metroTextBox8.Text == string.Empty || metroTextBox3.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditKl(Convert.ToInt32(metroGrid8.CurrentRow.Cells[0].Value.ToString()), metroTextBox9.Text, metroTextBox8.Text, metroTextBox3.Text);
                    _CB.UpdateKl(metroGrid8);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                _CB.DeleteKl(Convert.ToInt32(metroGrid8.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateKl(metroGrid8);
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
                if (metroTextBox19.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertTech(metroTextBox19.Text, metroDateTime6.Text, metroDateTime5.Text);
                    _CB.UpdateTech(metroGrid9);
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
                if (metroTextBox20.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditTech(Convert.ToInt32(metroGrid9.CurrentRow.Cells[0].Value.ToString()), metroTextBox20.Text, metroDateTime8.Text, metroDateTime7.Text);
                    _CB.UpdateTech(metroGrid9);
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
                _CB.DeleteTech(Convert.ToInt32(metroGrid9.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateTech(metroGrid9);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (metroTextBox12.Text == string.Empty || metroTextBox11.Text == string.Empty || metroTextBox10.Text == string.Empty || metroComboBox11.Text == string.Empty)
            //    {
            //        MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        _CB.InsertSysAdmin(metroTextBox12.Text, metroTextBox11.Text, metroTextBox10.Text, metroComboBox11.Text);
            //        _CB.UpdateSysAdmin(metroGrid15);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        //private void metroButton5_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (metroTextBox15.Text == string.Empty || metroTextBox14.Text == string.Empty || metroTextBox13.Text == string.Empty || metroComboBox12.Text == string.Empty)
        //        {
        //            MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //        else
        //        {
        //            _CB.EditSysAdmin(Convert.ToInt32(metroGrid15.CurrentRow.Cells[0].Value.ToString()), metroTextBox15.Text, metroTextBox14.Text, metroTextBox13.Text, metroComboBox12.Text);
        //            _CB.UpdateSysAdmin(metroGrid15);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        //private void metroButton6_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _CB.DeleteSysAdmin(Convert.ToInt32(metroGrid15.CurrentRow.Cells[0].Value.ToString()));
        //        _CB.UpdateSysAdmin(metroGrid15);
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        private void metroButton13_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox25.Text == string.Empty || metroTextBox29.Text == string.Empty || metroTextBox30.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertUslug(metroTextBox25.Text, metroTextBox29.Text, metroTextBox30.Text, metroDateTime10.Text, metroDateTime9.Text);
                    _CB.UpdateUslug(metroGrid16);
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
                if (metroTextBox32.Text == string.Empty || metroTextBox31.Text == string.Empty || metroTextBox26.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditUslug(Convert.ToInt32(metroGrid16.CurrentRow.Cells[0].Value.ToString()), metroTextBox32.Text, metroTextBox31.Text, metroTextBox26.Text, metroDateTime12.Text, metroDateTime11.Text);
                    _CB.UpdateUslug(metroGrid16);
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
                _CB.DeleteUslug(Convert.ToInt32(metroGrid16.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateUslug(metroGrid16);
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

        public void Export_Data_To_XLSX(DataGridView DGW, string filename)
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

        private void metroButton16_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid7, "ExportToPDFZayavki");
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxZayavki.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid7, sfd.FileName);
            }
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid7, "ExportToXlsxZayavki");
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid8, "ExportToPDFKlient");
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxKlient.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid8, sfd.FileName);
            }
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid8, "ExportToXlsxKlient");
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid9, "ExportToPDFTech");
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxTech.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid9, sfd.FileName);
            }
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid9, "ExportToXlsxTech");
        }

        private void metroButton28_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid15, "ExportToPDFSysAdmin");
        }

        private void metroButton27_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxSysAdmin.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid15, sfd.FileName);
            }
        }

        private void metroButton26_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid15, "ExportToXlsxSysAdmin");
        }

        private void metroButton31_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid16, "ExportToPDFUslug");
        }

        private void metroButton30_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxUslug.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid16, sfd.FileName);
            }
        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid16, "ExportToXlsxUslug");
        }

        private void metroButton32_Click(object sender, EventArgs e)
        {
            AddZadach addZadach = new AddZadach();
            addZadach.ShowDialog();
        }
    }
}
