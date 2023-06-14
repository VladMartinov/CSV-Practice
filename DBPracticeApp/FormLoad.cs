using System;
using System.Windows.Forms;

namespace DBPracticeApp
{
    public partial class FormLoad : Form
    {

        #region -Values-
        OpenFileDialog openFileDialog;

        private string selectedFile = "";
        #endregion

        public FormLoad()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "CSV files(*.csv)|*.csv|All files(*.*)|*.*";
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            selectedFile = openFileDialog.FileName;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        public string SelectedFile
        {
            get
            {
                return this.selectedFile;
            }
        }
    }
}
