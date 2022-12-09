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
    public partial class Bleeding : Form
    {
        public Bleeding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstAid firstaid = new FirstAid();
            Hide();
            firstaid.Show();
        }
    }
}
