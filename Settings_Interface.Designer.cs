namespace Melans_LLC
{
    partial class Settings_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Interface));
            this.MSMMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ucSettings1 = new Melans_LLC.PanelSettingsInterface.UCSettings();
            ((System.ComponentModel.ISupportInitialize)(this.MSMMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MSMMain
            // 
            this.MSMMain.Owner = this;
            this.MSMMain.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // ucSettings1
            // 
            this.ucSettings1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucSettings1.Location = new System.Drawing.Point(18, 75);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(515, 165);
            this.ucSettings1.TabIndex = 0;
            // 
            // Settings_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(550, 256);
            this.Controls.Add(this.ucSettings1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings_Interface";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Настройка интерфейса";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Interface_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MSMMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager MSMMain;
        private PanelSettingsInterface.UCSettings ucSettings1;
    }
}