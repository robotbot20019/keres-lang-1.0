using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Keres_ide_2023
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Txt file(*.txt)|*.txt";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filname = saveFileDialog1.FileName;
            File.WriteAllText(filname, richTextBox1.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filname = openFileDialog1.FileName;
            string filText = File.ReadAllText(filname);
            richTextBox1.Text = filText;
        }
    }
}
