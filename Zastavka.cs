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
    public partial class Zastavka : Form
    {
        private bool altF4 = false;
        Con_Base _CB = new Con_Base();
        public Zastavka()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altF4)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                altF4 = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                altF4 = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (label1.Text.Length > 10)
            {
                label1.Text = "Loading";
            }
            else
            {
                label1.Text = label1.Text + ".";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Avtoriz _AV = new Avtoriz();
            _AV.Show();
            timer2.Enabled = false;
            this.Hide();
        }
    }
}
