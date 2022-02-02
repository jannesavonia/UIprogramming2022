using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string filename = textboxFileName.Text;
            string firstLine = System.IO.File.ReadLines(filename).First();

            labelFirstLine.Text = firstLine;

            var fileContent = System.IO.File.ReadLines(filename);
            foreach(var row in fileContent)
            {
                textboxFileContent.AppendText(row);
            }
        }

        private void textboxFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
