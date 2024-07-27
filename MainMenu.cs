﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleFunProjects
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.ShowDialog();
        }
    }
}
