﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public Log l = new Log();

        private bool log = false;

        private void toggleLog()
        {
            
            switch (log)
            {

                case true:
                    l.Close();
                    log = false;

                    break;


                case false:
                    l.Show();
                    log = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleLog();
        }
    }
}