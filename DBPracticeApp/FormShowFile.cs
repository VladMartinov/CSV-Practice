using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormShowFile : Form
    {
        #region -Values-
        private FormMain formMain;
        private bool isMainFormCreate = false;
        private List<string[]> contentData;
        private int currentPage = 0;
        #endregion

        public FormShowFile()
        {
            InitializeComponent();

            this.buttonSortModifFile.Enabled = false;
            this.buttonCreateNewFile.Enabled = false;
        }

        public FormShowFile(FormMain formMain)
        {
            InitializeComponent();

            this.buttonSortModifFile.Enabled = false;
            this.buttonCreateNewFile.Enabled = false;

            this.formMain = formMain;
            this.isMainFormCreate = true;
        }

        public void LoadDataToTable(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath, Encoding.Default))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    dataGridViewRegion.Rows.Add(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
                }
            }
        }
        public void LoadDataToTable(List<string[]> data)
        {
            this.dataGridViewRegion.Rows.Clear();

            this.contentData = data;

            foreach (string[] field in data)
                dataGridViewRegion.Rows.Add(field[0], field[1], field[2], field[3], field[4], field[5]);
        }

        public void SetTitleText(string newTitle)
        {
            this.labelRegion.Text = newTitle;
        }

        public void SetTitleForm(string newTitle)
        {
            this.Text = newTitle;
        }

        /* Work with file */

        private void buttonSortModifFile_Click(object sender, System.EventArgs e)
        {
            if (!isMainFormCreate)
            {
                MessageBox.Show("Данные не были переданы!", "Ошибка!");
                return;
            }

            this.formMain.SortModifFile(this.contentData);
            MessageBox.Show("Рабочий файл успешно отфильтрован!", "Уведомление.");

            return;
        }

        private void buttonCreateNewFile_Click(object sender, System.EventArgs e)
        {
            if (!isMainFormCreate)
            {
                MessageBox.Show("Данные не были переданы!", "Ошибка!");
                return;
            }

            this.formMain.CreateFilteredFile("filtered", this.contentData);
            MessageBox.Show("Новый отфильтрованный файл успешно создан!", "Уведомление.");

            return;
        }

        public void EnableTheButtons()
        {
            this.buttonSortModifFile.Enabled = true;
            this.buttonCreateNewFile.Enabled = true;
        }

        /* Print current Table */

        private void buttonPrintTable_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int pageWidth = e.PageSettings.PaperSize.Width - e.PageSettings.Margins.Left - e.PageSettings.Margins.Right;
            int pageHeight = e.PageSettings.PaperSize.Height - e.PageSettings.Margins.Top - e.PageSettings.Margins.Bottom;
            
            int tableWidth = dataGridViewRegion.ColumnCount * dataGridViewRegion.Columns[0].Width;
            int tableHeight = dataGridViewRegion.RowCount * dataGridViewRegion.Rows[0].Height;
            
            if (tableWidth > pageWidth)
            {
                float scale = (float)pageWidth / tableWidth;
                tableWidth = pageWidth;
                tableHeight = (int)(tableHeight * scale);
            }
            if (tableHeight > pageHeight)
            {
                float scale = (float)pageHeight / tableHeight;
                tableHeight = pageHeight;
                tableWidth = (int)(tableWidth * scale);
            }
            
            int headerX = e.MarginBounds.Left;
            int headerY = e.MarginBounds.Top;
            
            float headerHeight = 0;
            
            for (int col = 0; col < dataGridViewRegion.ColumnCount; col++)
            {
                DataGridViewCell headerCell = dataGridViewRegion.Columns[col].HeaderCell;
                if (headerCell.Value != null)
                {
                    string text = headerCell.Value.ToString();
                    float maxWidth = dataGridViewRegion.Columns[col].Width;
                    float lineHeight = dataGridViewRegion.Rows[0].Height;
            
                    float x = headerX;
                    float y = headerY;
                    
                    string[] lines = text.Split('\n');
                    foreach (string line in lines)
                    {
                        if (e.Graphics.MeasureString(line, dataGridViewRegion.Font).Width > maxWidth)
                        {
                            string[] words = line.Split(' ');
                            string currentLine = "";
                    
                            foreach (string word in words)
                            {
                                if (e.Graphics.MeasureString(currentLine + word, dataGridViewRegion.Font).Width > maxWidth)
                                {
                                    e.Graphics.DrawString(currentLine, dataGridViewRegion.Font, Brushes.Black, x, y);
                                    y += lineHeight;
                                    currentLine = "";
                                }
                                currentLine += word + " ";
                            }
                            e.Graphics.DrawString(currentLine, dataGridViewRegion.Font, Brushes.Black, x, y);
                            y += lineHeight;
                        }
                        else
                        {
                            e.Graphics.DrawString(line, dataGridViewRegion.Font, Brushes.Black, x, y);
                            y += lineHeight;
                        }
                    }
                    headerHeight = Math.Max(headerHeight, y - headerY);
                }
                headerX += dataGridViewRegion.Columns[col].Width;
            }

            int dataX = e.MarginBounds.Left;
            int dataY = headerY + (int)headerHeight + dataGridViewRegion.Rows[0].Height;
            
            for (int row = 0; row < dataGridViewRegion.RowCount; row++)
            {
                for (int col = 0; col < dataGridViewRegion.ColumnCount; col++)
                {
                    DataGridViewCell cell = dataGridViewRegion.Rows[row].Cells[col];
                    if (cell.Value != null)
                        e.Graphics.DrawString(cell.Value.ToString(), dataGridViewRegion.Font, Brushes.Black, dataX, dataY);
            
                    dataX += dataGridViewRegion.Columns[col].Width;
                }

                dataX = e.MarginBounds.Left;
                dataY += dataGridViewRegion.Rows[0].Height;
            }
        }
    }
}