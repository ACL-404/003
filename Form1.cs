﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt01_Click(object sender, EventArgs e)
        {
            text01.Text = "who!";
            text02.Text = "what!";
        }

        private void bt02_Click(object sender, EventArgs e)
        {
            text01.Text = "蛤";
            text02.Text = "蛤";
        }

        private void bt03_Click(object sender, EventArgs e)
        {
            text01.Text = "404";
            text02.Text = "404";
        }
    }
}

