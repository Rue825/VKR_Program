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
    public partial class Dlya_Injenera : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();

        public Dlya_Injenera()
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

        private void Dlya_Injenera_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Zadachi". При необходимости она может быть перемещена или удалена.
            this.zadachiTableAdapter.Fill(this.melans_LLCDataSet.Zadachi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Instructaj". При необходимости она может быть перемещена или удалена.
            this.instructajTableAdapter.Fill(this.melans_LLCDataSet.Instructaj);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Soiskatel". При необходимости она может быть перемещена или удалена.
            this.soiskatelTableAdapter.Fill(this.melans_LLCDataSet.Soiskatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Vid_instructaja". При необходимости она может быть перемещена или удалена.
            this.vid_instructajaTableAdapter.Fill(this.melans_LLCDataSet.Vid_instructaja);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Injener". При необходимости она может быть перемещена или удалена.
            this.injenerTableAdapter.Fill(this.melans_LLCDataSet.Injener);
            metroGrid5.Columns[0].Visible = false;
            metroGrid6.Columns[0].Visible = false;
            metroGrid12.Columns[0].Visible = false;
            metroGrid13.Columns[0].Visible = false;
        }

        private void metroTextBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void metroGrid5_Click(object sender, EventArgs e)
        {
            metroTextBox3.Text = metroGrid5.CurrentRow.Cells[1].Value.ToString();
            metroTextBox2.Text = metroGrid5.CurrentRow.Cells[2].Value.ToString();
            metroDateTime3.Text = metroGrid5.CurrentRow.Cells[3].Value.ToString();
            metroDateTime2.Text = metroGrid5.CurrentRow.Cells[4].Value.ToString();
            switch (metroGrid5.CurrentRow.Cells[5].Value)
            {
                case 0:
                    metroNo2.Checked = true;
                    break;
                case 1:
                    metroYes2.Checked = true;
                    break;
            }
            metroComboBox6.SelectedValue = metroGrid5.CurrentRow.Cells[6].Value.ToString();
            metroComboBox5.SelectedValue = metroGrid5.CurrentRow.Cells[7].Value.ToString();
            metroComboBox4.SelectedValue = metroGrid5.CurrentRow.Cells[8].Value.ToString();
        }

        private void metroGrid6_Click(object sender, EventArgs e)
        {
            metroTextBox4.Text = metroGrid6.CurrentRow.Cells[1].Value.ToString();
        }

        private void metroGrid12_Click(object sender, EventArgs e)
        {
            metroTextBox15.Text = metroGrid12.CurrentRow.Cells[1].Value.ToString();
            metroTextBox14.Text = metroGrid12.CurrentRow.Cells[2].Value.ToString();
            metroTextBox7.Text = metroGrid12.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroGrid13_Click(object sender, EventArgs e)
        {
            metroTextBox24.Text = metroGrid13.CurrentRow.Cells[1].Value.ToString();
            metroTextBox23.Text = metroGrid13.CurrentRow.Cells[2].Value.ToString();
            metroTextBox20.Text = metroGrid13.CurrentRow.Cells[3].Value.ToString();
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Для того, чтобы определить время, необходимо кликнуть левой кнопкой мыши и клавишами со стрелками определять время в часах и в минутах, в противном случае можно использовать Num Lock из набора цифр.", "Подсказка для правильного составления времени", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox16.Text == string.Empty || metroTextBox1.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertInst(metroTextBox16.Text, metroTextBox1.Text, metroDateTime1.Text, metroDateTime4.Text, Convert.ToInt32(metroYes1.Checked), Convert.ToInt32(metroComboBox1.SelectedValue), Convert.ToInt32(metroComboBox2.SelectedValue), Convert.ToInt32(metroComboBox3.SelectedValue));
                    _CB.UpdateInst(metroGrid5);
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
                if (metroTextBox3.Text == string.Empty || metroTextBox2.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditInst(Convert.ToInt32(metroGrid5.CurrentRow.Cells[0].Value.ToString()), metroTextBox3.Text, metroTextBox2.Text, metroDateTime3.Text, metroDateTime2.Text, Convert.ToInt32(metroYes2.Checked), Convert.ToInt32(metroComboBox6.SelectedValue), Convert.ToInt32(metroComboBox5.SelectedValue), Convert.ToInt32(metroComboBox4.SelectedValue));
                    _CB.UpdateInst(metroGrid5);
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
                _CB.DeleteInst(Convert.ToInt32(metroGrid5.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateInst(metroGrid5);
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
                if (metroTextBox5.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertVInst(metroTextBox5.Text);
                    _CB.UpdateVInst(metroGrid6);
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
                if (metroTextBox4.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditVInst(Convert.ToInt32(metroGrid6.CurrentRow.Cells[0].Value.ToString()), metroTextBox4.Text);
                    _CB.UpdateVInst(metroGrid6);
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
                _CB.DeleteVInst(Convert.ToInt32(metroGrid6.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateVInst(metroGrid6);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Нельзя удалить данные, которые ссылаются на другую таблицу! " + ex.Message, "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox6.Text == string.Empty || metroTextBox12.Text == string.Empty || metroTextBox13.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertInj(metroTextBox6.Text, metroTextBox12.Text, metroTextBox13.Text);
                    _CB.UpdateInj(metroGrid12);
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
                if (metroTextBox15.Text == string.Empty || metroTextBox14.Text == string.Empty || metroTextBox7.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditInj(Convert.ToInt32(metroGrid12.CurrentRow.Cells[0].Value.ToString()), metroTextBox15.Text, metroTextBox14.Text, metroTextBox7.Text);
                    _CB.UpdateInj(metroGrid12);
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
                _CB.DeleteInj(Convert.ToInt32(metroGrid12.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateInj(metroGrid12);
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
                if (metroTextBox19.Text == string.Empty || metroTextBox18.Text == string.Empty || metroTextBox17.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertSoisk(metroTextBox19.Text, metroTextBox18.Text, metroTextBox17.Text);
                    _CB.UpdateSoisk(metroGrid13);
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
                if (metroTextBox24.Text == string.Empty || metroTextBox23.Text == string.Empty || metroTextBox20.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditSoisk(Convert.ToInt32(metroGrid13.CurrentRow.Cells[0].Value.ToString()), metroTextBox24.Text, metroTextBox23.Text, metroTextBox20.Text);
                    _CB.UpdateSoisk(metroGrid13);
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
                _CB.DeleteSoisk(Convert.ToInt32(metroGrid13.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateSoisk(metroGrid13);
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
            Export_Data_To_PDF(metroGrid5, "ExportToPDFInst");
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxInst.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid5, sfd.FileName);
            }
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid5, "ExportToXlsxInst");
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid6, "ExportToPDFVInst");
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxVInst.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid6, sfd.FileName);
            }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid6, "ExportToXlsxVInst");
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid12, "ExportToPDFInj");
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxInj.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid12, sfd.FileName);
            }
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid12, "ExportToXlsxInj");
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid13, "ExportToPDFSoisk");
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxSoisk.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid13, sfd.FileName);
            }
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid13, "ExportToXlsxSoisk");
        }

        private void metroButton26_Click(object sender, EventArgs e)
        {

        }
    }
}
