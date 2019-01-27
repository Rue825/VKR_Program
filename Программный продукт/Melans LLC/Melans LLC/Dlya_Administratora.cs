using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class Dlya_Administratora : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();
        public Dlya_Administratora()
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
                this.maskedTextBox1.BackColor = GetSetStyleTheme.BackColorMasked;
                this.maskedTextBox1.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.maskedTextBox2.BackColor = GetSetStyleTheme.BackColorMasked;
                this.maskedTextBox2.ForeColor = GetSetStyleTheme.ForeColorMasked;
                this.StyleManager = metroStyleManager1;
            }         
        }

        private void Dlya_Administratora_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.melans_LLCDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelyaTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Doljnost". При необходимости она может быть перемещена или удалена.
            this.doljnostTableAdapter.Fill(this.melans_LLCDataSet.Doljnost);
            metroGrid17.Columns[0].Visible = false;
            metroGrid18.Columns[0].Visible = false;
            metroGrid20.Columns[0].Visible = false;
        }

        private void metroGrid17_Click(object sender, EventArgs e)
        {
            metroTextBox18.Text = metroGrid17.CurrentRow.Cells[1].Value.ToString();
        }

        private void metroGrid18_Click(object sender, EventArgs e)
        {
            metroTextBox17.Text = metroGrid18.CurrentRow.Cells[1].Value.ToString();
            metroTextBox15.Text = metroGrid18.CurrentRow.Cells[2].Value.ToString();
            metroTextBox14.Text = metroGrid18.CurrentRow.Cells[3].Value.ToString();
            metroTextBox13.Text = metroGrid18.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox2.Text = metroGrid18.CurrentRow.Cells[5].Value.ToString();
            metroTextBox11.Text = metroGrid18.CurrentRow.Cells[6].Value.ToString();
            metroTextBox2.Text = metroGrid18.CurrentRow.Cells[7].Value.ToString();
            metroComboBox3.SelectedValue = metroGrid18.CurrentRow.Cells[8].Value.ToString();
            metroComboBox2.SelectedValue = metroGrid18.CurrentRow.Cells[9].Value.ToString();
        }

        private void metroGrid20_Click(object sender, EventArgs e)
        {
            metroTextBox20.Text = metroGrid20.CurrentRow.Cells[1].Value.ToString();
            switch (metroGrid20.CurrentRow.Cells[2].Value)
            {
                case 0:
                    metroRoleNo1.Checked = true;
                    break;
                case 1:
                    metroRoleYes1.Checked = true;
                    break;
            }
            switch (metroGrid20.CurrentRow.Cells[3].Value)
            {
                case 0:
                    metroRoleNo2.Checked = true;
                    break;
                case 1:
                    metroRoleYes2.Checked = true;
                    break;
            }
            switch (metroGrid20.CurrentRow.Cells[4].Value)
            {
                case 0:
                    metroRoleNo3.Checked = true;
                    break;
                case 1:
                    metroRoleYes3.Checked = true;
                    break;
            }
            switch (metroGrid20.CurrentRow.Cells[5].Value)
            {
                case 0:
                    metroRoleNo4.Checked = true;
                    break;
                case 1:
                    metroRoleYes4.Checked = true;
                    break;
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroTextBox16.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertDolj(metroTextBox16.Text);
                    _CB.UpdateDolj(metroGrid17);
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
                if (metroTextBox18.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditDolj(Convert.ToInt32(metroGrid17.CurrentRow.Cells[0].Value.ToString()), metroTextBox18.Text);
                    _CB.UpdateDolj(metroGrid17);
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
                _CB.DeleteDolj(Convert.ToInt32(metroGrid17.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateDolj(metroGrid17);
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
                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", RegexOptions.IgnoreCase);
                bool matched = reg.Match(metroTextBox7.Text).Success;
                if (matched == true)
                {
                    if (metroTextBox1.Text == string.Empty || metroTextBox5.Text == string.Empty || metroTextBox6.Text == string.Empty || metroTextBox7.Text == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (maskedTextBox1.MaskCompleted)
                        {
                            _CB.InsertRegPolz(metroTextBox1.Text, metroTextBox5.Text, metroTextBox6.Text, metroTextBox7.Text, maskedTextBox1.Text, metroTextBox9.Text, metroTextBox10.Text, Convert.ToInt32(metroComboBox5.SelectedValue), Convert.ToInt32(metroComboBox1.SelectedValue));
                            _CB.UpdateRegPolz(metroGrid18);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Поле с телефоном должно быть указано корректно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Некорректный ввод электронной почты!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$", RegexOptions.IgnoreCase);
                bool matched = reg.Match(metroTextBox13.Text).Success;
                if (matched == true)
                {
                    if (metroTextBox17.Text == string.Empty || metroTextBox15.Text == string.Empty || metroTextBox14.Text == string.Empty || metroTextBox13.Text == string.Empty || metroTextBox11.Text == string.Empty || metroTextBox2.Text == string.Empty)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Поля должны быть все заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (maskedTextBox2.MaskCompleted)
                        {
                            _CB.EditRegPolz(Convert.ToInt32(metroGrid18.CurrentRow.Cells[0].Value.ToString()), metroTextBox17.Text, metroTextBox15.Text, metroTextBox14.Text, metroTextBox13.Text, maskedTextBox2.Text, metroTextBox11.Text, metroTextBox2.Text, Convert.ToInt32(metroComboBox3.SelectedValue), Convert.ToInt32(metroComboBox2.SelectedValue));
                            _CB.UpdateRegPolz(metroGrid18);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Поле с телефоном должно быть указано корректно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Некорректный ввод электронной почты!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                _CB.DeleteRegPolz(Convert.ToInt32(metroGrid18.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateRegPolz(metroGrid18);
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
                if (metroTextBox19.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.InsertRole(metroTextBox19.Text, Convert.ToInt32(metroYes2.Checked), Convert.ToInt32(metroYes3.Checked), Convert.ToInt32(metroYes4.Checked), Convert.ToInt32(metroYes5.Checked));
                    _CB.UpdateRole(metroGrid20);
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
                if (metroTextBox20.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Поле должно быть заполнено!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _CB.EditRole(Convert.ToInt32(metroGrid20.CurrentRow.Cells[0].Value.ToString()), metroTextBox20.Text, Convert.ToInt32(metroRoleYes1.Checked), Convert.ToInt32(metroRoleYes2.Checked), Convert.ToInt32(metroRoleYes3.Checked), Convert.ToInt32(metroRoleYes4.Checked));
                    _CB.UpdateRole(metroGrid20);
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
                _CB.DeleteRole(Convert.ToInt32(metroGrid20.CurrentRow.Cells[0].Value.ToString()));
                _CB.UpdateRole(metroGrid20);
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
            Export_Data_To_PDF(metroGrid17, "ExportToPDFDolj");
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxDolj.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid17, sfd.FileName);
            }
        }

        private void metroButton18_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid17, "ExportToXlsxDolj");
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid18, "ExportToPDFRegPolz");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxRegPolz.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid18, sfd.FileName);
            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid18, "ExportToXlsxRegPolz");
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid20, "ExportToPDFRole");
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxRole.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid20, sfd.FileName);
            }
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid20, "ExportToXlsxRole");
        }
    }
}
