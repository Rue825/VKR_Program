using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class Korzina : MetroFramework.Forms.MetroForm
    {
        Con_Base _CB = new Con_Base();
        Dlya_Systemnogo_Administratora _DSA = new Dlya_Systemnogo_Administratora();
        public Korzina()
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
        private void Korzina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Registracia_polzovatelya_Zayavk". При необходимости она может быть перемещена или удалена.
            this.registracia_polzovatelya_ZayavkTableAdapter.Fill(this.melans_LLCDataSet.Registracia_polzovatelya_Zayavk);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "melans_LLCDataSet.Uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.melans_LLCDataSet.Uslugi);
            metroTabPage2.Parent = null;
            if (Program.Znach_Korzina_1 != null || Program.Znach_Korzina_2 != null || Program.Znach_Korzina_3 != null || Program.Znach_Korzina_4 != null || Program.Znach_Korzina_5 != null)
            {
                metroButton2.Enabled = true;
                metroButton1.Enabled = true;
                metroTextBox1.Enabled = true;
                metroTextBox2.Enabled = true;
                metroTextBox3.Enabled = true;
            }
            else
            {
                metroButton2.Enabled = false;
                metroButton1.Enabled = false;
                metroTextBox1.Enabled = false;
                metroTextBox2.Enabled = false;
                metroTextBox3.Enabled = false;
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {           
            if (metroTextBox1.Text == string.Empty || metroTextBox2.Text == string.Empty || metroTextBox3.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поля должны быть обязательно заполнены!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (metroTextBox1.Text.Length < 2 || metroTextBox2.Text.Length < 2 || metroTextBox3.Text.Length < 2)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поля ФИО должны быть не меньше 2 символов!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (metroComboBox1.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поля с системным администратором должно быть обязательно выбрано!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DateTime Day = DateTime.Today;
                DateTime Time = DateTime.Now;
                int check1 = 0;
                Random rnd = new Random();
                int[] pick3 = new int[3];
                for (int i = 0; i < pick3.Length; i++)
                {
                    check1 = rnd.Next(100000, 900000);
                    while (!(pick3.Contains(check1)))
                    {
                        pick3[i] = check1;
                    }
                    metroTextGenerateNumZayavk.Text = (check1.ToString());
                }
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
                metroTextBox1.Enabled = false;
                metroTextBox2.Enabled = false;
                metroTextBox3.Enabled = false;
                _CB.CreateKlient(metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text);
                metroTextBoxKlient_ID.Text = Convert.ToString(Program.Klient_ID);
                metroTextBoxDate.Text = Day.ToString("dd.MM.yyyy");
                metroTextBoxTime.Text = Time.ToString("HH:mm");
                _CB.CreateZayavk(metroTextGenerateNumZayavk.Text, metroTextBoxDate.Text, metroTextBoxTime.Text, Convert.ToInt32(metroTextBoxKlient_ID.Text), Convert.ToInt32(metroTextBoxUslug_ID.Text), Convert.ToInt32(metroComboBox1.SelectedValue));
                _CB.UpdateKl(_DSA.metroGrid8);
                _CB.UpdateZayavk(_DSA.metroGrid7);
                _DSA.metroGrid8.Columns[0].Visible = false;
                _DSA.metroGrid7.Columns[0].Visible = false;
                Refresh();
                void Save() //Сохранение
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        Thread.Sleep(10);
                    }
                }
                using (var waitForm = new WaitForm(Save))
                {
                    waitForm.ShowDialog(this);
                    metroGrid1.Rows.Add(metroTextGenerateNumZayavk.Text, metroLabelNameUslug.Text, metroLabelDateCreateUslug.Text, metroLabelTimeCreateUslug.Text, metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroComboBox1.Text);
                }
                switch (MetroFramework.MetroMessageBox.Show(this, "Заказ оформлен успешно!", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    case DialogResult.OK:
                        {
                            metroTabPage1.Parent = null;
                            metroTabPage2.Parent = metroTabControl1;
                            this.metroTabControl1.SelectedIndex = 1;
                            metroLabelNameUslug.Text = "";
                            metroLabelOpisUslug.Text = "";
                            metroLabelDateCreateUslug.Text = "";
                            metroLabelTimeCreateUslug.Text = "";
                            metroLabelCenaUslug.Text = "";
                            metroTextBox1.Text = "";
                            metroTextBox2.Text = "";
                            metroTextBox3.Text = "";
                            Program.Znach_Korzina_1 = null;
                            Program.Znach_Korzina_2 = null;
                            Program.Znach_Korzina_3 = null;
                            Program.Znach_Korzina_4 = null;
                            Program.Znach_Korzina_5 = null;
                            break;
                        }
                }
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            switch (MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите отменить заказ?", "Shtrih-M", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                case DialogResult.Yes:
                    {
                        metroLabelNameUslug.Text = "";
                        metroLabelOpisUslug.Text = "";
                        metroLabelDateCreateUslug.Text = "";
                        metroLabelTimeCreateUslug.Text = "";
                        metroLabelCenaUslug.Text = "";
                        metroTextBox1.Text = "";
                        metroTextBox2.Text = "";
                        metroTextBox3.Text = "";
                        Program.Znach_Korzina_1 = null;
                        Program.Znach_Korzina_2 = null;
                        Program.Znach_Korzina_3 = null;
                        Program.Znach_Korzina_4 = null;
                        Program.Znach_Korzina_5 = null;
                        metroButton2.Enabled = false;
                        metroButton1.Enabled = false;
                        metroTextBox1.Enabled = false;
                        metroTextBox2.Enabled = false;
                        metroTextBox3.Enabled = false;
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }

        private void Korzina_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                metroGrid1.Rows.RemoveAt(i);
            }
            metroTabPage2.Parent = null;
            metroTabPage1.Parent = metroTabControl1;
            this.metroTabControl1.SelectedIndex = 0;
            metroButton1.Enabled = true;
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

                for (int i = 1; i < DGW.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = DGW.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DGW.Rows.Count; i++)
                {
                    for (int j = 0; j < DGW.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = DGW.Rows[i].Cells[j].Value.ToString();
                    }
                }

                //Сохранение документа
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = filename;
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Export_Data_To_PDF(metroGrid1, "ExportToPDFCheckUslug");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Word Documents (*.docx)|*.docx";

            sfd.FileName = "ExportToDocxCheckUslug.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Export_Data_To_DOCX(metroGrid1, sfd.FileName);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Export_Data_To_XLSX(metroGrid1, "ExportToXlsxCheckUslug");
        }

        private void MetroButton6_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Если поле с системным администратором было пустое, то в этом случае необходимо посмотреть подробную информацию о системном администраторе. Если свободных системных администраторов нету, то заявку невозможно завершить до тех пор, пока не освободится системный администратор и не примет данную заявку.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MetroButton7_Click(object sender, EventArgs e)
        {
            System_Administrat _SD = new System_Administrat();
            _CB.UpdateRegSysAdmin(_SD.metroGrid1);
            _SD.ShowDialog();
        }
    }
}
