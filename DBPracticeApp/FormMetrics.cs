using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
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

        /* Print Metrics */

        private void buttonMetricsPrint_Click(object sender, System.EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.chartMetrics.Width, this.chartMetrics.Height, this.chartMetrics.CreateGraphics());
            this.chartMetrics.DrawToBitmap(bitmap, new Rectangle(0, 0, this.chartMetrics.Width, this.chartMetrics.Height));

            float x = e.PageSettings.PrintableArea.X + (e.PageSettings.PrintableArea.Width - bitmap.Width) / 2;
            float y = e.PageSettings.PrintableArea.Y + (e.PageSettings.PrintableArea.Height - bitmap.Height) / 2;

            e.Graphics.DrawImage(bitmap, x, y);
        }
    }
}
