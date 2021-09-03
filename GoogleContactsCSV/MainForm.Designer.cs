
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_filePath = new System.Windows.Forms.Label();
            this.textBox_pathToTheFile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.button_read = new System.Windows.Forms.Button();
            this.dataGridView_CSVcontent = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label_separator = new System.Windows.Forms.Label();
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
            this.toolTip2.SetToolTip(this.button_browse, "Open filedialog to browse csv file to open.");
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(486, 8);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 2;
            this.button_read.Text = "Read";
            this.toolTip2.SetToolTip(this.button_read, "When csv file selected, read the file content");
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // dataGridView_CSVcontent
            // 
            this.dataGridView_CSVcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CSVcontent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CSVcontent.Location = new System.Drawing.Point(13, 68);
            this.dataGridView_CSVcontent.Name = "dataGridView_CSVcontent";
            this.dataGridView_CSVcontent.RowHeadersVisible = false;
            this.dataGridView_CSVcontent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CSVcontent.Size = new System.Drawing.Size(775, 370);
            this.dataGridView_CSVcontent.TabIndex = 3;
            this.dataGridView_CSVcontent.SelectionChanged += new System.EventHandler(this.dataGridView_CSVcontent_SelectionChanged);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Location = new System.Drawing.Point(708, 37);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(80, 25);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Save";
            this.toolTip2.SetToolTip(this.button_save, "Open filedialog to save selected contacts");
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.Location = new System.Drawing.Point(13, 39);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(58, 23);
            this.checkBox_selectAll.TabIndex = 5;
            this.checkBox_selectAll.Text = "select all";
            this.toolTip2.SetToolTip(this.checkBox_selectAll, "Select or unselect all rows");
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckedChanged += new System.EventHandler(this.checkBox_selectAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Read the CSV-file that contains all contacts, modify and select all you wanna imp" +
    "ort to Google. Finally click Save.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(735, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "";
            this.toolTip1.SetToolTip(this.label2, "May contain a lot of bugs and errors and misfunctioning!");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Warning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label_separator
            // 
            this.label_separator.AutoSize = true;
            this.label_separator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_separator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_separator.Location = new System.Drawing.Point(452, 11);
            this.label_separator.Name = "label_separator";
            this.label_separator.Size = new System.Drawing.Size(13, 18);
            this.label_separator.TabIndex = 9;
            this.label_separator.Text = ";";
            this.label_separator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip2.SetToolTip(this.label_separator, "Separator character");
            this.label_separator.Click += new System.EventHandler(this.label_separator_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_separator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_selectAll);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView_CSVcontent);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_pathToTheFile);
            this.Controls.Add(this.label_filePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_separator;
    }
}

