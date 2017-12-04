namespace punyreferences
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputCsProjTextBox = new System.Windows.Forms.TextBox();
            this.InputCsProjButton = new System.Windows.Forms.Button();
            this.InputRootFolderButton = new System.Windows.Forms.Button();
            this.InputRootFolderTextBox = new System.Windows.Forms.TextBox();
            this.FoundReferencesListView = new System.Windows.Forms.ListView();
            this.ChangedReferencesListView = new System.Windows.Forms.ListView();
            this.PreviewChangesButton = new System.Windows.Forms.Button();
            this.CsProjFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RootFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputCsProjTextBox
            // 
            this.InputCsProjTextBox.Location = new System.Drawing.Point(12, 12);
            this.InputCsProjTextBox.Name = "InputCsProjTextBox";
            this.InputCsProjTextBox.ReadOnly = true;
            this.InputCsProjTextBox.Size = new System.Drawing.Size(479, 20);
            this.InputCsProjTextBox.TabIndex = 0;
            this.InputCsProjTextBox.Text = "Choose the .csproj file";
            // 
            // InputCsProjButton
            // 
            this.InputCsProjButton.BackColor = System.Drawing.Color.Transparent;
            this.InputCsProjButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputCsProjButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputCsProjButton.FlatAppearance.BorderSize = 0;
            this.InputCsProjButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputCsProjButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCsProjButton.Location = new System.Drawing.Point(491, 9);
            this.InputCsProjButton.Margin = new System.Windows.Forms.Padding(0);
            this.InputCsProjButton.Name = "InputCsProjButton";
            this.InputCsProjButton.Size = new System.Drawing.Size(27, 22);
            this.InputCsProjButton.TabIndex = 1;
            this.InputCsProjButton.Text = "...";
            this.InputCsProjButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InputCsProjButton.UseVisualStyleBackColor = false;
            this.InputCsProjButton.Click += new System.EventHandler(this.InputCsProjButton_Click);
            // 
            // InputRootFolderButton
            // 
            this.InputRootFolderButton.BackColor = System.Drawing.Color.Transparent;
            this.InputRootFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputRootFolderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InputRootFolderButton.FlatAppearance.BorderSize = 0;
            this.InputRootFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputRootFolderButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputRootFolderButton.Location = new System.Drawing.Point(491, 48);
            this.InputRootFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.InputRootFolderButton.Name = "InputRootFolderButton";
            this.InputRootFolderButton.Size = new System.Drawing.Size(27, 22);
            this.InputRootFolderButton.TabIndex = 3;
            this.InputRootFolderButton.Text = "...";
            this.InputRootFolderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InputRootFolderButton.UseVisualStyleBackColor = false;
            this.InputRootFolderButton.Click += new System.EventHandler(this.InputRootFolderButton_Click);
            // 
            // InputRootFolderTextBox
            // 
            this.InputRootFolderTextBox.Location = new System.Drawing.Point(12, 50);
            this.InputRootFolderTextBox.Name = "InputRootFolderTextBox";
            this.InputRootFolderTextBox.ReadOnly = true;
            this.InputRootFolderTextBox.Size = new System.Drawing.Size(479, 20);
            this.InputRootFolderTextBox.TabIndex = 2;
            this.InputRootFolderTextBox.Text = "Choose the root folder containing compiled .dll\'s";
            // 
            // FoundReferencesListView
            // 
            this.FoundReferencesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FoundReferencesListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FoundReferencesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.FoundReferencesListView.Location = new System.Drawing.Point(12, 87);
            this.FoundReferencesListView.MultiSelect = false;
            this.FoundReferencesListView.Name = "FoundReferencesListView";
            this.FoundReferencesListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FoundReferencesListView.Size = new System.Drawing.Size(300, 328);
            this.FoundReferencesListView.TabIndex = 4;
            this.FoundReferencesListView.UseCompatibleStateImageBehavior = false;
            this.FoundReferencesListView.View = System.Windows.Forms.View.Details;
            // 
            // ChangedReferencesListView
            // 
            this.ChangedReferencesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChangedReferencesListView.Location = new System.Drawing.Point(351, 87);
            this.ChangedReferencesListView.Name = "ChangedReferencesListView";
            this.ChangedReferencesListView.Size = new System.Drawing.Size(300, 328);
            this.ChangedReferencesListView.TabIndex = 4;
            this.ChangedReferencesListView.UseCompatibleStateImageBehavior = false;
            // 
            // PreviewChangesButton
            // 
            this.PreviewChangesButton.Location = new System.Drawing.Point(315, 237);
            this.PreviewChangesButton.Name = "PreviewChangesButton";
            this.PreviewChangesButton.Size = new System.Drawing.Size(33, 23);
            this.PreviewChangesButton.TabIndex = 5;
            this.PreviewChangesButton.Text = "->";
            this.PreviewChangesButton.UseVisualStyleBackColor = true;
            // 
            // CsProjFileDialog
            // 
            this.CsProjFileDialog.FileName = ".csproj file";
            // 
            // RootFolderBrowserDialog
            // 
            this.RootFolderBrowserDialog.SelectedPath = "Root folder";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(279, 421);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(90, 23);
            this.SaveChangesButton.TabIndex = 6;
            this.SaveChangesButton.Text = "Save changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 447);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.PreviewChangesButton);
            this.Controls.Add(this.ChangedReferencesListView);
            this.Controls.Add(this.FoundReferencesListView);
            this.Controls.Add(this.InputRootFolderButton);
            this.Controls.Add(this.InputRootFolderTextBox);
            this.Controls.Add(this.InputCsProjButton);
            this.Controls.Add(this.InputCsProjTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCsProjTextBox;
        private System.Windows.Forms.Button InputCsProjButton;
        private System.Windows.Forms.Button InputRootFolderButton;
        private System.Windows.Forms.TextBox InputRootFolderTextBox;
        private System.Windows.Forms.ListView FoundReferencesListView;
        private System.Windows.Forms.ListView ChangedReferencesListView;
        private System.Windows.Forms.Button PreviewChangesButton;
        private System.Windows.Forms.OpenFileDialog CsProjFileDialog;
        private System.Windows.Forms.FolderBrowserDialog RootFolderBrowserDialog;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}

