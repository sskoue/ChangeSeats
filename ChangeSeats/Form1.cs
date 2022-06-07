using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeSeats
{
    public partial class frmChangeSeats : Form
    {
        public frmChangeSeats()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("a");
            listBox1.Items.Add("b");
            listBox1.Items.Add("c");
            listBox1.Items.Add("d");
            listBox1.Items.Add("e");
            listBox1.Items.Add("f");
            listBox1.Items.Add("g");
            listBox1.Items.Add("h");
            listBox1.Items.Add("i");
            listBox1.Items.Add("j");
            listBox1.Items.Add("k");
            listBox1.Items.Add("l");
            listBox1.Items.Add("m");
            listBox1.Items.Add("n");
            listBox1.Items.Add("o");
            listBox1.Items.Add("p");
            listBox1.Items.Add("q");
            listBox1.Items.Add("r");
            listBox1.Items.Add("s");
            listBox1.Items.Add("t");
            listBox1.Items.Add("u");
            listBox1.Items.Add("v");
            listBox1.Items.Add("w");
            listBox1.Items.Add("x");
            listBox1.Items.Add("y");
            listBox1.Items.Add("z");
            listBox1.Items.Add("aa");
            listBox1.Items.Add("ab");
            lbl_numbers.Text = ("人数　" + listBox1.Items.Count + "人");
        }


        // 選択されたリストボックスの要素を削除
        private void RemoveName(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(idx);
            lbl_numbers.Text = ("人数　" + listBox1.Items.Count + "人");
        }


        // 入力された名前を追加
        private void AddName(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_addName.Text);
            lbl_numbers.Text = ("人数　" + listBox1.Items.Count + "人");
        }


        // 席替え
        private void ChangeSeats(object sender, EventArgs e)
        {
            // 0～27の配列
            int[] RandSeats = new int[28];
            for (int i = 0; i < 28; i++)
            {
                RandSeats[i] = i;
            }

            // シャッフル
            Random rand = new Random();
            for (int i = RandSeats.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = RandSeats[i];
                RandSeats[i] = RandSeats[j];
                RandSeats[j] = tmp;
            }

            // GUIに表示
            textBox1.Text = listBox1.Items[RandSeats[0]].ToString();
            textBox2.Text = listBox1.Items[RandSeats[1]].ToString();
            textBox3.Text = listBox1.Items[RandSeats[2]].ToString();
            textBox4.Text = listBox1.Items[RandSeats[3]].ToString();
            textBox5.Text = listBox1.Items[RandSeats[4]].ToString();
            textBox6.Text = listBox1.Items[RandSeats[5]].ToString();
            textBox7.Text = listBox1.Items[RandSeats[6]].ToString();
            textBox8.Text = listBox1.Items[RandSeats[7]].ToString();
            textBox9.Text = listBox1.Items[RandSeats[8]].ToString();
            textBox10.Text = listBox1.Items[RandSeats[9]].ToString();
            textBox11.Text = listBox1.Items[RandSeats[10]].ToString();
            textBox12.Text = listBox1.Items[RandSeats[11]].ToString();
            textBox13.Text = listBox1.Items[RandSeats[12]].ToString();
            textBox14.Text = listBox1.Items[RandSeats[13]].ToString();
            textBox15.Text = listBox1.Items[RandSeats[14]].ToString();
            textBox16.Text = listBox1.Items[RandSeats[15]].ToString();
            textBox17.Text = listBox1.Items[RandSeats[16]].ToString();
            textBox18.Text = listBox1.Items[RandSeats[17]].ToString();
            textBox19.Text = listBox1.Items[RandSeats[18]].ToString();
            textBox20.Text = listBox1.Items[RandSeats[19]].ToString();
            textBox21.Text = listBox1.Items[RandSeats[20]].ToString();
            textBox22.Text = listBox1.Items[RandSeats[21]].ToString();
            textBox23.Text = listBox1.Items[RandSeats[22]].ToString();
            textBox24.Text = listBox1.Items[RandSeats[23]].ToString();
            textBox25.Text = listBox1.Items[RandSeats[24]].ToString();
            textBox26.Text = listBox1.Items[RandSeats[25]].ToString();
            textBox27.Text = listBox1.Items[RandSeats[26]].ToString();
            textBox28.Text = listBox1.Items[RandSeats[27]].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label172_Click(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }
    }
}
