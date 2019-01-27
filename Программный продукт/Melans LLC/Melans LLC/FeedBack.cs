using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melans_LLC
{
    public partial class FeedBack : MetroFramework.Forms.MetroForm
    {
        public FeedBack()
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox3.Text == string.Empty || metroTextBox1.Text == string.Empty || metroTextBox2.Text == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Поля должны быть заполнены", "Melans LLC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                metroProgressSpinner1.Visible = true;
                Refresh();
                {
                    SendMail sendMail = new SendMail(metroTextBox3.Text, metroTextBox1.Text, metroTextBox2.Text);
                    sendMail.MySendMail();
                    metroProgressSpinner1.Visible = false;
                    Refresh();
                }
            }
        }
    }
}
