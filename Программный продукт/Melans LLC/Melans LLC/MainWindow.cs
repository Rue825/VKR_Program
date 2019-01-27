using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Melans_LLC
{
    public partial class MainWindow : Form
    {
        Con_Base _CB = new Con_Base(); //Создание подключение к БД

        private bool altF4 = false;
        public MainWindow()
        {
            InitializeComponent();
            GetSetStyleTheme.EventHandler = new GetSetStyleTheme.MyEvent(changeTheme);
            GetSetStyleTheme.EventHandlerColor = new GetSetStyleTheme.MyEventColor(changeColor);
        }

        public void changeTheme(Color color, Image image, Image ImageResources, Color color1, MetroThemeStyle theme)
        {
            this.BackColor = color;
            sidemenu.BackColor = color;
            header.BackColor = color;
            pictureBox2.Image = image;
            logo.Image = ImageResources;
            panel1.BackColor = color;
            Button_Injener.Textcolor = color1;
            Button_Admin.Textcolor = color1;
            Button_Otdel_Kadrov.Textcolor = color1;
            Button_Sys_Admin.Textcolor = color1;
            Button_Proiz.Textcolor = color1;
            this.metroStyleManager1.Theme = theme;
            toolStrip1.BackColor = color;
            toolStripLabel1.ForeColor = color1;
            toolStripLabel2.ForeColor = color1;
            textBox1.BackColor = color;
            textBox1.ForeColor = color1;
            textBox2.BackColor = color;
            textBox2.ForeColor = color1;
        }
        public void changeColor(MetroColorStyle color_Style)
        {
            this.metroStyleManager1.Style = color_Style;
        }


        private static void PaintTransparentBackground(Control c, PaintEventArgs e) //Оформление панели
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;
            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground((sender as Panel), e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, (sender as Panel).BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            btnMnu_Click(this, new EventArgs());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground((sender as Panel), e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, (sender as Panel).BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Day = DateTime.Today;
            DateTime Time = DateTime.Now;
            toolStripLabel1.Text = "Сегодня: " + Day.ToString("dd.MM.yyyy") + " "+ Time.ToString("HH:mm:ss");
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                altF4 = true;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altF4)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                altF4 = false;
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            switch (MetroFramework.MetroMessageBox.Show(this, "Завершить работу приложения?", "Melanc_LLC", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    this.Enabled = true;
                    break;
            }
        }

        private void btnMnu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 50)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 290;
                PanelAnimator2.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                LogoAnimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 50;
                PanelAnimator.ShowSync(sidemenu);
            }
        }

        private void Button_Injener_Click(object sender, EventArgs e)
        {
            Dlya_Injenera _DI = new Dlya_Injenera();
            _DI.ShowDialog();
        }

        private void Button_Otdel_Kadrov_Click(object sender, EventArgs e)
        {
            Dlya_Otdela_Kadrov _DOK = new Dlya_Otdela_Kadrov();
            _DOK.ShowDialog();
        }

        private void Button_Sys_Admin_Click(object sender, EventArgs e)
        {
            Dlya_Systemnogo_Administratora _DSA = new Dlya_Systemnogo_Administratora();
            _DSA.ShowDialog();
        }

        private void Button_Admin_Click(object sender, EventArgs e)
        {
            Dlya_Administratora _DA = new Dlya_Administratora();
            _DA.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Avtoriz _A = new Avtoriz();
            MainWindow _MW = new MainWindow();
            //this.Hide();
            this.Close();
            _MW.Hide();
            _A.Show();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            FeedBack _FB = new FeedBack();
            _FB.ShowDialog();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Registracia _R = new Registracia();
            _R.ShowDialog();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Settings_Interface _SI = new Settings_Interface();
            _SI.ShowDialog();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Korzina _K = new Korzina();
            _K.metroLabelNameUslug.Text = Program.Znach_Korzina_1;
            _K.metroLabelOpisUslug.Text = Program.Znach_Korzina_2;
            _K.metroLabelDateCreateUslug.Text = Program.Znach_Korzina_3;
            _K.metroLabelTimeCreateUslug.Text = Program.Znach_Korzina_4;
            _K.metroLabelCenaUslug.Text = Program.Znach_Korzina_5;
            _K.metroTextBoxUslug_ID.Text = Convert.ToString(Program.Uslug_ID);
            _K.ShowDialog();
        }

        private void Button_Uslug_Click(object sender, EventArgs e)
        {
            Uslugi _U = new Uslugi();
            _U.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            StatistikaProiz _SP = new StatistikaProiz();
            _SP.ShowDialog();
        }
        public void dragChange(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuDragControl drag = new Bunifu.Framework.UI.BunifuDragControl();
            var control = (Control)sender;
            drag.TargetControl = control;
        }
    }
}
