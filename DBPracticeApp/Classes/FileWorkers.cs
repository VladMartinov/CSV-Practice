using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace DBPracticeApp.Classes
{
    class FileWorkers
    {
        #region -Values-
        private string inputFilePath;
        private string modifFilePath;

        private List<string[]> headerFile;
        private List<string[]> dataFile;

        private Encoding fileEncoding;
        #endregion

        #region -Get/Set-
        public string InputFilePath
        {
            get { return this.inputFilePath; } set { this.inputFilePath = value; }
        }
        public string ModifFilePath
        {
            get { return this.modifFilePath; } set { this.modifFilePath = value; }
        }
        public List<string[]> HeaderFile
        {
            get { return this.headerFile; } set { this.headerFile = value; }
        } 
        public List<string[]> DataFile
        {
            get { return this.dataFile; } set { this.dataFile = value; } 
        }
        #endregion

        public FileWorkers(string inputFilePath)
        {
            this.inputFilePath = inputFilePath;
            this.modifFilePath = createNewPath(this.inputFilePath);

            this.fileEncoding = Encoding.Default;

            this.headerFile = new List<string[]>();
            this.dataFile = new List<string[]>();

            LoadDataFromFile(this.inputFilePath);
            CreateNewFile(this.modifFilePath, this.headerFile, this.dataFile);
        }

        private string createNewPath(string filePath)
        {
            string[] splitedNameFile = Path.GetFileName(filePath).Split('.');
            string newPath = Path.GetDirectoryName(filePath) + string.Join(".", splitedNameFile, 0, splitedNameFile.Length - 1) + "_copy.csv";
        
            return newPath;
        }

        private void CreateNewFile(string filePath, List<string[]> headerFile, List<string[]> dataFile)
        {
            StringBuilder scvContent = new StringBuilder();

            scvContent.AppendLine(string.Join(";", headerFile[0]));
            foreach (string[] field in dataFile)
                scvContent.AppendLine(string.Join(";", field));

            File.WriteAllText(filePath, scvContent.ToString(), this.fileEncoding);
        }

        private void LoadDataFromFile(string filePath)
        {
            this.headerFile.Clear();
            this.dataFile.Clear();

            using (TextFieldParser parser = new TextFieldParser(filePath, this.fileEncoding))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                this.headerFile.Add(parser.ReadFields());

                while (!parser.EndOfData)
                    this.dataFile.Add(parser.ReadFields());
            }
        }

        /* User functionality */

        public void LoadNewFile()
        {
            this.modifFilePath = createNewPath(this.inputFilePath);

            LoadDataFromFile(this.inputFilePath);
            CreateNewFile(this.modifFilePath, this.headerFile, this.dataFile);
        }

        public void UpdateTheFile()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(string.Join(";", this.headerFile[0]));
            foreach (string[] dataRow in this.dataFile)
                stringBuilder.AppendLine(string.Join(";", dataRow));

            File.WriteAllText(this.modifFilePath, stringBuilder.ToString(), fileEncoding);
        }

        public void AddToFile(string[] data)
        {
            this.dataFile.Add(data);
            this.UpdateTheFile();
        }

        public void RemoveAtFile(List<int> indexes)
        {
            foreach(int index in indexes)
                this.dataFile.RemoveAt(index);

            UpdateTheFile();
        }

        public void UpdateLineInFile(string[] dataLine, int index)
        {
            this.dataFile[index] = dataLine;
        
            UpdateTheFile();
        }
    }
}
