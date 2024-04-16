using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // 초기화
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.IndianRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.DarkOrange;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.ForestGreen;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.SteelBlue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Indigo;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Purple;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

 
    }
}
