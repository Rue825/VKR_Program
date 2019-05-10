namespace Melans_LLC
{
    partial class ReportOtchet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOtchet));
            this.Registracia_polzovatelya_RegPolzInjBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Melans_LLCDataSet = new Melans_LLC.Melans_LLCDataSet();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Registracia_polzovatelya_RegPolzInjTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_RegPolzInjTableAdapter();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ZadachiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZadachiTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.ZadachiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Registracia_polzovatelya_RegPolzInjBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Melans_LLCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadachiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Registracia_polzovatelya_RegPolzInjBindingSource
            // 
            this.Registracia_polzovatelya_RegPolzInjBindingSource.DataMember = "Registracia_polzovatelya_RegPolzInj";
            this.Registracia_polzovatelya_RegPolzInjBindingSource.DataSource = this.Melans_LLCDataSet;
            // 
            // Melans_LLCDataSet
            // 
            this.Melans_LLCDataSet.DataSetName = "Melans_LLCDataSet";
            this.Melans_LLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // Registracia_polzovatelya_RegPolzInjTableAdapter
            // 
            this.Registracia_polzovatelya_RegPolzInjTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(14, 67);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1202, 606);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.reportViewer1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1194, 564);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Отчет о популярности сотрудников";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Registracia_polzovatelya_RegPolzInj";
            reportDataSource1.Value = this.Registracia_polzovatelya_RegPolzInjBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Melans_LLC.Otchet_RegPolz.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1194, 564);
            this.reportViewer1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.reportViewer2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1194, 564);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Отчет со всеми задачами";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Zadachi";
            reportDataSource2.Value = this.ZadachiBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Melans_LLC.Otchet_Zadach.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1194, 564);
            this.reportViewer2.TabIndex = 3;
            // 
            // ZadachiBindingSource
            // 
            this.ZadachiBindingSource.DataMember = "Zadachi";
            this.ZadachiBindingSource.DataSource = this.Melans_LLCDataSet;
            // 
            // ZadachiTableAdapter
            // 
            this.ZadachiTableAdapter.ClearBeforeFill = true;
            // 
            // ReportOtchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(1224, 689);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportOtchet";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Отчет о популярности сотрудников";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.ReportOtchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registracia_polzovatelya_RegPolzInjBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Melans_LLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ZadachiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.BindingSource Registracia_polzovatelya_RegPolzInjBindingSource;
        private Melans_LLCDataSet Melans_LLCDataSet;
        private Melans_LLCDataSetTableAdapters.Registracia_polzovatelya_RegPolzInjTableAdapter Registracia_polzovatelya_RegPolzInjTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public MetroFramework.Controls.MetroTabControl metroTabControl1;
        public MetroFramework.Controls.MetroTabPage metroTabPage1;
        public MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.BindingSource ZadachiBindingSource;
        private Melans_LLCDataSetTableAdapters.ZadachiTableAdapter ZadachiTableAdapter;
    }
}