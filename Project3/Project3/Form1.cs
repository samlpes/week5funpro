using System;
using System.Collections.Generic;
using System.Linq;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list1 = new string[5]{"a", "e", "i", "o", "u"};
            var noOfSpaces = 0;
            foreach (char c in textBox1.Text)
            {
                if (c => list1.Contains(c))
                    noOfSpaces++;
            }
            MessageBox.Show(noOfSpaces.ToString());
        }
    }
}