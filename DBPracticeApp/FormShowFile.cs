using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormShowFile : Form
    {
        public FormShowFile()
        {
            InitializeComponent();

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
    }
}