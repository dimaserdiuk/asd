using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace labka_1._2
{
    public partial class Form1 : Form
    {
        
        double[,] arr = new double[3, 3];
        double[,] arr1 = new double[3, 3];
        
        
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|* txt|All files(*.*)|*.*";
            
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileway = openFileDialog1.FileName;
                string[] filetext = File.ReadAllLines(fileway).Take(10).ToArray();

                // разобрать в массив
                for (int i = 0; i < 3; i++)
                {
                    int[] row = filetext[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = row[j];
                    }
                }
                // вывести в текстбокс
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        richTextBox2.Text += arr[i, j].ToString() + "\t";
                    }

                    richTextBox2.Text += Environment.NewLine;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileway = openFileDialog1.FileName;
                string[] filetext = File.ReadAllLines(fileway).Take(10).ToArray();
                
                // разобрать в массив
                for (int i = 0; i < 3; i++)
                {
                    int[] row = filetext[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = row[j];
                    }
                }
                // вывести в текстбокс
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        richTextBox1.Text += arr[i, j].ToString() + "\t";
                    }

                    richTextBox1.Text += Environment.NewLine;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
