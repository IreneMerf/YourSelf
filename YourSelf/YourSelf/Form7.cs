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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void Form7_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            tmr.Interval = 3000;

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            tmr.Stop(); 

            Form1 mf = new Form1();

            mf.Show();

           Hide();

        }
    }
}
