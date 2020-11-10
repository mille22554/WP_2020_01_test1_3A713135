using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_2020_01_test1_3A713135
{
    public partial class Form1 : Form
    {
        public int cash = 0,pic=0;
        Random card = new Random();
        gacya gacya = new gacya();
        public ResourceManager rm = new ResourceManager(typeof(WP_2020_01_test1_3A713135.Properties.Resources));
        Form2 f2;
        Form3 f3;
        public void cashchange(int change,int wol)
        {
            if (wol == 0) cash = cash- change;
            else cash = cash+ change;
            if (cash < 1&&f3.c[0]<1 && f3.c[1] < 1 && f3.c[2] < 1 && f3.c[3] < 1 
                && f3.c[4] < 1 && f3.c[5] < 1 && f3.c[6] < 1 && f3.c[7] < 1 
                && f3.c[8] < 1 && f3.c[9] < 1 && f3.c[10] < 1 && f3.c[11] < 1)
            {
                label1.Text = "剩餘金錢:0";
                MessageBox.Show("你破產了。", "遊戲結束", MessageBoxButtons.OK);
                this.Close();
            }
            else label1.Text = "剩餘金錢:" + cash;
        }
        public void labelchange()
        {
            label1.Text = "剩餘金錢:" + cash;
        }
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            f3 = new Form3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2.Visible = false;
            f3.Visible = false;
            cash = 3000;
            label1.Text = "剩餘金錢:" + cash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cash < 30) MessageBox.Show("你的錢不夠抽卡。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                /*
                    卡片機率 卡價
                1階 50%      10
                2階 30%      30
                3階 17%      80
                4階 3%       400

                期望值:-20*0.5+0*0.3+20*0.17+70*0.03=
                 */
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                cash = cash - 30;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox1.Image= rm.GetObject(pic.ToString()) as Image;
                f3.c[pic-1]++;
                if (cash < 1 && f3.c[0] < 1 && f3.c[1] < 1 && f3.c[2] < 1 && f3.c[3] < 1 
                    && f3.c[4] < 1 && f3.c[5] < 1 && f3.c[6] < 1 && f3.c[7] < 1 
                    && f3.c[8] < 1 && f3.c[9] < 1 && f3.c[10] < 1 && f3.c[11] < 1)
                {
                    label1.Text = "剩餘金錢:0";
                    MessageBox.Show("你破產了。", "遊戲結束", MessageBoxButtons.OK);
                    this.Close();
                }
                else if(f3.c[0] > 0 && f3.c[1] > 0 && f3.c[2] > 0 && f3.c[3] > 0
                    && f3.c[4] > 0 && f3.c[5] > 0 && f3.c[6] > 0 && f3.c[7] > 0
                    && f3.c[8] > 0 && f3.c[9] > 0 && f3.c[10] > 0 && f3.c[11] > 0)
                {
                    MessageBox.Show("你獲勝了。", "恭喜!", MessageBoxButtons.OK);
                    this.Close();
                }
                else label1.Text = "剩餘金錢:" + cash;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遊戲目標:將全圖鑑收集完成。破產的話則失敗。\r\n賺錢:和人比骰子大小，教小的一方要付給大的一方點數差X10的錢。","遊戲說明" ,MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cash < 300) MessageBox.Show("你的錢不夠抽卡。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                cash = cash - 300;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox1.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic-1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox2.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox3.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox4.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox5.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox6.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox7.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox8.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox9.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox10.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
                pic = gacya.Gacya(card.Next(1, 101));
                pictureBox11.Image = rm.GetObject(pic.ToString()) as Image;
                f3.c[pic - 1]++;
            }
            if (cash < 1 && f3.c[0] < 1 && f3.c[1] < 1 && f3.c[2] < 1 && f3.c[3] < 1 && f3.c[4] < 1 && f3.c[5] < 1 && f3.c[6] < 1 && f3.c[7] < 1 && f3.c[8] < 1 && f3.c[9] < 1 && f3.c[10] < 1 && f3.c[11] < 1)
            {
                label1.Text = "剩餘金錢:0";
                MessageBox.Show("你破產了。", "遊戲結束", MessageBoxButtons.OK);
                this.Close();
            }
            else if (f3.c[0] > 0 && f3.c[1] > 0 && f3.c[2] > 0 && f3.c[3] > 0
                && f3.c[4] > 0 && f3.c[5] > 0 && f3.c[6] > 0 && f3.c[7] > 0
                && f3.c[8] > 0 && f3.c[9] > 0 && f3.c[10] > 0 && f3.c[11] > 0)
            {
                MessageBox.Show("你獲勝了。", "恭喜!", MessageBoxButtons.OK);
                this.Close();
            }
            else label1.Text = "剩餘金錢:" + cash;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f2.ShowDialog(this);
        }
    }
}
