using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_test1_3A713135
{
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            f1 = (Form1)this.Owner;
            pictureBox1.Image = f1.top[0];
            pictureBox2.Image = f1.top[1];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            f1.deckselect(1);
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            f1.deckselect(2);
            Close();
        }
        public void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
    }
}
