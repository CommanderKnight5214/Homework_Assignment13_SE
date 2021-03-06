using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestApp
{
    
    
    public partial class Form1 : Form
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Create a string array with the lines of text
                string[] lines = { "First line", "Second line", "Third line" };
                // Set a variable to the Documents path.
                string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new
               StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
           ;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

        }
    }
}
