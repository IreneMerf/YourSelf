﻿using System;
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
    public partial class Poisoning : Form
    {
        public Poisoning()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstAid firstaid = new FirstAid();
            Hide();
            firstaid.Show();
        }
    }
}
