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
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        public string LogText
        {
            set { m_logbox.AppendText(Environment.NewLine + value); }
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public void logText(string msg)
        {
            m_logbox.AppendText(Environment.NewLine + msg);
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void m_logbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
