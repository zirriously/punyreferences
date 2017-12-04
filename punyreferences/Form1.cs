using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punyreferences
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

        private void InputCsProjButton_Click(object sender, EventArgs e)
        {
            CsProjFileDialog.ShowDialog();
            var referenceParser = new ReferenceParser();
            CsProjFileDialog.Multiselect = false;
            if (File.Exists(CsProjFileDialog.FileName) && CsProjFileDialog.FileName.Contains(".csproj"))
            {
                referenceParser.ParseReferences(CsProjFileDialog.FileName);
                InputCsProjTextBox.Text = CsProjFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Error - You did not pick a .csproj file");
            }
        }

        private void InputRootFolderButton_Click(object sender, EventArgs e)
        {
            RootFolderBrowserDialog.ShowDialog();

        }
    }
}
