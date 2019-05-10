namespace Melans_LLC
{
    partial class Registracia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registracia));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxF_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxI_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxO_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.maskedTextBoxTel_RegPolz = new System.Windows.Forms.MaskedTextBox();
            this.metroTextBoxLog_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEmail_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPass_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRepeatPass_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDolj_RegPolz = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDoljInt = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxRole_RegPolz = new MetroFramework.Controls.MetroComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.melans_LLCDataSet = new Melans_LLC.Melans_LLCDataSet();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.roleTableAdapter = new Melans_LLC.Melans_LLCDataSetTableAdapters.RoleTableAdapter();
            this.metroTextBoxRole = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroComboTech_RegPolz = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.melans_LLCDataSetNewVariant = new Melans_LLC.Melans_LLCDataSetNewVariant();
            this.technikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technikaTableAdapter = new Melans_LLC.Melans_LLCDataSetNewVariantTableAdapters.TechnikaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSetNewVariant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 128);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Фамилия:";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(113, 168);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Имя:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(83, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Отчество:";
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(86, 246);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Телефон:";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.Location = new System.Drawing.Point(83, 355);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(451, 25);
            this.metroCheckBox1.TabIndex = 4;
            this.metroCheckBox1.Text = "Я ознакомлен(а) с правилами конфиденциальности";
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(583, 352);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(166, 39);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Зарегистрироваться";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBoxF_RegPolz
            // 
            // 
            // 
            // 
            this.metroTextBoxF_RegPolz.CustomButton.Image = null;
            this.metroTextBoxF_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxF_RegPolz.CustomButton.Name = "";
            this.metroTextBoxF_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxF_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxF_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxF_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxF_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxF_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxF_RegPolz.Lines = new string[0];
            this.metroTextBoxF_RegPolz.Location = new System.Drawing.Point(157, 126);
            this.metroTextBoxF_RegPolz.MaxLength = 32767;
            this.metroTextBoxF_RegPolz.Name = "metroTextBoxF_RegPolz";
            this.metroTextBoxF_RegPolz.PasswordChar = '\0';
            this.metroTextBoxF_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxF_RegPolz.SelectedText = "";
            this.metroTextBoxF_RegPolz.SelectionLength = 0;
            this.metroTextBoxF_RegPolz.SelectionStart = 0;
            this.metroTextBoxF_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxF_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxF_RegPolz.TabIndex = 6;
            this.metroTextBoxF_RegPolz.UseSelectable = true;
            this.metroTextBoxF_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxF_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxI_RegPolz
            // 
            // 
            // 
            // 
            this.metroTextBoxI_RegPolz.CustomButton.Image = null;
            this.metroTextBoxI_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxI_RegPolz.CustomButton.Name = "";
            this.metroTextBoxI_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxI_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxI_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxI_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxI_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxI_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxI_RegPolz.Lines = new string[0];
            this.metroTextBoxI_RegPolz.Location = new System.Drawing.Point(157, 166);
            this.metroTextBoxI_RegPolz.MaxLength = 32767;
            this.metroTextBoxI_RegPolz.Name = "metroTextBoxI_RegPolz";
            this.metroTextBoxI_RegPolz.PasswordChar = '\0';
            this.metroTextBoxI_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxI_RegPolz.SelectedText = "";
            this.metroTextBoxI_RegPolz.SelectionLength = 0;
            this.metroTextBoxI_RegPolz.SelectionStart = 0;
            this.metroTextBoxI_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxI_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxI_RegPolz.TabIndex = 7;
            this.metroTextBoxI_RegPolz.UseSelectable = true;
            this.metroTextBoxI_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxI_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxO_RegPolz
            // 
            // 
            // 
            // 
            this.metroTextBoxO_RegPolz.CustomButton.Image = null;
            this.metroTextBoxO_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxO_RegPolz.CustomButton.Name = "";
            this.metroTextBoxO_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxO_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxO_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxO_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxO_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxO_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxO_RegPolz.Lines = new string[0];
            this.metroTextBoxO_RegPolz.Location = new System.Drawing.Point(157, 205);
            this.metroTextBoxO_RegPolz.MaxLength = 32767;
            this.metroTextBoxO_RegPolz.Name = "metroTextBoxO_RegPolz";
            this.metroTextBoxO_RegPolz.PasswordChar = '\0';
            this.metroTextBoxO_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxO_RegPolz.SelectedText = "";
            this.metroTextBoxO_RegPolz.SelectionLength = 0;
            this.metroTextBoxO_RegPolz.SelectionStart = 0;
            this.metroTextBoxO_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxO_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxO_RegPolz.TabIndex = 8;
            this.metroTextBoxO_RegPolz.UseSelectable = true;
            this.metroTextBoxO_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxO_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // maskedTextBoxTel_RegPolz
            // 
            this.maskedTextBoxTel_RegPolz.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxTel_RegPolz.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBoxTel_RegPolz.Location = new System.Drawing.Point(157, 246);
            this.maskedTextBoxTel_RegPolz.Mask = "+0(999)000-00-00";
            this.maskedTextBoxTel_RegPolz.Name = "maskedTextBoxTel_RegPolz";
            this.maskedTextBoxTel_RegPolz.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBoxTel_RegPolz.TabIndex = 61;
            // 
            // metroTextBoxLog_RegPolz
            // 
            this.metroTextBoxLog_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxLog_RegPolz.CustomButton.Image = null;
            this.metroTextBoxLog_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxLog_RegPolz.CustomButton.Name = "";
            this.metroTextBoxLog_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLog_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLog_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxLog_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLog_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxLog_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxLog_RegPolz.Lines = new string[0];
            this.metroTextBoxLog_RegPolz.Location = new System.Drawing.Point(525, 126);
            this.metroTextBoxLog_RegPolz.MaxLength = 32767;
            this.metroTextBoxLog_RegPolz.Name = "metroTextBoxLog_RegPolz";
            this.metroTextBoxLog_RegPolz.PasswordChar = '\0';
            this.metroTextBoxLog_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLog_RegPolz.SelectedText = "";
            this.metroTextBoxLog_RegPolz.SelectionLength = 0;
            this.metroTextBoxLog_RegPolz.SelectionStart = 0;
            this.metroTextBoxLog_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxLog_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxLog_RegPolz.TabIndex = 62;
            this.metroTextBoxLog_RegPolz.UseSelectable = true;
            this.metroTextBoxLog_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLog_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(469, 128);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 63;
            this.metroLabel5.Text = "Логин:";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(476, 167);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(44, 19);
            this.metroLabel6.TabIndex = 65;
            this.metroLabel6.Text = "Email:";
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroTextBoxEmail_RegPolz
            // 
            this.metroTextBoxEmail_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxEmail_RegPolz.CustomButton.Image = null;
            this.metroTextBoxEmail_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxEmail_RegPolz.CustomButton.Name = "";
            this.metroTextBoxEmail_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEmail_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEmail_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxEmail_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEmail_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxEmail_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxEmail_RegPolz.Lines = new string[0];
            this.metroTextBoxEmail_RegPolz.Location = new System.Drawing.Point(525, 166);
            this.metroTextBoxEmail_RegPolz.MaxLength = 32767;
            this.metroTextBoxEmail_RegPolz.Name = "metroTextBoxEmail_RegPolz";
            this.metroTextBoxEmail_RegPolz.PasswordChar = '\0';
            this.metroTextBoxEmail_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEmail_RegPolz.SelectedText = "";
            this.metroTextBoxEmail_RegPolz.SelectionLength = 0;
            this.metroTextBoxEmail_RegPolz.SelectionStart = 0;
            this.metroTextBoxEmail_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxEmail_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxEmail_RegPolz.TabIndex = 64;
            this.metroTextBoxEmail_RegPolz.UseSelectable = true;
            this.metroTextBoxEmail_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEmail_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(463, 208);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(57, 19);
            this.metroLabel7.TabIndex = 67;
            this.metroLabel7.Text = "Пароль:";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroTextBoxPass_RegPolz
            // 
            this.metroTextBoxPass_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxPass_RegPolz.CustomButton.Image = null;
            this.metroTextBoxPass_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxPass_RegPolz.CustomButton.Name = "";
            this.metroTextBoxPass_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPass_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPass_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxPass_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPass_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxPass_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxPass_RegPolz.Lines = new string[0];
            this.metroTextBoxPass_RegPolz.Location = new System.Drawing.Point(525, 205);
            this.metroTextBoxPass_RegPolz.MaxLength = 32767;
            this.metroTextBoxPass_RegPolz.Name = "metroTextBoxPass_RegPolz";
            this.metroTextBoxPass_RegPolz.PasswordChar = '*';
            this.metroTextBoxPass_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPass_RegPolz.SelectedText = "";
            this.metroTextBoxPass_RegPolz.SelectionLength = 0;
            this.metroTextBoxPass_RegPolz.SelectionStart = 0;
            this.metroTextBoxPass_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxPass_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxPass_RegPolz.TabIndex = 66;
            this.metroTextBoxPass_RegPolz.UseSelectable = true;
            this.metroTextBoxPass_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPass_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(390, 247);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(130, 19);
            this.metroLabel8.TabIndex = 69;
            this.metroLabel8.Text = "Повторный пароль:";
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroTextBoxRepeatPass_RegPolz
            // 
            this.metroTextBoxRepeatPass_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Image = null;
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Name = "";
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxRepeatPass_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxRepeatPass_RegPolz.Lines = new string[0];
            this.metroTextBoxRepeatPass_RegPolz.Location = new System.Drawing.Point(525, 245);
            this.metroTextBoxRepeatPass_RegPolz.MaxLength = 32767;
            this.metroTextBoxRepeatPass_RegPolz.Name = "metroTextBoxRepeatPass_RegPolz";
            this.metroTextBoxRepeatPass_RegPolz.PasswordChar = '*';
            this.metroTextBoxRepeatPass_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRepeatPass_RegPolz.SelectedText = "";
            this.metroTextBoxRepeatPass_RegPolz.SelectionLength = 0;
            this.metroTextBoxRepeatPass_RegPolz.SelectionStart = 0;
            this.metroTextBoxRepeatPass_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxRepeatPass_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxRepeatPass_RegPolz.TabIndex = 68;
            this.metroTextBoxRepeatPass_RegPolz.UseSelectable = true;
            this.metroTextBoxRepeatPass_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRepeatPass_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(73, 280);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(78, 19);
            this.metroLabel9.TabIndex = 71;
            this.metroLabel9.Text = "Должность:";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroTextBoxDolj_RegPolz
            // 
            // 
            // 
            // 
            this.metroTextBoxDolj_RegPolz.CustomButton.Image = null;
            this.metroTextBoxDolj_RegPolz.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxDolj_RegPolz.CustomButton.Name = "";
            this.metroTextBoxDolj_RegPolz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDolj_RegPolz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDolj_RegPolz.CustomButton.TabIndex = 1;
            this.metroTextBoxDolj_RegPolz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDolj_RegPolz.CustomButton.UseSelectable = true;
            this.metroTextBoxDolj_RegPolz.CustomButton.Visible = false;
            this.metroTextBoxDolj_RegPolz.Lines = new string[0];
            this.metroTextBoxDolj_RegPolz.Location = new System.Drawing.Point(157, 277);
            this.metroTextBoxDolj_RegPolz.MaxLength = 32767;
            this.metroTextBoxDolj_RegPolz.Name = "metroTextBoxDolj_RegPolz";
            this.metroTextBoxDolj_RegPolz.PasswordChar = '\0';
            this.metroTextBoxDolj_RegPolz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDolj_RegPolz.SelectedText = "";
            this.metroTextBoxDolj_RegPolz.SelectionLength = 0;
            this.metroTextBoxDolj_RegPolz.SelectionStart = 0;
            this.metroTextBoxDolj_RegPolz.ShortcutsEnabled = true;
            this.metroTextBoxDolj_RegPolz.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxDolj_RegPolz.TabIndex = 70;
            this.metroTextBoxDolj_RegPolz.UseSelectable = true;
            this.metroTextBoxDolj_RegPolz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDolj_RegPolz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxDoljInt
            // 
            this.metroTextBoxDoljInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxDoljInt.CustomButton.Image = null;
            this.metroTextBoxDoljInt.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxDoljInt.CustomButton.Name = "";
            this.metroTextBoxDoljInt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxDoljInt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxDoljInt.CustomButton.TabIndex = 1;
            this.metroTextBoxDoljInt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxDoljInt.CustomButton.UseSelectable = true;
            this.metroTextBoxDoljInt.CustomButton.Visible = false;
            this.metroTextBoxDoljInt.Lines = new string[0];
            this.metroTextBoxDoljInt.Location = new System.Drawing.Point(343, 404);
            this.metroTextBoxDoljInt.MaxLength = 32767;
            this.metroTextBoxDoljInt.Name = "metroTextBoxDoljInt";
            this.metroTextBoxDoljInt.PasswordChar = '\0';
            this.metroTextBoxDoljInt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDoljInt.SelectedText = "";
            this.metroTextBoxDoljInt.SelectionLength = 0;
            this.metroTextBoxDoljInt.SelectionStart = 0;
            this.metroTextBoxDoljInt.ShortcutsEnabled = true;
            this.metroTextBoxDoljInt.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxDoljInt.TabIndex = 72;
            this.metroTextBoxDoljInt.UseSelectable = true;
            this.metroTextBoxDoljInt.Visible = false;
            this.metroTextBoxDoljInt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxDoljInt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroComboBoxRole_RegPolz
            // 
            this.metroComboBoxRole_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboBoxRole_RegPolz.DataSource = this.roleBindingSource;
            this.metroComboBoxRole_RegPolz.DisplayMember = "Name_Role";
            this.metroComboBoxRole_RegPolz.FormattingEnabled = true;
            this.metroComboBoxRole_RegPolz.ItemHeight = 23;
            this.metroComboBoxRole_RegPolz.Location = new System.Drawing.Point(525, 280);
            this.metroComboBoxRole_RegPolz.Name = "metroComboBoxRole_RegPolz";
            this.metroComboBoxRole_RegPolz.Size = new System.Drawing.Size(146, 29);
            this.metroComboBoxRole_RegPolz.TabIndex = 73;
            this.metroComboBoxRole_RegPolz.UseSelectable = true;
            this.metroComboBoxRole_RegPolz.ValueMember = "ID_Role";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.melans_LLCDataSet;
            // 
            // melans_LLCDataSet
            // 
            this.melans_LLCDataSet.DataSetName = "Melans_LLCDataSet";
            this.melans_LLCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(479, 284);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(41, 19);
            this.metroLabel10.TabIndex = 74;
            this.metroLabel10.Text = "Роль:";
            this.metroLabel10.UseStyleColors = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // metroTextBoxRole
            // 
            this.metroTextBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBoxRole.CustomButton.Image = null;
            this.metroTextBoxRole.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.metroTextBoxRole.CustomButton.Name = "";
            this.metroTextBoxRole.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRole.CustomButton.TabIndex = 1;
            this.metroTextBoxRole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRole.CustomButton.UseSelectable = true;
            this.metroTextBoxRole.CustomButton.Visible = false;
            this.metroTextBoxRole.Lines = new string[0];
            this.metroTextBoxRole.Location = new System.Drawing.Point(527, 404);
            this.metroTextBoxRole.MaxLength = 32767;
            this.metroTextBoxRole.Name = "metroTextBoxRole";
            this.metroTextBoxRole.PasswordChar = '\0';
            this.metroTextBoxRole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRole.SelectedText = "";
            this.metroTextBoxRole.SelectionLength = 0;
            this.metroTextBoxRole.SelectionStart = 0;
            this.metroTextBoxRole.ShortcutsEnabled = true;
            this.metroTextBoxRole.Size = new System.Drawing.Size(146, 23);
            this.metroTextBoxRole.TabIndex = 75;
            this.metroTextBoxRole.UseSelectable = true;
            this.metroTextBoxRole.Visible = false;
            this.metroTextBoxRole.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRole.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // metroComboTech_RegPolz
            // 
            this.metroComboTech_RegPolz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroComboTech_RegPolz.DataSource = this.technikaBindingSource;
            this.metroComboTech_RegPolz.DisplayMember = "Name_Tech";
            this.metroComboTech_RegPolz.FormattingEnabled = true;
            this.metroComboTech_RegPolz.ItemHeight = 23;
            this.metroComboTech_RegPolz.Location = new System.Drawing.Point(525, 317);
            this.metroComboTech_RegPolz.Name = "metroComboTech_RegPolz";
            this.metroComboTech_RegPolz.Size = new System.Drawing.Size(146, 29);
            this.metroComboTech_RegPolz.TabIndex = 76;
            this.metroComboTech_RegPolz.UseSelectable = true;
            this.metroComboTech_RegPolz.ValueMember = "ID_Tech";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(459, 318);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(61, 19);
            this.metroLabel11.TabIndex = 77;
            this.metroLabel11.Text = "Техника:";
            this.metroLabel11.UseStyleColors = true;
            // 
            // melans_LLCDataSetNewVariant
            // 
            this.melans_LLCDataSetNewVariant.DataSetName = "Melans_LLCDataSetNewVariant";
            this.melans_LLCDataSetNewVariant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technikaBindingSource
            // 
            this.technikaBindingSource.DataMember = "Technika";
            this.technikaBindingSource.DataSource = this.melans_LLCDataSetNewVariant;
            // 
            // technikaTableAdapter
            // 
            this.technikaTableAdapter.ClearBeforeFill = true;
            // 
            // Registracia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Melans_LLC.Properties.Resources.blacklogo;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.BackMaxSize = 180;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroComboTech_RegPolz);
            this.Controls.Add(this.metroTextBoxRole);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroComboBoxRole_RegPolz);
            this.Controls.Add(this.metroTextBoxDoljInt);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroTextBoxDolj_RegPolz);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroTextBoxRepeatPass_RegPolz);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroTextBoxPass_RegPolz);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBoxEmail_RegPolz);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBoxLog_RegPolz);
            this.Controls.Add(this.maskedTextBoxTel_RegPolz);
            this.Controls.Add(this.metroTextBoxO_RegPolz);
            this.Controls.Add(this.metroTextBoxI_RegPolz);
            this.Controls.Add(this.metroTextBoxF_RegPolz);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registracia";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Регистрация пользователя";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Registracia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melans_LLCDataSetNewVariant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxF_RegPolz;
        private MetroFramework.Controls.MetroTextBox metroTextBoxI_RegPolz;
        private MetroFramework.Controls.MetroTextBox metroTextBoxO_RegPolz;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel_RegPolz;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLog_RegPolz;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEmail_RegPolz;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPass_RegPolz;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRepeatPass_RegPolz;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDolj_RegPolz;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDoljInt;
        private MetroFramework.Controls.MetroComboBox metroComboBoxRole_RegPolz;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private Melans_LLCDataSet melans_LLCDataSet;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private Melans_LLCDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRole;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox metroComboTech_RegPolz;
        private Melans_LLCDataSetNewVariant melans_LLCDataSetNewVariant;
        private System.Windows.Forms.BindingSource technikaBindingSource;
        private Melans_LLCDataSetNewVariantTableAdapters.TechnikaTableAdapter technikaTableAdapter;
    }
}