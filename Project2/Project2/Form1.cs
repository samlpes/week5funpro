namespace Project2



{
    using System.Collections.Generic;
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
            var A = textBox1.Text.Split(",; ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var B = new string[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[A.Length - 1 - i];
            }
            var message = "";
            for (int i = 0; i < A.Length; i++)
            {
                message += A[i] + " => " + B[i] + "\n";
            }
            MessageBox.Show(message);
        }
    }
}