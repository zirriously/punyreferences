﻿using System;
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
            ColumnHeader header1 = new ColumnHeader();
            header1.Text = String.Empty;
            header1.Name = "column1";
            FoundReferencesListView.Columns.Add(header1);
            FoundReferencesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            ColumnHeader header2 = new ColumnHeader();
            header2.Text = String.Empty;
            header2.Name = "column2";
            ChangedReferencesListView.Columns.Add(header2);
            ChangedReferencesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void InputCsProjButton_Click(object sender, EventArgs e)
        {
            CsProjFileDialog.ShowDialog();
            ReferenceParser referenceParser = new ReferenceParser();
            CsProjFileDialog.Multiselect = false;
            if (File.Exists(CsProjFileDialog.FileName) && CsProjFileDialog.FileName.Contains(".csproj"))
            {
                referenceParser.ParseReferences(CsProjFileDialog.FileName);
                InputCsProjTextBox.Text = CsProjFileDialog.FileName;
                referenceParser.BeautifyList();
                foreach (string value in referenceParser.BeautifiedList)
                {
                    FoundReferencesListView.Items.Add(value);
                }
            }
            else
            {
                MessageBox.Show("Error - You did not pick a .csproj file");
            }
        }

        private string _folderPath;

        private void InputRootFolderButton_Click(object sender, EventArgs e)
        {
            RootFolderBrowserDialog.ShowDialog();
            if (Directory.Exists(RootFolderBrowserDialog.SelectedPath))
            {
                DLLParser dllParser = new DLLParser();
                _folderPath = RootFolderBrowserDialog.SelectedPath;
                InputRootFolderTextBox.Text = _folderPath;
                dllParser.ParseFiles(_folderPath);
                dllParser.BeautifyList();
                foreach (string value in dllParser.BeautifiedList)
                {
                    ChangedReferencesListView.Items.Add(value);
                }
            }
            else
            {
                MessageBox.Show("Error - You did not pick a folder");
            }
        }
    }
}
