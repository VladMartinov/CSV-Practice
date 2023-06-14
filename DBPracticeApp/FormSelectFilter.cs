using System;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormSelectFilter : Form
    {
        #region -Values-
        private int selectedFilter = 0;
        #endregion

        #region -Get/Set-
        public int SelectedFilter
        {
            get { return selectedFilter; }
        }
        #endregion

        public FormSelectFilter()
        {
            InitializeComponent();
        }

        private void buttonFilter1_Click(object sender, EventArgs e)
        {
            selectFilter(1);
        }

        private void buttonFilter2_Click(object sender, EventArgs e)
        {
            selectFilter(2);
        }

        private void buttonFilter3_Click(object sender, EventArgs e)
        {
            selectFilter(3);
        }

        private void selectFilter(int numFilter)
        {
            this.DialogResult = DialogResult.OK;

            this.selectedFilter = numFilter;

            this.Close();

        }
    }
}