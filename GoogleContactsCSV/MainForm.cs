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

namespace GoogleContactsCSV
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.textBox_pathToTheFile.Text = @"C:\Users\sla\Downloads\contacts2.csv";
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            this.textBox_pathToTheFile.Text = ShowFileDialog();
        }

        private string ShowFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) return openFileDialog.FileName;
                return "";
            }
        }

        private void ShowSaveDialog(string[] outputCsv, int rowCount)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv file|*.csv";
            sfd.Title = "Save csv contacts file";
            sfd.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (sfd.FileName == "") return;

            try
            {
                File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                if(rowCount == 1)
                    MessageBox.Show("Contact saved succesully !!!", "Info");
                else
                    MessageBox.Show($@"{rowCount} contacts saved succesully !!!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.textBox_pathToTheFile.Text))
            { 
                MessageBox.Show("File not found."); 
                return; 
            }
            if (IsFileLocked(this.textBox_pathToTheFile.Text))
            {
                MessageBox.Show("File is in use.");
                return;
            }

            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(this.textBox_pathToTheFile.Text, Encoding.GetEncoding(28591));
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView_CSVcontent.DataSource = dt;
            }
        }

        protected virtual bool IsFileLocked(string filePath)
        {
            var file = new FileInfo(filePath);
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (dataGridView_CSVcontent.Rows.GetRowCount(DataGridViewElementStates.Selected) <= 0) 
            {
                MessageBox.Show("No selected contacts"); 
                return;
            }

            int columnCount = dataGridView_CSVcontent.Columns.Count;
            string columnNames = "";
            string[] outputCsv = new string[dataGridView_CSVcontent.SelectedRows.Count + 1];
            for (int i = 0; i < columnCount; i++)
            {
                columnNames += dataGridView_CSVcontent.Columns[i].HeaderText.ToString() + ",";
            }
            outputCsv[0] += columnNames;

            for (int i = 1; (i - 1) < dataGridView_CSVcontent.SelectedRows.Count; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (dataGridView_CSVcontent.Rows[i - 1].Cells[j].Value == null)
                        outputCsv[i] += ",";
                    else
                        outputCsv[i] += dataGridView_CSVcontent.SelectedRows[i - 1].Cells[j].Value.ToString() + ",";
                }
            }

            ShowSaveDialog(outputCsv, dataGridView_CSVcontent.SelectedRows.Count);
        }

        List<int> selectedRowIndexes = new List<int>();
        private void dataGridView_CSVcontent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_CSVcontent.CurrentCell == null) return;
            selectedRowIndexes.Add(dataGridView_CSVcontent.CurrentCell.RowIndex);
        }

        private void checkBox_selectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_selectAll.Checked)
            {
                checkBox_selectAll.Text = "Unselect all";
                dataGridView_CSVcontent.SelectAll();
            }
            else
            {
                checkBox_selectAll.Text = "Select all";
                dataGridView_CSVcontent.ClearSelection();
            }
        }
    }
}
