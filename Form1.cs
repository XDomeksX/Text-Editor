using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                RTB.Text = text;
            }
        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"D:\Visual Studio\C#\Text Editor\mojaDatoteka.txt", RTB.Text);
        }

        private void BTNnew_Click(object sender, EventArgs e)
        {
            File.Create("mojaNovaDatoteka.txt");
        }
    }
}
