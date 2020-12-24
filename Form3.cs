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
    public partial class Form3 : Form
    {
        Form1 f1;
        public int[] c = new int[12];
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            f1 = (Form1)this.Owner;
            label1.Text = "價格:10\r\n持有數:" + c[0];
            label2.Text = "價格:30\r\n持有數:" + c[1];
            label3.Text = "價格:80\r\n持有數:" + c[2];
            label4.Text = "價格:400\r\n持有數:" + c[3];
            label5.Text = "價格:10\r\n持有數:" + c[4];
            label6.Text = "價格:30\r\n持有數:" + c[5];
            label7.Text = "價格:80\r\n持有數:" + c[6];
            label8.Text = "價格:400\r\n持有數:" + c[7];
            label9.Text = "價格:10\r\n持有數:" + c[8];
            label10.Text = "價格:30\r\n持有數:" + c[9];
            label11.Text = "價格:80\r\n持有數:" + c[10];
            label12.Text = "價格:400\r\n持有數:" + c[11];
            if (c[0] == 0) pictureBox1.Image = null;
            else pictureBox1.Image = f1.rm.GetObject("1") as Image;
            if (c[1] == 0) pictureBox2.Image = null;
            else pictureBox2.Image = f1.rm.GetObject("2") as Image;
            if (c[2] == 0) pictureBox3.Image = null;
            else pictureBox3.Image = f1.rm.GetObject("3") as Image;
            if (c[3] == 0) pictureBox4.Image = null;
            else pictureBox4.Image = f1.rm.GetObject("4") as Image;
            if (c[4] == 0) pictureBox5.Image = null;
            else pictureBox5.Image = f1.rm.GetObject("5") as Image;
            if (c[5] == 0) pictureBox6.Image = null;
            else pictureBox6.Image = f1.rm.GetObject("6") as Image;
            if (c[6] == 0) pictureBox7.Image = null;
            else pictureBox7.Image = f1.rm.GetObject("7") as Image;
            if (c[7] == 0) pictureBox8.Image = null;
            else pictureBox8.Image = f1.rm.GetObject("8") as Image;
            if (c[8] == 0) pictureBox9.Image = null;
            else pictureBox9.Image = f1.rm.GetObject("9") as Image;
            if (c[9] == 0) pictureBox10.Image = null;
            else pictureBox10.Image = f1.rm.GetObject("10") as Image;
            if (c[10] == 0) pictureBox11.Image = null;
            else pictureBox11.Image = f1.rm.GetObject("11") as Image;
            if (c[11] == 0) pictureBox12.Image = null;
            else pictureBox12.Image = f1.rm.GetObject("12") as Image;
        }
        public void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(Convert.ToInt32( textBox1.Text)>c[0]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[0] -= Convert.ToInt32(textBox1.Text);
                f1.cash += Convert.ToInt32(textBox1.Text) * 10;
                label1.Text = "價格:10\r\n持有數:" + c[0];
                f1.labelchange();
                textBox1.Text="";
                if (c[0] == 0) pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox2.Text) > c[1]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[1] -= Convert.ToInt32(textBox2.Text);
                f1.cash += Convert.ToInt32(textBox2.Text) * 30;
                label2.Text = "價格:30\r\n持有數:" + c[1];
                f1.labelchange();
                textBox2.Text="";
                if (c[1] == 0) pictureBox2.Image = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox3.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox3.Text) > c[2]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[2] -= Convert.ToInt32(textBox3.Text);
                f1.cash += Convert.ToInt32(textBox3.Text) * 80;
                label3.Text = "價格:80\r\n持有數:" + c[2];
                f1.labelchange();
                textBox3.Text="";
                if (c[2] == 0) pictureBox3.Image = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox4.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox4.Text) > c[3]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[3] -= Convert.ToInt32(textBox4.Text);
                f1.cash += Convert.ToInt32(textBox4.Text) * 400;
                label4.Text = "價格:400\r\n持有數:" + c[3];
                f1.labelchange();
                textBox4.Text="";
                if (c[3] == 0) pictureBox4.Image = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox5.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox5.Text) > c[4]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[4] -= Convert.ToInt32(textBox5.Text);
                f1.cash += Convert.ToInt32(textBox5.Text) * 10;
                label5.Text = "價格:10\r\n持有數:" + c[4];
                f1.labelchange();
                textBox5.Text="";
                if (c[4] == 0) pictureBox5.Image = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox6.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox6.Text) > c[5]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[5] -= Convert.ToInt32(textBox6.Text);
                f1.cash += Convert.ToInt32(textBox6.Text) * 30;
                label6.Text = "價格:30\r\n持有數:" + c[5];
                f1.labelchange();
                textBox6.Text="";
                if (c[5] == 0) pictureBox6.Image = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox7.Text) > c[6]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[6] -= Convert.ToInt32(textBox7.Text);
                f1.cash += Convert.ToInt32(textBox7.Text) * 80;
                label7.Text = "價格:80\r\n持有數:" + c[6];
                f1.labelchange();
                textBox7.Text="";
                if (c[6] == 0) pictureBox7.Image = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox8.Text) > c[7]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[7] -= Convert.ToInt32(textBox8.Text);
                f1.cash += Convert.ToInt32(textBox8.Text) * 400;
                label8.Text = "價格:400\r\n持有數:" + c[7];
                f1.labelchange();
                textBox8.Text="";
                if (c[7] == 0) pictureBox8.Image = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox9.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox9.Text) > c[8]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[8] -= Convert.ToInt32(textBox9.Text);
                f1.cash += Convert.ToInt32(textBox9.Text) * 10;
                label9.Text = "價格:10\r\n持有數:" + c[8];
                f1.labelchange();
                textBox9.Text="";
                if (c[8] == 0) pictureBox9.Image = null;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox10.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox10.Text) > c[9]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[9] -= Convert.ToInt32(textBox10.Text);
                f1.cash += Convert.ToInt32(textBox10.Text) * 30;
                label10.Text = "價格:30\r\n持有數:" + c[9];
                f1.labelchange();
                textBox10.Text="";
                if (c[9] == 0) pictureBox10.Image = null;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox11.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox11.Text) > c[10]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[10] -= Convert.ToInt32(textBox11.Text);
                f1.cash += Convert.ToInt32(textBox11.Text) * 10;
                label11.Text = "價格:80\r\n持有數:" + c[10];
                f1.labelchange();
                textBox11.Text="";
                if (c[10] == 0) pictureBox11.Image = null;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox12.Text)) MessageBox.Show("請不要輸入空白!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToInt32(textBox12.Text) > c[11]) MessageBox.Show("你不能賣超過持有數的卡片!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                c[11] -= Convert.ToInt32(textBox12.Text);
                f1.cash += Convert.ToInt32(textBox12.Text) * 10;
                label12.Text = "價格:400\r\n持有數:" + c[11];
                f1.labelchange();
                textBox12.Text="";
                if (c[11] == 0) pictureBox12.Image = null;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
