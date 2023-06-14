using System.Collections.Generic;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormMetrics : Form
    {
        public FormMetrics()
        {
            InitializeComponent();
        }

        public void LoadMetrics(List<(string, float)> dataMetrics)
        {
            this.chartMetrics.Series[0].Points.Clear();

            int index = 0;
            foreach(var value in dataMetrics)
            {
                this.chartMetrics.Series[0].Points.Add(value.Item2);
                this.chartMetrics.Series[0].Points[index].LegendText = value.Item1 + " = " + value.Item2.ToString();

                index++;
            }
        }

        public void SetTitle(string title)
        {
            this.labelRegion.Text = title;
        }
    }
}
