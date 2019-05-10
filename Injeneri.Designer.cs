namespace Melans_LLC
{
    partial class Injeneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injeneri));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.melans_LLCDataSet = new Melans_LLC.Melans_LLCDataSet();
            this.registraciapolzovatelyaInjFullStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registracia_polzovatelya_InjFullStatusTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_InjFullStatusTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaInjFullStatusBindingSource)).BeginInit();
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
            this.metroGrid1.DataSource = this.registraciapolzovatelyaInjFullStatusBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(19, 67);
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
            this.metroGrid1.Size = new System.Drawing.Size(642, 354);
            this.metroGrid1.TabIndex = 1;
            // 
            // melans_LLCDataSet
            // 
            this.melans_LLCDataSet.DataSetName = "Melans_LLCDataSet";
            this.melans_LLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registraciapolzovatelyaInjFullStatusBindingSource
            // 
            this.registraciapolzovatelyaInjFullStatusBindingSource.DataMember = "Registracia_polzovatelya_InjFullStatus";
            this.registraciapolzovatelyaInjFullStatusBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // registracia_polzovatelya_InjFullStatusTableAdapter
            // 
            this.registracia_polzovatelya_InjFullStatusTableAdapter.ClearBeforeFill = true;
            // 
            // iDRegPolzDataGridViewTextBoxColumn
            // 
            this.iDRegPolzDataGridViewTextBoxColumn.DataPropertyName = "ID_RegPolz";
            this.iDRegPolzDataGridViewTextBoxColumn.HeaderText = "Код инженера";
            this.iDRegPolzDataGridViewTextBoxColumn.Name = "iDRegPolzDataGridViewTextBoxColumn";
            this.iDRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRegPolzDataGridViewTextBoxColumn.Visible = false;
            // 
            // fRegPolzDataGridViewTextBoxColumn
            // 
            this.fRegPolzDataGridViewTextBoxColumn.DataPropertyName = "F_RegPolz";
            this.fRegPolzDataGridViewTextBoxColumn.HeaderText = "Фамилия инженера";
            this.fRegPolzDataGridViewTextBoxColumn.Name = "fRegPolzDataGridViewTextBoxColumn";
            this.fRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iRegPolzDataGridViewTextBoxColumn
            // 
            this.iRegPolzDataGridViewTextBoxColumn.DataPropertyName = "I_RegPolz";
            this.iRegPolzDataGridViewTextBoxColumn.HeaderText = "Имя инженера";
            this.iRegPolzDataGridViewTextBoxColumn.Name = "iRegPolzDataGridViewTextBoxColumn";
            this.iRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oRegPolzDataGridViewTextBoxColumn
            // 
            this.oRegPolzDataGridViewTextBoxColumn.DataPropertyName = "O_RegPolz";
            this.oRegPolzDataGridViewTextBoxColumn.HeaderText = "Отчество инженера";
            this.oRegPolzDataGridViewTextBoxColumn.Name = "oRegPolzDataGridViewTextBoxColumn";
            this.oRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusRegPolzDataGridViewTextBoxColumn
            // 
            this.statusRegPolzDataGridViewTextBoxColumn.DataPropertyName = "Status_RegPolz";
            this.statusRegPolzDataGridViewTextBoxColumn.HeaderText = "Статус инженера";
            this.statusRegPolzDataGridViewTextBoxColumn.Name = "statusRegPolzDataGridViewTextBoxColumn";
            this.statusRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nachRabRegPolzDataGridViewTextBoxColumn
            // 
            this.nachRabRegPolzDataGridViewTextBoxColumn.DataPropertyName = "NachRab_RegPolz";
            this.nachRabRegPolzDataGridViewTextBoxColumn.HeaderText = "Начало работы инженера";
            this.nachRabRegPolzDataGridViewTextBoxColumn.Name = "nachRabRegPolzDataGridViewTextBoxColumn";
            this.nachRabRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // okonchRabRegPolzDataGridViewTextBoxColumn
            // 
            this.okonchRabRegPolzDataGridViewTextBoxColumn.DataPropertyName = "OkonchRab_RegPolz";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.HeaderText = "Окончание работы инженера";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.Name = "okonchRabRegPolzDataGridViewTextBoxColumn";
            this.okonchRabRegPolzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Injeneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Injeneri";
            this.Resizable = false;
            this.Text = "Инженеры";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Injeneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registraciapolzovatelyaInjFullStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public MetroFramework.Controls.MetroGrid metroGrid1;
        private Melans_LLCDataSet melans_LLCDataSet;
        private System.Windows.Forms.BindingSource registraciapolzovatelyaInjFullStatusBindingSource;
        private Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_InjFullStatusTableAdapter registracia_polzovatelya_InjFullStatusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachRabRegPolzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okonchRabRegPolzDataGridViewTextBoxColumn;
    }
}