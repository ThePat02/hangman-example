using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            l.Show();
            l.Visible = false;
            l.LogText = "hangman-example";
            l.LogText = "by Pat | View documentation on GitHub";
            l.LogText = "";

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                toggleLog();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public Log l = new Log();

        private bool log = false;

        private void toggleLog()
        {
            switch (log)
            {

                case true:
                    l.Visible = false;
                    log = false;
                    break;


                case false:
                    l.Visible = true;
                    log = true;
                    break;
            }
        }

        private string getLength()
        {
            int length = m_word.Length;
            m_length = length;

            l.LogText = "The word is " + length + " characters long";

            string a = "";

            for (int i = 0; i < length; i++)
            {
                a = a + "?";afsddfafdssdf
            }

            return a;
        }




        private void gameStart()
        {
            l.LogText = "Preparing...";
            newWord();
            l.LogText = "Finished generating data";
            l.LogText = "Data: " + m_word + " | " + m_desc;
            l.LogText = "";

            m_btn_start.Enabled = false;

            m_text_hangman.Text = getLength();
            l.LogText = "Finished generating text";
            l.LogText = "";

            m_box.Enabled = true;
            this.ActiveControl = m_box;
            l.LogText = "Prepared for input";
            l.LogText = "";



        }

        private string m_word;
        private string m_desc;
        private int m_length;

        private int health = 10;

        private void newWord()
        {
            Cls_word w = new Cls_word();
            w.newWord();
            l.LogText = "Generated new word from .csv file";

            m_word = w.getWord();
            l.LogText = "Saved word";

            m_desc = w.getDesc();
            l.LogText = "Saved desc";


        }

        

        private void updateMan()
        {

            Image img = null;
            int place;

            if (health == 10) place = 0;
            else if (health == 9) img = Properties.Resources._9;
            else if (health == 8) img = Properties.Resources._8;
            else if (health == 7) img = Properties.Resources._7;
            else if (health == 6) img = Properties.Resources._6;
            else if (health == 5) img = Properties.Resources._5;
            else if (health == 4) img = Properties.Resources._4;
            else if (health == 3) img = Properties.Resources._3;
            else if (health == 2) img = Properties.Resources._2;
            else if (health == 1) img = Properties.Resources._1;
            else if (health == 0) img = Properties.Resources._0;

            m_picturebox.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleLog();
        }

        private void m_btn_start_Click(object sender, EventArgs e)
        {
            gameStart();

        }

        private void m_box_TextChanged(object sender, EventArgs e)
        {
            if (m_box.Text != null && m_box.Text != " ")
            {
                m_box.Enabled = false;
                l.LogText = "Detected input";
                l.LogText = "";

                string input = m_box.Text;

                bool containsLetter = Regex.IsMatch(m_word, "[" + input + "]");

                if (containsLetter == true)
                {
                    l.LogText = "Letter is in the word";

                    int pos = m_word.IndexOf(input);
                }
                else
                {
                    l.LogText = "Letter is not in the word";

                    health = health - 1;
                    l.LogText = "Health - 1 = " + health;
                }

                updateMan();

                l.LogText = "";
            }
        }
    }
}
