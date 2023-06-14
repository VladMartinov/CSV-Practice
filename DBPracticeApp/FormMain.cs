using DBPracticeApp.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormMain : Form
    {
        #region -Values-
        private OpenFileDialog openFileDialog;

        private FormLoad formLoad;
        private Filters filters;
        private FileWorkers fileWorkers;
        private Metrics metrics;
        #endregion

        public FormMain()
        {
            InitializeComponent();

            this.openFileDialog = new OpenFileDialog();
            this.openFileDialog.InitialDirectory = "c:\\";
            this.openFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";

            this.filters = new Filters(this.dataGridViewRegion);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.formLoad = new FormLoad();

            if (this.formLoad.ShowDialog(this) != DialogResult.OK)
                Application.Exit();

            this.fileWorkers = new FileWorkers(this.formLoad.SelectedFile);
            LoadDataToView(this.fileWorkers.DataFile);

            this.metrics = new Metrics(this.fileWorkers.HeaderFile, this.fileWorkers.DataFile);
        }

        /* ToolStip Menu */

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'CSV Practice' предназначена для работы с фалом формата '.csv' по варианту №17.", "Информация");
        }

        private void загрузитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.fileWorkers.InputFilePath = openFileDialog.FileName;
            this.fileWorkers.LoadNewFile();

            LoadDataToView(this.fileWorkers.DataFile);
        }

        /* Table "Region" functions */

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegion.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewRegion.SelectedRows[0].Index;

            if (dataGridViewRegion.Rows[index].Cells[0].Value == null ||
                dataGridViewRegion.Rows[index].Cells[1].Value == null ||
                dataGridViewRegion.Rows[index].Cells[2].Value == null ||
                dataGridViewRegion.Rows[index].Cells[3].Value == null ||
                dataGridViewRegion.Rows[index].Cells[4].Value == null ||
                dataGridViewRegion.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string[] dataAdd = {
                dataGridViewRegion.Rows[index].Cells[0].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[1].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[2].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[3].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[4].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[5].Value.ToString()
            };

            this.fileWorkers.AddToFile(dataAdd);
            MessageBox.Show("Данные успешно добавлены!", "Оповещение.");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну строку!", "Внимание!");
                return;
            }


            List<int> indexes = new List<int>();

            for (int i = dataGridViewRegion.SelectedRows.Count - 1; i >= 0; i--)
            {
                int selectedIndex = dataGridViewRegion.SelectedRows[i].Index;
                indexes.Add(selectedIndex);

                dataGridViewRegion.Rows.RemoveAt(selectedIndex);
            }

            this.fileWorkers.RemoveAtFile(indexes);
            MessageBox.Show("Данные успешно удалены!", "Оповещение.");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegion.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewRegion.SelectedRows[0].Index;

            if (dataGridViewRegion.Rows[index].Cells[0].Value == null ||
                dataGridViewRegion.Rows[index].Cells[1].Value == null ||
                dataGridViewRegion.Rows[index].Cells[2].Value == null ||
                dataGridViewRegion.Rows[index].Cells[3].Value == null ||
                dataGridViewRegion.Rows[index].Cells[4].Value == null ||
                dataGridViewRegion.Rows[index].Cells[5].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string[] dataUpdate = {
                dataGridViewRegion.Rows[index].Cells[0].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[1].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[2].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[3].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[4].Value.ToString(),
                dataGridViewRegion.Rows[index].Cells[5].Value.ToString(),
            };

            this.fileWorkers.UpdateLineInFile(dataUpdate, index);
            MessageBox.Show("Данные успешно обновлены!", "Оповещение.");
        }


        private void buttonFilters_Click(object sender, EventArgs e)
        {
            FormSelectFilter selectFilter = new FormSelectFilter();
            if (selectFilter.ShowDialog(this) != DialogResult.OK)
            {
                MessageBox.Show("Фильтр не был выбран!", "Уведомление.");
                return;
            }

            int selectedFilter = selectFilter.SelectedFilter;

            if (selectedFilter == 0)
            {
                MessageBox.Show("Указан не существующий фильтр!", "Ошибка!");
                return;
            }

            List<string[]> data = filters.CallFilter(selectedFilter);


            if (data.Count == 0)
            {
                MessageBox.Show("Результат фильтра пуст!", "Оповещение.");
                return;
            }

            ShowDataInWindow(data, "Результат запроса");
        }

        private void buttonSortTheFile_Click(object sender, EventArgs e)
        {
            List<string[]> dataFromTable = new List<string[]> { };
            List<string> rowValues = new List<string> { };

            foreach (DataGridViewRow row in dataGridViewRegion.Rows)
            {
                if (row.Index == dataGridViewRegion.Rows.Count - 1) break;

                foreach (DataGridViewCell cell in row.Cells)
                    rowValues.Add(cell.Value.ToString());

                dataFromTable.Add(rowValues.ToArray());
                rowValues.Clear();
            }

            this.fileWorkers.DataFile = dataFromTable;
            this.fileWorkers.UpdateTheFile();

            MessageBox.Show("Файл успешно отсортирован!", "Уведомление.");
        }

        /* Buttin Metrics */

        private void SetLastDataToMetrics()
        {
            this.metrics.HeaderFile = this.fileWorkers.HeaderFile;
            this.metrics.DataFile = this.fileWorkers.DataFile;
        }

        private void buttonMetrics1_Click(object sender, EventArgs e)
        {
            SetLastDataToMetrics();   
            this.metrics.ShowMetric(1);
        }

        private void buttonMetrics2_Click(object sender, EventArgs e)
        {
            SetLastDataToMetrics();
            this.metrics.ShowMetric(2);
        }

        private void buttonMetrics3_Click(object sender, EventArgs e)
        {
            SetLastDataToMetrics();
            this.metrics.ShowMetric(3);
        }

        /* Additional functions */

        private void LoadDataToView(List<string[]> data)
        {
            ClearView();

            foreach (string[] dataLine in data)
                dataGridViewRegion.Rows.Add(dataLine);
        }

        private void ClearView()
        {
            dataGridViewRegion.Rows.Clear();
        }

        private void buttonShowInputFile_Click(object sender, EventArgs e)
        {
            ShowDataInWindow(this.fileWorkers.InputFilePath, "Начальная таблица \"Регион\"");
        }

        private void buttonShowModifFile_Click(object sender, EventArgs e)
        {
            ShowDataInWindow(this.fileWorkers.ModifFilePath, "Модифицированная таблица \"Регион\"");
        }

        private void ShowDataInWindow(List<string[]> data, string title)
        {
            FormShowFile formShowModifFile = new FormShowFile();
            formShowModifFile.LoadDataToTable(data);
            formShowModifFile.SetTitleText(title);
            formShowModifFile.Show();
        }
        private void ShowDataInWindow(string filPath, string title)
        {
            FormShowFile formShowModifFile = new FormShowFile();
            formShowModifFile.LoadDataToTable(filPath);
            formShowModifFile.SetTitleText(title);
            formShowModifFile.Show();
        }
    }
}