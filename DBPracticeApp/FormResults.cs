using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPracticeApp.Classes
{
    public partial class FormResults : Form
    {

        #region -Values-
        private List<string[]> contentData;

        private List<Label> labelValueList;
        #endregion

        public FormResults()
        {
            InitializeComponent();

            this.labelValueList = new List<Label>()
            {
                this.labelValue1, this.labelValue2, this.labelValue3, 
                this.labelValue4, this.labelValue5, this.labelValue6
            };
        }

        public void LoadDataToForm(List<string[]> contentData)
        {
            this.contentData = contentData;
        }

        public void LoadDataToView()
        {
            List<string> countrys = new List<string> { };
            List<string> regions = new List<string> { };
            float totalCars = 0;
            float totalNormCars = 0;
            float totalAddPollution = 0;
            float totalAvgollution = 0;

            for (int i = 0; i < this.contentData.Count; i++)
            {
                string[] countrysData = this.contentData[i][0].Split(',');
                foreach (string countryData in countrysData) { 
                    if (!countrys.Contains(countryData.Trim()))
                        countrys.Add(countryData.Trim());
                }

                if (!regions.Contains(contentData[i][1].Trim()))
                    regions.Add(contentData[i][1].Trim());

                totalCars += float.Parse(contentData[i][2]);
                totalNormCars += float.Parse(contentData[i][3]);
                totalAddPollution += float.Parse(contentData[i][4]);
                totalAvgollution += float.Parse(contentData[i][5]);
            }

            labelValueList[0].Text = string.Join(", ", countrys);
            labelValueList[1].Text = string.Join(", ", regions);
            labelValueList[2].Text = totalCars.ToString();
            labelValueList[3].Text = totalNormCars.ToString();
            labelValueList[4].Text = totalAddPollution.ToString();
            labelValueList[5].Text = totalAvgollution.ToString();
        }

    }
}
