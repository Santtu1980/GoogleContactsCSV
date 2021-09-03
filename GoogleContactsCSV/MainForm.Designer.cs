
namespace GoogleContactsCSV
{
    partial class MainForm
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
            this.label_filePath = new System.Windows.Forms.Label();
            this.textBox_pathToTheFile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.dataGridView_CSVcontent = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSVcontent)).BeginInit();
            this.SuspendLayout();
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.Location = new System.Drawing.Point(13, 13);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(75, 13);
            this.label_filePath.TabIndex = 0;
            this.label_filePath.Text = "Path to the file";
            // 
            // textBox_pathToTheFile
            // 
            this.textBox_pathToTheFile.Location = new System.Drawing.Point(94, 10);
            this.textBox_pathToTheFile.Name = "textBox_pathToTheFile";
            this.textBox_pathToTheFile.Size = new System.Drawing.Size(253, 20);
            this.textBox_pathToTheFile.TabIndex = 1;
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(353, 8);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 2;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(434, 8);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 2;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // dataGridView_CSVcontent
            // 
            this.dataGridView_CSVcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CSVcontent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CSVcontent.Location = new System.Drawing.Point(13, 47);
            this.dataGridView_CSVcontent.Name = "dataGridView_CSVcontent";
            this.dataGridView_CSVcontent.RowHeadersVisible = false;
            this.dataGridView_CSVcontent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CSVcontent.Size = new System.Drawing.Size(775, 391);
            this.dataGridView_CSVcontent.TabIndex = 3;
            this.dataGridView_CSVcontent.SelectionChanged += new System.EventHandler(this.dataGridView_CSVcontent_SelectionChanged);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(708, 6);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 25);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(578, 8);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(58, 23);
            this.checkBox_selectAll.TabIndex = 5;
            this.checkBox_selectAll.Text = "select all";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_selectAll);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView_CSVcontent);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_pathToTheFile);
            this.Controls.Add(this.label_filePath);
            this.Name = "MainForm";
            this.Text = "Google Contacts CSV editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CSVcontent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_filePath;
        private System.Windows.Forms.TextBox textBox_pathToTheFile;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.DataGridView dataGridView_CSVcontent;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
    }
}

