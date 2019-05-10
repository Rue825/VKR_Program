namespace Melans_LLC
{
    partial class System_Administrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Administrat));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.melans_LLCDataSet = new Melans_LLC.Melans_LLCDataSet();
            this.registraciapolzovatelyaZayavkSysStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registraciapolzovatelyaSysAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registracia_polzovatelya_SysAdminTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_SysAdminTableAdapter();
            this.registracia_polzovatelya_ZayavkSysStatTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_ZayavkSysStatTableAdapter();
            this.registraciapolzovatelyaFullStatusSysAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registracia_polzovatelya_FullStatusSysAdmTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_FullStatusSysAdmTableAdapter();
            this.iDRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachRabRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okonchRabRegPolzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaZayavkSysStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaSysAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaFullStatusSysAdmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
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
            this.iDRegPolzDataGridViewTextBoxColumn,
            this.fRegPolzDataGridViewTextBoxColumn,
            this.iRegPolzDataGridViewTextBoxColumn,
            this.oRegPolzDataGridViewTextBoxColumn,
            this.statusRegPolzDataGridViewTextBoxColumn,
            this.nachRabRegPolzDataGridViewTextBoxColumn,
            this.okonchRabRegPolzDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.registraciapolzovatelyaFullStatusSysAdmBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(10, 73);
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
            this.metroGrid1.Size = new System.Drawing.Size(1217, 457);
            this.metroGrid1.TabIndex = 0;
            // 
            // melans_LLCDataSet
            // 
            this.melans_LLCDataSet.DataSetName = "Melans_LLCDataSet";
            this.melans_LLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registraciapolzovatelyaZayavkSysStatBindingSource
            // 
            this.registraciapolzovatelyaZayavkSysStatBindingSource.DataMember = "Registracia_polzovatelya_ZayavkSysStat";
            this.registraciapolzovatelyaZayavkSysStatBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // registraciapolzovatelyaSysAdminBindingSource
            // 
            this.registraciapolzovatelyaSysAdminBindingSource.DataMember = "Registracia_polzovatelya_SysAdmin";
            this.registraciapolzovatelyaSysAdminBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // registracia_polzovatelya_SysAdminTableAdapter
            // 
            this.registracia_polzovatelya_SysAdminTableAdapter.ClearBeforeFill = true;
            // 
            // registracia_polzovatelya_ZayavkSysStatTableAdapter
            // 
            this.registracia_polzovatelya_ZayavkSysStatTableAdapter.ClearBeforeFill = true;
            // 
            // registraciapolzovatelyaFullStatusSysAdmBindingSource
            // 
            this.registraciapolzovatelyaFullStatusSysAdmBindingSource.DataMember = "Registracia_polzovatelya_FullStatusSysAdm";
            this.registraciapolzovatelyaFullStatusSysAdmBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // registracia_polzovatelya_FullStatusSysAdmTableAdapter
            // 
            this.registracia_polzovatelya_FullStatusSysAdmTableAdapter.ClearBeforeFill = true;
            // 
            // iDRegPolzDataGridViewTextBoxColumn
            // 
            this.iDRegPolzDataGridViewTextBoxColumn.DataPropertyName = "ID_RegPolz";
            this.iDRegPolzDataGridViewTextBoxColumn.HeaderText = "Код системного администратора";
            this.iDRegPolzDataGridViewTextBoxColumn.Name = "iDRegPolzDataGridViewTextBoxColumn";
            this.iDRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRegPolzDataGridViewTextBoxColumn.Visible = false;
            // 
            // fRegPolzDataGridViewTextBoxColumn
            // 
            this.fRegPolzDataGridViewTextBoxColumn.DataPropertyName = "F_RegPolz";
            this.fRegPolzDataGridViewTextBoxColumn.HeaderText = "Фамилия системного администратора";
            this.fRegPolzDataGridViewTextBoxColumn.Name = "fRegPolzDataGridViewTextBoxColumn";
            this.fRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.fRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // iRegPolzDataGridViewTextBoxColumn
            // 
            this.iRegPolzDataGridViewTextBoxColumn.DataPropertyName = "I_RegPolz";
            this.iRegPolzDataGridViewTextBoxColumn.HeaderText = "Имя системного администратора";
            this.iRegPolzDataGridViewTextBoxColumn.Name = "iRegPolzDataGridViewTextBoxColumn";
            this.iRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // oRegPolzDataGridViewTextBoxColumn
            // 
            this.oRegPolzDataGridViewTextBoxColumn.DataPropertyName = "O_RegPolz";
            this.oRegPolzDataGridViewTextBoxColumn.HeaderText = "Отчество системного администратора";
            this.oRegPolzDataGridViewTextBoxColumn.Name = "oRegPolzDataGridViewTextBoxColumn";
            this.oRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // statusRegPolzDataGridViewTextBoxColumn
            // 
            this.statusRegPolzDataGridViewTextBoxColumn.DataPropertyName = "Status_RegPolz";
            this.statusRegPolzDataGridViewTextBoxColumn.HeaderText = "Статус системного администратора";
            this.statusRegPolzDataGridViewTextBoxColumn.Name = "statusRegPolzDataGridViewTextBoxColumn";
            this.statusRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // nachRabRegPolzDataGridViewTextBoxColumn
            // 
            this.nachRabRegPolzDataGridViewTextBoxColumn.DataPropertyName = "NachRab_RegPolz";
            this.nachRabRegPolzDataGridViewTextBoxColumn.HeaderText = "Начало работы системного администратора";
            this.nachRabRegPolzDataGridViewTextBoxColumn.Name = "nachRabRegPolzDataGridViewTextBoxColumn";
            this.nachRabRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.nachRabRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // okonchRabRegPolzDataGridViewTextBoxColumn
            // 
            this.okonchRabRegPolzDataGridViewTextBoxColumn.DataPropertyName = "OkonchRab_RegPolz";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.HeaderText = "Окончание работы системного администратора";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.Name = "okonchRabRegPolzDataGridViewTextBoxColumn";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.okonchRabRegPolzDataGridViewTextBoxColumn.Width = 120;
            // 
            // System_Administrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(776, 553);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "System_Administrat";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Системные администраторы";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.System_Administrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaZayavkSysStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaSysAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaFullStatusSysAdmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private Melans_LLCDataSet melans_LLCDataSet;
        private System.Windows.Forms.BindingSource registraciapolzovatelyaSysAdminBindingSource;
        private Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_SysAdminTableAdapter registracia_polzovatelya_SysAdminTableAdapter;
        private System.Windows.Forms.BindingSource registraciapolzovatelyaZayavkSysStatBindingSource;
        private Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_ZayavkSysStatTableAdapter registracia_polzovatelya_ZayavkSysStatTableAdapter;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource registraciapolzovatelyaFullStatusSysAdmBindingSource;
        private Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_FullStatusSysAdmTableAdapter registracia_polzovatelya_FullStatusSysAdmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachRabRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okonchRabRegPolzDataGridViewTextBoxColumn;
    }
}