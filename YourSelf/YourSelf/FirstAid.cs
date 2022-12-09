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
    public partial class FirstAid : Form
    {
        public FirstAid()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Injury injury = new Injury();
            Hide();
            injury.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bleeding bleeding = new Bleeding();
            Hide();
            bleeding.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            Hide();
            fr1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Poisoning poisoning = new Poisoning();
            Hide();
            poisoning.Show();
        }
    }
}
