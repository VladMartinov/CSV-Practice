using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
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
    }
}