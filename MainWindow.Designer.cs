namespace Melans_LLC
{
    partial class MainWindow
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.header = new System.Windows.Forms.Panel();
            this.Button_Uslug = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.Button_Proiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Admin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Sys_Admin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Otdel_Kadrov = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Injener = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMnu = new Bunifu.Framework.UI.BunifuImageButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bindingSourceMelans_LLC = new System.Windows.Forms.BindingSource(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidemenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMelans_LLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.Button_Uslug);
            this.header.Controls.Add(this.bunifuFlatButton8);
            this.header.Controls.Add(this.bunifuFlatButton10);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.bunifuFlatButton7);
            this.header.Controls.Add(this.bunifuFlatButton6);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.bunifuFlatButton1);
            this.LogoAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1401, 56);
            this.header.TabIndex = 11;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.header.MouseEnter += new System.EventHandler(this.dragChange);
            // 
            // Button_Uslug
            // 
            this.Button_Uslug.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Button_Uslug.BackColor = System.Drawing.Color.RoyalBlue;
            this.Button_Uslug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Uslug.BorderRadius = 0;
            this.Button_Uslug.ButtonText = "Услуги";
            this.Button_Uslug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Uslug, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Uslug, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Uslug, BunifuAnimatorNS.DecorationType.None);
            this.Button_Uslug.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Uslug.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Uslug.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Uslug.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Uslug.Iconimage")));
            this.Button_Uslug.Iconimage_right = null;
            this.Button_Uslug.Iconimage_right_Selected = null;
            this.Button_Uslug.Iconimage_Selected = null;
            this.Button_Uslug.IconMarginLeft = 0;
            this.Button_Uslug.IconMarginRight = 0;
            this.Button_Uslug.IconRightVisible = true;
            this.Button_Uslug.IconRightZoom = 0D;
            this.Button_Uslug.IconVisible = true;
            this.Button_Uslug.IconZoom = 70D;
            this.Button_Uslug.IsTab = false;
            this.Button_Uslug.Location = new System.Drawing.Point(251, 0);
            this.Button_Uslug.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Uslug.Name = "Button_Uslug";
            this.Button_Uslug.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.Button_Uslug.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Uslug.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Uslug.selected = false;
            this.Button_Uslug.Size = new System.Drawing.Size(184, 56);
            this.Button_Uslug.TabIndex = 17;
            this.Button_Uslug.Text = "Услуги";
            this.Button_Uslug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Uslug.Textcolor = System.Drawing.Color.White;
            this.Button_Uslug.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Uslug.Click += new System.EventHandler(this.Button_Uslug_Click);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "Корзина";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton8.Iconimage")));
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 70D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(435, 0);
            this.bunifuFlatButton8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(191, 56);
            this.bunifuFlatButton8.TabIndex = 16;
            this.bunifuFlatButton8.Text = "Корзина";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton8.Click += new System.EventHandler(this.bunifuFlatButton8_Click);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "Обратная связь";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton10.Iconimage")));
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 70D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(626, 0);
            this.bunifuFlatButton10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(194, 56);
            this.bunifuFlatButton10.TabIndex = 15;
            this.bunifuFlatButton10.Text = "Обратная связь";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click);
            // 
            // pictureBox2
            // 
            this.PanelAnimator2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(59, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.dragChange);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Настройка интерфейса";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton7.Iconimage")));
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 70D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(820, 0);
            this.bunifuFlatButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(208, 56);
            this.bunifuFlatButton7.TabIndex = 11;
            this.bunifuFlatButton7.Text = "Настройка интерфейса";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "Регистрация";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton6.Iconimage")));
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 70D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(1028, 0);
            this.bunifuFlatButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(193, 56);
            this.bunifuFlatButton6.TabIndex = 10;
            this.bunifuFlatButton6.Text = "Регистрация";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // pictureBox1
            // 
            this.PanelAnimator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Melans_LLC.Properties.Resources._99717e8ae2c9a113c76b226ea985a0b1__m_letter_big_letters;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.dragChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Выйти из программы";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1221, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.RoyalBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(180, 56);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Выйти из программы";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // metroContextMenu1
            // 
            this.LogoAnimator.SetDecoration(this.metroContextMenu1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.metroContextMenu1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.metroContextMenu1, BunifuAnimatorNS.DecorationType.None);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            this.metroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.White;
            this.sidemenu.Controls.Add(this.Button_Proiz);
            this.sidemenu.Controls.Add(this.Button_Admin);
            this.sidemenu.Controls.Add(this.Button_Sys_Admin);
            this.sidemenu.Controls.Add(this.Button_Otdel_Kadrov);
            this.sidemenu.Controls.Add(this.Button_Injener);
            this.sidemenu.Controls.Add(this.panel1);
            this.LogoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 56);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(290, 563);
            this.sidemenu.TabIndex = 16;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Button_Proiz
            // 
            this.Button_Proiz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Proiz.BackColor = System.Drawing.Color.Transparent;
            this.Button_Proiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Proiz.BorderRadius = 0;
            this.Button_Proiz.ButtonText = "     Производительность CPU && RAM";
            this.Button_Proiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Proiz, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Proiz, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Proiz, BunifuAnimatorNS.DecorationType.None);
            this.Button_Proiz.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Proiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Proiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Proiz.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Proiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Proiz.Iconimage")));
            this.Button_Proiz.Iconimage_right = null;
            this.Button_Proiz.Iconimage_right_Selected = null;
            this.Button_Proiz.Iconimage_Selected = null;
            this.Button_Proiz.IconMarginLeft = 0;
            this.Button_Proiz.IconMarginRight = 0;
            this.Button_Proiz.IconRightVisible = true;
            this.Button_Proiz.IconRightZoom = 0D;
            this.Button_Proiz.IconVisible = true;
            this.Button_Proiz.IconZoom = 90D;
            this.Button_Proiz.IsTab = true;
            this.Button_Proiz.Location = new System.Drawing.Point(0, 274);
            this.Button_Proiz.Name = "Button_Proiz";
            this.Button_Proiz.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Proiz.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_Proiz.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.Button_Proiz.selected = false;
            this.Button_Proiz.Size = new System.Drawing.Size(290, 52);
            this.Button_Proiz.TabIndex = 17;
            this.Button_Proiz.Text = "     Производительность CPU && RAM";
            this.Button_Proiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Proiz.Textcolor = System.Drawing.Color.Black;
            this.Button_Proiz.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Button_Proiz.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Button_Admin
            // 
            this.Button_Admin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Admin.BackColor = System.Drawing.Color.Transparent;
            this.Button_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Admin.BorderRadius = 0;
            this.Button_Admin.ButtonText = "Для администратора";
            this.Button_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Admin, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Admin, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Admin, BunifuAnimatorNS.DecorationType.None);
            this.Button_Admin.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Admin.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Admin.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Admin.Iconimage")));
            this.Button_Admin.Iconimage_right = null;
            this.Button_Admin.Iconimage_right_Selected = null;
            this.Button_Admin.Iconimage_Selected = null;
            this.Button_Admin.IconMarginLeft = 0;
            this.Button_Admin.IconMarginRight = 0;
            this.Button_Admin.IconRightVisible = true;
            this.Button_Admin.IconRightZoom = 0D;
            this.Button_Admin.IconVisible = true;
            this.Button_Admin.IconZoom = 90D;
            this.Button_Admin.IsTab = true;
            this.Button_Admin.Location = new System.Drawing.Point(0, 222);
            this.Button_Admin.Name = "Button_Admin";
            this.Button_Admin.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Admin.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_Admin.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.Button_Admin.selected = false;
            this.Button_Admin.Size = new System.Drawing.Size(290, 52);
            this.Button_Admin.TabIndex = 16;
            this.Button_Admin.Text = "Для администратора";
            this.Button_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Admin.Textcolor = System.Drawing.Color.Black;
            this.Button_Admin.TextFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Button_Admin.Click += new System.EventHandler(this.Button_Admin_Click);
            // 
            // Button_Sys_Admin
            // 
            this.Button_Sys_Admin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Sys_Admin.BackColor = System.Drawing.Color.Transparent;
            this.Button_Sys_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Sys_Admin.BorderRadius = 0;
            this.Button_Sys_Admin.ButtonText = "Для системного администратора";
            this.Button_Sys_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Sys_Admin, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Sys_Admin, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Sys_Admin, BunifuAnimatorNS.DecorationType.None);
            this.Button_Sys_Admin.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Sys_Admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Sys_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Sys_Admin.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Sys_Admin.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Sys_Admin.Iconimage")));
            this.Button_Sys_Admin.Iconimage_right = null;
            this.Button_Sys_Admin.Iconimage_right_Selected = null;
            this.Button_Sys_Admin.Iconimage_Selected = null;
            this.Button_Sys_Admin.IconMarginLeft = 0;
            this.Button_Sys_Admin.IconMarginRight = 0;
            this.Button_Sys_Admin.IconRightVisible = true;
            this.Button_Sys_Admin.IconRightZoom = 0D;
            this.Button_Sys_Admin.IconVisible = true;
            this.Button_Sys_Admin.IconZoom = 90D;
            this.Button_Sys_Admin.IsTab = true;
            this.Button_Sys_Admin.Location = new System.Drawing.Point(0, 174);
            this.Button_Sys_Admin.Name = "Button_Sys_Admin";
            this.Button_Sys_Admin.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Sys_Admin.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_Sys_Admin.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.Button_Sys_Admin.selected = false;
            this.Button_Sys_Admin.Size = new System.Drawing.Size(290, 48);
            this.Button_Sys_Admin.TabIndex = 15;
            this.Button_Sys_Admin.Text = "Для системного администратора";
            this.Button_Sys_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Sys_Admin.Textcolor = System.Drawing.Color.Black;
            this.Button_Sys_Admin.TextFont = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Sys_Admin.Click += new System.EventHandler(this.Button_Sys_Admin_Click);
            // 
            // Button_Otdel_Kadrov
            // 
            this.Button_Otdel_Kadrov.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Otdel_Kadrov.BackColor = System.Drawing.Color.Transparent;
            this.Button_Otdel_Kadrov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Otdel_Kadrov.BorderRadius = 0;
            this.Button_Otdel_Kadrov.ButtonText = "Для отдела кадров";
            this.Button_Otdel_Kadrov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Otdel_Kadrov, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Otdel_Kadrov, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Otdel_Kadrov, BunifuAnimatorNS.DecorationType.None);
            this.Button_Otdel_Kadrov.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Otdel_Kadrov.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Otdel_Kadrov.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Otdel_Kadrov.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Otdel_Kadrov.Iconimage")));
            this.Button_Otdel_Kadrov.Iconimage_right = null;
            this.Button_Otdel_Kadrov.Iconimage_right_Selected = null;
            this.Button_Otdel_Kadrov.Iconimage_Selected = null;
            this.Button_Otdel_Kadrov.IconMarginLeft = 0;
            this.Button_Otdel_Kadrov.IconMarginRight = 0;
            this.Button_Otdel_Kadrov.IconRightVisible = true;
            this.Button_Otdel_Kadrov.IconRightZoom = 0D;
            this.Button_Otdel_Kadrov.IconVisible = true;
            this.Button_Otdel_Kadrov.IconZoom = 90D;
            this.Button_Otdel_Kadrov.IsTab = true;
            this.Button_Otdel_Kadrov.Location = new System.Drawing.Point(0, 126);
            this.Button_Otdel_Kadrov.Name = "Button_Otdel_Kadrov";
            this.Button_Otdel_Kadrov.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Otdel_Kadrov.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_Otdel_Kadrov.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.Button_Otdel_Kadrov.selected = false;
            this.Button_Otdel_Kadrov.Size = new System.Drawing.Size(290, 48);
            this.Button_Otdel_Kadrov.TabIndex = 14;
            this.Button_Otdel_Kadrov.Text = "Для отдела кадров";
            this.Button_Otdel_Kadrov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Otdel_Kadrov.Textcolor = System.Drawing.Color.Black;
            this.Button_Otdel_Kadrov.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Otdel_Kadrov.Click += new System.EventHandler(this.Button_Otdel_Kadrov_Click);
            // 
            // Button_Injener
            // 
            this.Button_Injener.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_Injener.BackColor = System.Drawing.Color.Transparent;
            this.Button_Injener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Injener.BorderRadius = 0;
            this.Button_Injener.ButtonText = "Для инженера";
            this.Button_Injener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator2.SetDecoration(this.Button_Injener, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Button_Injener, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Button_Injener, BunifuAnimatorNS.DecorationType.None);
            this.Button_Injener.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Injener.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Injener.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Injener.Iconimage = ((System.Drawing.Image)(resources.GetObject("Button_Injener.Iconimage")));
            this.Button_Injener.Iconimage_right = null;
            this.Button_Injener.Iconimage_right_Selected = null;
            this.Button_Injener.Iconimage_Selected = null;
            this.Button_Injener.IconMarginLeft = 0;
            this.Button_Injener.IconMarginRight = 0;
            this.Button_Injener.IconRightVisible = true;
            this.Button_Injener.IconRightZoom = 0D;
            this.Button_Injener.IconVisible = true;
            this.Button_Injener.IconZoom = 90D;
            this.Button_Injener.IsTab = true;
            this.Button_Injener.Location = new System.Drawing.Point(0, 78);
            this.Button_Injener.Name = "Button_Injener";
            this.Button_Injener.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Injener.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_Injener.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.Button_Injener.selected = false;
            this.Button_Injener.Size = new System.Drawing.Size(290, 48);
            this.Button_Injener.TabIndex = 12;
            this.Button_Injener.Text = "Для инженера";
            this.Button_Injener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Injener.Textcolor = System.Drawing.Color.Black;
            this.Button_Injener.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Injener.Click += new System.EventHandler(this.Button_Injener_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMnu);
            this.panel1.Controls.Add(this.logo);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 78);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMnu
            // 
            this.btnMnu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMnu.BackColor = System.Drawing.Color.Transparent;
            this.btnMnu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.btnMnu, BunifuAnimatorNS.DecorationType.None);
            this.btnMnu.Image = ((System.Drawing.Image)(resources.GetObject("btnMnu.Image")));
            this.btnMnu.ImageActive = null;
            this.btnMnu.Location = new System.Drawing.Point(251, 26);
            this.btnMnu.Name = "btnMnu";
            this.btnMnu.Size = new System.Drawing.Size(30, 30);
            this.btnMnu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMnu.TabIndex = 12;
            this.btnMnu.TabStop = false;
            this.btnMnu.Zoom = 10;
            this.btnMnu.Click += new System.EventHandler(this.btnMnu_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator2.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::Melans_LLC.Properties.Resources.blacklogo;
            this.logo.Location = new System.Drawing.Point(8, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(242, 78);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Melans_LLC.Properties.Resources.rrRT3TncqfU;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.metroTabControl1);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(290, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 563);
            this.panel2.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.LogoAnimator.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.toolStrip1, BunifuAnimatorNS.DecorationType.None);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 532);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1111, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 28);
            this.toolStripButton1.Text = "Логотип";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 28);
            this.toolStripLabel1.Text = "Сегодня: ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.BackColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(148, 28);
            this.toolStripLabel2.Text = "Вы вошли как: ";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.PanelAnimator2.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.metroTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabControl1.Location = new System.Drawing.Point(37, 41);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1046, 452);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.textBox1);
            this.LogoAnimator.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.metroTabPage1, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(1038, 410);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Главное";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator2.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.textBox1, BunifuAnimatorNS.DecorationType.None);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1038, 410);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.textBox2);
            this.LogoAnimator.SetDecoration(this.metroTabPage2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.metroTabPage2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.metroTabPage2, BunifuAnimatorNS.DecorationType.None);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1038, 410);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "О компании";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.PanelAnimator2.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.textBox2, BunifuAnimatorNS.DecorationType.None);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(1038, 410);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1401, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.header);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMnu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMelans_LLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.Panel sidemenu;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private Bunifu.Framework.UI.BunifuImageButton btnMnu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        public Bunifu.Framework.UI.BunifuFlatButton Button_Admin;
        public Bunifu.Framework.UI.BunifuFlatButton Button_Injener;
        public Bunifu.Framework.UI.BunifuFlatButton Button_Sys_Admin;
        public Bunifu.Framework.UI.BunifuFlatButton Button_Otdel_Kadrov;
        private System.Windows.Forms.BindingSource bindingSourceMelans_LLC;
        public Bunifu.Framework.UI.BunifuFlatButton Button_Proiz;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Uslug;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
    }
}