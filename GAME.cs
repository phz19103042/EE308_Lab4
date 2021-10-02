using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 博饼游戏
{
    public partial class GAME : Form
    {
        private int[] a = new int[7];
        private int[] count = new int[7];
        public GAME()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Enabled = false;
            Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i < 7; i++)
                count[i] = 0;
            Random randomNumbers = new Random();
            a[1] = randomNumbers.Next(1, 7); count[a[1]]++;
            pictureBox1.Image = (Image)
                (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[1])));
            a[2] = randomNumbers.Next(1, 7); count[a[2]]++;
            pictureBox2.Image = (Image)
               (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[2])));
            a[3] = randomNumbers.Next(1, 7); count[a[3]]++;
            pictureBox3.Image = (Image)
              (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[3])));
            a[4] = randomNumbers.Next(1, 7); count[a[4]]++;
            pictureBox4.Image = (Image)
               (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[4])));
            a[5] = randomNumbers.Next(1, 7); count[a[5]]++;
            pictureBox5.Image = (Image)
               (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[5])));
            a[6] = randomNumbers.Next(1, 7); count[a[6]]++;
            pictureBox6.Image = (Image)
               (Properties.Resources.ResourceManager.GetObject(string.Format("_{0}", a[6])));

        }
        private void Play()
        {
             if (count[4] == 6)
                MessageBox.Show("恭喜你，满堂红！博饼积分+800。\n");
            else if (count[4] == 5)
                MessageBox.Show("恭喜你，五红！博饼积分+300。\n");
            else if (count[4] == 4)
            {
                if (count[1] == 2)
                    MessageBox.Show("恭喜你，状元插金花！博饼积分+1000。\n");
                else
                    MessageBox.Show("恭喜你，状元！博饼积分+500。\n");
            }
            else if (count[4] == 3)
                MessageBox.Show("恭喜你，三红！博饼积分+200。\n");
            else if (count[4] == 2)
            {
                if (count[1] == 4 || count[2] == 4 || count[3] == 4 || count[5] == 4 || count[6] == 4)
                    MessageBox.Show("恭喜你，四进！博饼积分+100。\n");
                else
                    MessageBox.Show("恭喜你，二举！博饼积分+50。\n");
            }
            else if (count[4] == 1)
            {
                if (count[1] == 4 || count[2] == 4 || count[3] == 4 || count[5] == 4 || count[6] == 4)
                    MessageBox.Show("恭喜你，四进！博饼积分+100。\n");
                else if (count[1] == 5 || count[2] == 5 || count[3] == 5 || count[5] == 5 || count[6] == 5)
                    MessageBox.Show("恭喜你，五子！博饼积分+100。\n");
                else if (count[1] == 1 && count[2] == 1 && count[3] == 1 && count[5] == 1 && count[6] == 1)
                    MessageBox.Show("恭喜你，对堂！博饼积分+300。\n");
                else
                    MessageBox.Show("恭喜你，一秀！博饼积分+10。\n");
            }
            else if (count[4] == 0)
            {
                if (count[1] == 6 || count[2] == 6 || count[3] == 6 || count[5] == 6 || count[6] == 6)
                    MessageBox.Show("人品爆发，可惜要接受惩罚...\n");
                else if (count[1] == 5 || count[2] == 5 || count[3] == 5 || count[5] == 5 || count[6] == 5)
                    MessageBox.Show("恭喜你，五子！博饼积分+500。\n");
                else if (count[1] == 4 || count[2] == 4 || count[3] == 4 || count[5] == 4 || count[6] == 4)
                    MessageBox.Show("恭喜你，四进！博饼积分+100。\n");
                else
                    MessageBox.Show("很遗憾，没有积分，下次继续努力！\n");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}


    

