using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hangman_example
{
    class Cls_word
    {
        /* Eigenschaften der Klasse Cls_word */
        private string m_word;
        private string m_desc;

        /* Konstruktor der Klasse Cls_word */


        public Cls_word()
        {

        }

        public void newWord()
        {
            string[] allLines = File.ReadAllLines("data.csv");
            Random rnd1 = new Random();
            string[] csv = allLines[rnd1.Next(allLines.Length)].Split(';');

            m_word = csv[0];
            m_desc = csv[1];
        }

        public string getWord()
        {
            return m_word;
        }

        public string getDesc()
        {
            return m_desc;
        }


    }
}
