using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourSelf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Application.Run(new Form7());
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 start = new Form2();
            Hide();
            start.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            Hide();
            fr3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirstAid firstaid = new FirstAid();
            Hide();
            firstaid.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Incompatibility incompat = new Incompatibility();
            Hide();
            incompat.Show();
        }
    }
}
