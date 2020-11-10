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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random dice = new Random();
        int x, y = 0;
        Form1 f1 ;
        private void Form2_Load(object sender, EventArgs e)
        {
            f1 = (Form1)this.Owner;
        }
        public void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            x = dice.Next(1, 7);
            y = dice.Next(1, 7);
            label1.Text = "對手數字:"+x;
            label2.Text = "你的數字:" + y;
            if (x > y)
            {
                label3.Text = "你輸了"+10*(x-y)+"元";
                f1.cashchange(10 * (x - y),0);
            }
            else if (x < y)
            {
                label3.Text = "你贏了" + 10 * (y-x) + "元";
                f1.cashchange(10 * (y-x),1);
            }
            else
            {
                label3.Text = "平手";
            }
        }
    }
}
