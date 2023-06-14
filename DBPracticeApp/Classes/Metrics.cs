using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBPracticeApp.Classes
{
    class Metrics
    {
        #region -Values-
        private int lastCalledMetric;
        private List<string[]> headerFile;
        private List<string[]> dataFile;
        private string titleChart;
        #endregion

        #region -Get/Set-
        public List<string[]> HeaderFile
        {
            set { this.headerFile = value; }
        }
        public List<string[]> DataFile
        {
            set { this.dataFile = value; }
        }
        #endregion

        public Metrics(List<string[]> headerFile, List<string []> dataFile)
        {
            this.lastCalledMetric = -1;

            this.headerFile = headerFile;
            this.dataFile = dataFile;
        }

        public void ShowMetric(int metricNum)
        {
            this.lastCalledMetric = metricNum;

            switch (metricNum)
            {
                case 1:
                    {
                        List<(string, float)> resultData = DataMetrics1();
                        ShowFormMetrics(resultData);

                        break;
                    }
                case 2:
                    {
                        List<(string, float)> resultData = DataMetrics2();
                        ShowFormMetrics(resultData);
                        
                        break;
                    }
                case 3:
                    {
                        List<(string, float)> resultData = DataMetrics3();
                        ShowFormMetrics(resultData);

                        break;
                    }
                default:
                    {
                        MessageBox.Show("Фильтр не найден среди существующего списка!", "Ошибка!");
                        break;
                    }
            }
        }

        private void ShowFormMetrics(List<(string, float)> data)
        {
            FormMetrics formMetrics = new FormMetrics();
            formMetrics.LoadMetrics(data);
            formMetrics.SetTitle(this.titleChart);
            formMetrics.Show();
        }

        private List<(string, float)> DataMetrics1()
        {
            this.titleChart = this.headerFile[0][2];
            List<(string, float)> resultData = new List<(string, float)>();

            foreach (string[] value in this.dataFile)
                if (value[1] != "" && value[2] != "") resultData.Add( (value[1], float.Parse(value[2])) );
            
            return resultData;
        }

        private List<(string, float)> DataMetrics2()
        {
            this.titleChart = this.headerFile[0][4];
            List<(string, float)> resultData = new List<(string, float)>();

            foreach (string[] value in this.dataFile)
                if (value[1] != "" && value[4] != "") resultData.Add( (value[1], float.Parse(value[4])) );

            return resultData;
        }

        private List<(string, float)> DataMetrics3()
        {
            this.titleChart = this.headerFile[0][5];
            List<(string, float)> resultData = new List<(string, float)>();

            foreach (string[] value in this.dataFile)
                if (value[1] != "" && value[5] != "") resultData.Add( (value[1], float.Parse(value[5])) );

            return resultData;
        }
    }
}
