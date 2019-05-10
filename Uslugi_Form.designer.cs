namespace Melans_LLC
{
    partial class Uslugi_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uslugi_Form));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.iDUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeUslugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melans_LLCDataSet = new Melans_LLC.Melans_LLCDataSet();
            this.uslugiTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.UslugiTableAdapter();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNameUslug = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxOpisUslug = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCenaUslug = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCreateTimeUslug = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTextBoxDateCreateUslug = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUslugDataGridViewTextBoxColumn,
            this.nameUslugDataGridViewTextBoxColumn,
            this.opisUslugDataGridViewTextBoxColumn,
            this.cenaUslugDataGridViewTextBoxColumn,
            this.dateUslugDataGridViewTextBoxColumn,
            this.timeUslugDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.uslugiBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 107);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1041, 301);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.Click += new System.EventHandler(this.metroGrid1_Click);
            // 
            // iDUslugDataGridViewTextBoxColumn
            // 
            this.iDUslugDataGridViewTextBoxColumn.DataPropertyName = "ID_Uslug";
            this.iDUslugDataGridViewTextBoxColumn.HeaderText = "Код услуги";
            this.iDUslugDataGridViewTextBoxColumn.Name = "iDUslugDataGridViewTextBoxColumn";
            this.iDUslugDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUslugDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameUslugDataGridViewTextBoxColumn
            // 
            this.nameUslugDataGridViewTextBoxColumn.DataPropertyName = "Name_Uslug";
            this.nameUslugDataGridViewTextBoxColumn.HeaderText = "Наименование услуги";
            this.nameUslugDataGridViewTextBoxColumn.Name = "nameUslugDataGridViewTextBoxColumn";
            this.nameUslugDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameUslugDataGridViewTextBoxColumn.Width = 250;
            // 
            // opisUslugDataGridViewTextBoxColumn
            // 
            this.opisUslugDataGridViewTextBoxColumn.DataPropertyName = "Opis_Uslug";
            this.opisUslugDataGridViewTextBoxColumn.HeaderText = "Описание услуги";
            this.opisUslugDataGridViewTextBoxColumn.Name = "opisUslugDataGridViewTextBoxColumn";
            this.opisUslugDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisUslugDataGridViewTextBoxColumn.Width = 350;
            // 
            // cenaUslugDataGridViewTextBoxColumn
            // 
            this.cenaUslugDataGridViewTextBoxColumn.DataPropertyName = "Cena_Uslug";
            this.cenaUslugDataGridViewTextBoxColumn.HeaderText = "Цена услуги";
            this.cenaUslugDataGridViewTextBoxColumn.Name = "cenaUslugDataGridViewTextBoxColumn";
            this.cenaUslugDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaUslugDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateUslugDataGridViewTextBoxColumn
            // 
            this.dateUslugDataGridViewTextBoxColumn.DataPropertyName = "Date_Uslug";
            this.dateUslugDataGridViewTextBoxColumn.HeaderText = "Дата создания услуги";
            this.dateUslugDataGridViewTextBoxColumn.Name = "dateUslugDataGridViewTextBoxColumn";
            this.dateUslugDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeUslugDataGridViewTextBoxColumn
            // 
            this.timeUslugDataGridViewTextBoxColumn.DataPropertyName = "Time_Uslug";
            this.timeUslugDataGridViewTextBoxColumn.HeaderText = "Время создания услуги";
            this.timeUslugDataGridViewTextBoxColumn.Name = "timeUslugDataGridViewTextBoxColumn";
            this.timeUslugDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeUslugDataGridViewTextBoxColumn.Width = 150;
            // 
            // uslugiBindingSource
            // 
            this.uslugiBindingSource.DataMember = "Uslugi";
            this.uslugiBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // melans_LLCDataSet
            // 
            this.melans_LLCDataSet.DataSetName = "Melans_LLCDataSet";
            this.melans_LLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uslugiTableAdapter
            // 
            this.uslugiTableAdapter.ClearBeforeFill = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 411);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Наименование услуги:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTextBoxNameUslug
            // 
            this.metroTextBoxNameUslug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxNameUslug.CustomButton.Image = null;
            this.metroTextBoxNameUslug.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBoxNameUslug.CustomButton.Name = "";
            this.metroTextBoxNameUslug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxNameUslug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNameUslug.CustomButton.TabIndex = 1;
            this.metroTextBoxNameUslug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNameUslug.CustomButton.UseSelectable = true;
            this.metroTextBoxNameUslug.CustomButton.Visible = false;
            this.metroTextBoxNameUslug.Lines = new string[0];
            this.metroTextBoxNameUslug.Location = new System.Drawing.Point(176, 410);
            this.metroTextBoxNameUslug.MaxLength = 32767;
            this.metroTextBoxNameUslug.Name = "metroTextBoxNameUslug";
            this.metroTextBoxNameUslug.PasswordChar = '\0';
            this.metroTextBoxNameUslug.ReadOnly = true;
            this.metroTextBoxNameUslug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNameUslug.SelectedText = "";
            this.metroTextBoxNameUslug.SelectionLength = 0;
            this.metroTextBoxNameUslug.SelectionStart = 0;
            this.metroTextBoxNameUslug.ShortcutsEnabled = true;
            this.metroTextBoxNameUslug.Size = new System.Drawing.Size(242, 23);
            this.metroTextBoxNameUslug.TabIndex = 2;
            this.metroTextBoxNameUslug.UseSelectable = true;
            this.metroTextBoxNameUslug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNameUslug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxOpisUslug
            // 
            this.metroTextBoxOpisUslug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxOpisUslug.CustomButton.Image = null;
            this.metroTextBoxOpisUslug.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBoxOpisUslug.CustomButton.Name = "";
            this.metroTextBoxOpisUslug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxOpisUslug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxOpisUslug.CustomButton.TabIndex = 1;
            this.metroTextBoxOpisUslug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxOpisUslug.CustomButton.UseSelectable = true;
            this.metroTextBoxOpisUslug.CustomButton.Visible = false;
            this.metroTextBoxOpisUslug.Lines = new string[0];
            this.metroTextBoxOpisUslug.Location = new System.Drawing.Point(176, 450);
            this.metroTextBoxOpisUslug.MaxLength = 32767;
            this.metroTextBoxOpisUslug.Name = "metroTextBoxOpisUslug";
            this.metroTextBoxOpisUslug.PasswordChar = '\0';
            this.metroTextBoxOpisUslug.ReadOnly = true;
            this.metroTextBoxOpisUslug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxOpisUslug.SelectedText = "";
            this.metroTextBoxOpisUslug.SelectionLength = 0;
            this.metroTextBoxOpisUslug.SelectionStart = 0;
            this.metroTextBoxOpisUslug.ShortcutsEnabled = true;
            this.metroTextBoxOpisUslug.Size = new System.Drawing.Size(242, 23);
            this.metroTextBoxOpisUslug.TabIndex = 4;
            this.metroTextBoxOpisUslug.UseSelectable = true;
            this.metroTextBoxOpisUslug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxOpisUslug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 452);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Описание услуги:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(828, 409);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Цена услуги:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroTextBoxCenaUslug
            // 
            this.metroTextBoxCenaUslug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxCenaUslug.CustomButton.Image = null;
            this.metroTextBoxCenaUslug.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.metroTextBoxCenaUslug.CustomButton.Name = "";
            this.metroTextBoxCenaUslug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCenaUslug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCenaUslug.CustomButton.TabIndex = 1;
            this.metroTextBoxCenaUslug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCenaUslug.CustomButton.UseSelectable = true;
            this.metroTextBoxCenaUslug.CustomButton.Visible = false;
            this.metroTextBoxCenaUslug.Lines = new string[0];
            this.metroTextBoxCenaUslug.Location = new System.Drawing.Point(920, 410);
            this.metroTextBoxCenaUslug.MaxLength = 32767;
            this.metroTextBoxCenaUslug.Name = "metroTextBoxCenaUslug";
            this.metroTextBoxCenaUslug.PasswordChar = '\0';
            this.metroTextBoxCenaUslug.ReadOnly = true;
            this.metroTextBoxCenaUslug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCenaUslug.SelectedText = "";
            this.metroTextBoxCenaUslug.SelectionLength = 0;
            this.metroTextBoxCenaUslug.SelectionStart = 0;
            this.metroTextBoxCenaUslug.ShortcutsEnabled = true;
            this.metroTextBoxCenaUslug.Size = new System.Drawing.Size(144, 23);
            this.metroTextBoxCenaUslug.TabIndex = 8;
            this.metroTextBoxCenaUslug.UseSelectable = true;
            this.metroTextBoxCenaUslug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCenaUslug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(451, 411);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(143, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Дата создания услуги:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(440, 451);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(154, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Время создания услуги:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroTextBoxCreateTimeUslug
            // 
            this.metroTextBoxCreateTimeUslug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxCreateTimeUslug.CustomButton.Image = null;
            this.metroTextBoxCreateTimeUslug.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBoxCreateTimeUslug.CustomButton.Name = "";
            this.metroTextBoxCreateTimeUslug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCreateTimeUslug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCreateTimeUslug.CustomButton.TabIndex = 1;
            this.metroTextBoxCreateTimeUslug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCreateTimeUslug.CustomButton.UseSelectable = true;
            this.metroTextBoxCreateTimeUslug.CustomButton.Visible = false;
            this.metroTextBoxCreateTimeUslug.Lines = new string[0];
            this.metroTextBoxCreateTimeUslug.Location = new System.Drawing.Point(600, 450);
            this.metroTextBoxCreateTimeUslug.MaxLength = 32767;
            this.metroTextBoxCreateTimeUslug.Name = "metroTextBoxCreateTimeUslug";
            this.metroTextBoxCreateTimeUslug.PasswordChar = '\0';
            this.metroTextBoxCreateTimeUslug.ReadOnly = true;
            this.metroTextBoxCreateTimeUslug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCreateTimeUslug.SelectedText = "";
            this.metroTextBoxCreateTimeUslug.SelectionLength = 0;
            this.metroTextBoxCreateTimeUslug.SelectionStart = 0;
            this.metroTextBoxCreateTimeUslug.ShortcutsEnabled = true;
            this.metroTextBoxCreateTimeUslug.Size = new System.Drawing.Size(188, 23);
            this.metroTextBoxCreateTimeUslug.TabIndex = 9;
            this.metroTextBoxCreateTimeUslug.UseSelectable = true;
            this.metroTextBoxCreateTimeUslug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCreateTimeUslug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(828, 450);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(236, 23);
            this.metroButton1.TabIndex = 11;
            this.metroButton1.Text = "Заказать услугу";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBoxID
            // 
            this.metroTextBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.metroTextBoxID.CustomButton.Image = null;
            this.metroTextBoxID.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.metroTextBoxID.CustomButton.Name = "";
            this.metroTextBoxID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxID.CustomButton.TabIndex = 1;
            this.metroTextBoxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxID.CustomButton.UseSelectable = true;
            this.metroTextBoxID.CustomButton.Visible = false;
            this.metroTextBoxID.Lines = new string[0];
            this.metroTextBoxID.Location = new System.Drawing.Point(176, 485);
            this.metroTextBoxID.MaxLength = 32767;
            this.metroTextBoxID.Name = "metroTextBoxID";
            this.metroTextBoxID.PasswordChar = '\0';
            this.metroTextBoxID.ReadOnly = true;
            this.metroTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxID.SelectedText = "";
            this.metroTextBoxID.SelectionLength = 0;
            this.metroTextBoxID.SelectionStart = 0;
            this.metroTextBoxID.ShortcutsEnabled = true;
            this.metroTextBoxID.Size = new System.Drawing.Size(242, 23);
            this.metroTextBoxID.TabIndex = 12;
            this.metroTextBoxID.UseSelectable = true;
            this.metroTextBoxID.Visible = false;
            this.metroTextBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroTextBoxDateCreateUslug
            // 
            this.metroTextBoxDateCreateUslug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxDateCreateUslug.CustomButton.Image = null;
            this.metroTextBoxDateCreateUslug.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.metroTextBoxDateCreateUslug.CustomButton.Name = "";
            this.metroTextBoxDateCreateUslug.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDateCreateUslug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDateCreateUslug.CustomButton.TabIndex = 1;
            this.metroTextBoxDateCreateUslug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDateCreateUslug.CustomButton.UseSelectable = true;
            this.metroTextBoxDateCreateUslug.CustomButton.Visible = false;
            this.metroTextBoxDateCreateUslug.Lines = new string[0];
            this.metroTextBoxDateCreateUslug.Location = new System.Drawing.Point(600, 410);
            this.metroTextBoxDateCreateUslug.MaxLength = 32767;
            this.metroTextBoxDateCreateUslug.Name = "metroTextBoxDateCreateUslug";
            this.metroTextBoxDateCreateUslug.PasswordChar = '\0';
            this.metroTextBoxDateCreateUslug.ReadOnly = true;
            this.metroTextBoxDateCreateUslug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDateCreateUslug.SelectedText = "";
            this.metroTextBoxDateCreateUslug.SelectionLength = 0;
            this.metroTextBoxDateCreateUslug.SelectionStart = 0;
            this.metroTextBoxDateCreateUslug.ShortcutsEnabled = true;
            this.metroTextBoxDateCreateUslug.Size = new System.Drawing.Size(188, 23);
            this.metroTextBoxDateCreateUslug.TabIndex = 6;
            this.metroTextBoxDateCreateUslug.UseSelectable = true;
            this.metroTextBoxDateCreateUslug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDateCreateUslug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Uslugi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(1087, 521);
            this.Controls.Add(this.metroTextBoxID);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBoxCreateTimeUslug);
            this.Controls.Add(this.metroTextBoxCenaUslug);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxDateCreateUslug);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBoxOpisUslug);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxNameUslug);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uslugi_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Услуги";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Uslugi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private Melans_LLCDataSet melans_LLCDataSet;
        private System.Windows.Forms.BindingSource uslugiBindingSource;
        private Melans_LLCDataSetTableAdapters.UslugiTableAdapter uslugiTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNameUslug;
        private MetroFramework.Controls.MetroTextBox metroTextBoxOpisUslug;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCenaUslug;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCreateTimeUslug;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUslugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeUslugDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDateCreateUslug;
    }
}