using System.Collections.Generic;
using System.Windows.Forms;

namespace DBPracticeApp.Classes
{
    class Filters
    {
        #region -Values-
        private int lastCalledFilter;
        private List<string[]> data;
        private DataGridView dataGrid;
        #endregion

        public Filters(DataGridView dataGridView) { 
            this.lastCalledFilter = -1;
            this.dataGrid = dataGridView;
            this.data = new List<string[]>();
        }

        public List<string[]> CallFilter(int filterNum)
        {
            this.data.Clear();
            this.lastCalledFilter = filterNum;

            switch (filterNum)
            {
                case 1:
                    {
                        this.data = DataFilter1();
                        break;
                    }
                case 2:
                    {
                        this.data = DataFilter2();
                        break;
                    }
                case 3:
                    {
                        this.data = DataFilter3();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Фильтр не найден среди существующего списка!", "Ошибка!");
                        break;
                    }
            }

            return this.data;
        }

        private List<string[]> DataFilter1()
        {
            float maxCar = 0;
            List<string[]> data = new List<string[]>();
            List<string> rowValues = new List<string>();

            foreach (DataGridViewRow row in this.dataGrid.Rows)
            {
                if (row.Index == this.dataGrid.Rows.Count - 1) break;

                if (float.Parse(row.Cells[2].Value.ToString()) > maxCar)
                {
                    maxCar = float.Parse(row.Cells[2].Value.ToString());

                    data.Clear();
                    rowValues.Clear();

                    foreach (DataGridViewCell cell in row.Cells)
                        rowValues.Add(cell.Value.ToString());

                    data.Add(rowValues.ToArray());
                }
            }

            return data;
        }

        private List<string[]> DataFilter2(float avgEmissions = 60)
        {
            List<string[]> data = new List<string[]>();
            List<string> rowValues = new List<string>();

            foreach (DataGridViewRow row in this.dataGrid.Rows)
            {
                if (row.Index == this.dataGrid.Rows.Count - 1) break;

                if (float.Parse(row.Cells[5].Value.ToString()) > avgEmissions)
                {
                    rowValues.Clear();

                    foreach (DataGridViewCell cell in row.Cells)
                        rowValues.Add(cell.Value.ToString());

                    data.Add(rowValues.ToArray());
                }
            }

            return data;
        }

        private List<string[]> DataFilter3(float countCar = 55, float avgEmissions = 50)
        {
            List<string[]> data = new List<string[]>();
            List<string> rowValues = new List<string>();

            foreach (DataGridViewRow row in this.dataGrid.Rows)
            {
                if (row.Index == this.dataGrid.Rows.Count - 1) break;

                if (float.Parse(row.Cells[2].Value.ToString()) > countCar && float.Parse(row.Cells[5].Value.ToString()) > avgEmissions)
                {
                    rowValues.Clear();

                    foreach (DataGridViewCell cell in row.Cells)
                        rowValues.Add(cell.Value.ToString());

                    data.Add(rowValues.ToArray());
                }
            }

            return data;
        }
    }
}
