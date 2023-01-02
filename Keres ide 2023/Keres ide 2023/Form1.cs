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
using System.Diagnostics;

namespace Keres_ide_2023
{
    public partial class Form1 : Form
    {

        public FastColoredTextBoxNS.Style Red = new FastColoredTextBoxNS.TextStyle(Brushes.Red, null, FontStyle.Italic);
        public FastColoredTextBoxNS.Style blue = new FastColoredTextBoxNS.TextStyle(Brushes.Blue, null, FontStyle.Bold);
        public FastColoredTextBoxNS.Style Yellow = new FastColoredTextBoxNS.TextStyle(Brushes.Yellow, null, FontStyle.Bold);
        public FastColoredTextBoxNS.Style green = new FastColoredTextBoxNS.TextStyle(Brushes.Green, null, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Keres file(*.keres)|*.keres";
            autocompleteMenu1.Items = File.ReadAllLines("keres.dicr");
        }

        private void standardCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Console\nprint\nver\ninfo\nUpdate\nPanel{}");
        }

        private void colorCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("color\nText\nRed\nBlue\nGreen\nStandard");
        }

        private void loadTestCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mode = new Form2();
            mode.ShowDialog();
        }

        private void loadColorCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 mode = new Form3();
            mode.ShowDialog();
        }

        private void loadUpdateCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 mode = new Form4();
            mode.ShowDialog();
        }

        private void createKeresWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mode = new Form1();
            mode.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filname = saveFileDialog1.FileName;
            File.WriteAllText(filname, fastColoredTextBox1.Text);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filname = openFileDialog1.FileName;
            string filText = File.ReadAllText(filname);
            fastColoredTextBox1.Text = filText; 
        }

        private void createTxtWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 mode = new Form5();
            mode.ShowDialog();
        }

        private void runProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"c\compilator.exe");
        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            e.ChangedRange.ClearFoldingMarkers();
            e.ChangedRange.SetFoldingMarkers("Panel{", "}");

            e.ChangedRange.SetStyle(Red, "Console");
            e.ChangedRange.SetStyle(Red, "print");


            e.ChangedRange.SetStyle(Yellow, "1");
            e.ChangedRange.SetStyle(Yellow, "2");
            e.ChangedRange.SetStyle(Yellow, "3");
            e.ChangedRange.SetStyle(Yellow, "4");
            e.ChangedRange.SetStyle(Yellow, "5");
            e.ChangedRange.SetStyle(Yellow, "6");
            e.ChangedRange.SetStyle(Yellow, "7");
            e.ChangedRange.SetStyle(Yellow, "8");
            e.ChangedRange.SetStyle(Yellow, "9");
            e.ChangedRange.SetStyle(Yellow, "0");

            e.ChangedRange.SetStyle(blue, "Update");
            e.ChangedRange.SetStyle(blue, "Panel");
            e.ChangedRange.SetStyle(blue, "Using");
            e.ChangedRange.SetStyle(blue, "color");

            e.ChangedRange.SetStyle(green, "Color");
            
        }
    }
}
