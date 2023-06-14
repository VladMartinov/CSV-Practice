namespace DBPracticeApp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFilters = new System.Windows.Forms.Button();
            this.buttonSortTheFile = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShowModifFile = new System.Windows.Forms.Button();
            this.buttonShowInputFile = new System.Windows.Forms.Button();
            this.labelRegion = new System.Windows.Forms.Label();
            this.dataGridViewRegion = new System.Windows.Forms.DataGridView();
            this.name_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_car_norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_count_emissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_count_emissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonMetrics1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMetrics2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMetrics3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.обПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьФайлToolStripMenuItem});
            this.действияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9.5F);
            this.действияToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // загрузитьФайлToolStripMenuItem
            // 
            this.загрузитьФайлToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.загрузитьФайлToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.загрузитьФайлToolStripMenuItem.Name = "загрузитьФайлToolStripMenuItem";
            this.загрузитьФайлToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.загрузитьФайлToolStripMenuItem.Text = "Загрузить файл";
            this.загрузитьФайлToolStripMenuItem.Click += new System.EventHandler(this.загрузитьФайлToolStripMenuItem_Click);
            // 
            // обПрограммеToolStripMenuItem
            // 
            this.обПрограммеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9.5F);
            this.обПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.обПрограммеToolStripMenuItem.Name = "обПрограммеToolStripMenuItem";
            this.обПрограммеToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.обПрограммеToolStripMenuItem.Text = "Об программе";
            this.обПрограммеToolStripMenuItem.Click += new System.EventHandler(this.обПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Symbol", 9.5F);
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.BurlyWood;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.28381F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.71619F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRegion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRegion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.553971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.44603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 673);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonFilters);
            this.groupBox1.Controls.Add(this.buttonSortTheFile);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия с таблицей \"Регион\"";
            // 
            // buttonFilters
            // 
            this.buttonFilters.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFilters.ForeColor = System.Drawing.Color.Black;
            this.buttonFilters.Location = new System.Drawing.Point(328, 83);
            this.buttonFilters.Name = "buttonFilters";
            this.buttonFilters.Size = new System.Drawing.Size(135, 35);
            this.buttonFilters.TabIndex = 4;
            this.buttonFilters.Text = "Фильтры";
            this.buttonFilters.UseVisualStyleBackColor = false;
            this.buttonFilters.Click += new System.EventHandler(this.buttonFilters_Click);
            // 
            // buttonSortTheFile
            // 
            this.buttonSortTheFile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSortTheFile.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortTheFile.ForeColor = System.Drawing.Color.Black;
            this.buttonSortTheFile.Location = new System.Drawing.Point(245, 141);
            this.buttonSortTheFile.Name = "buttonSortTheFile";
            this.buttonSortTheFile.Size = new System.Drawing.Size(135, 48);
            this.buttonSortTheFile.TabIndex = 3;
            this.buttonSortTheFile.Text = "Отсортировать файл";
            this.buttonSortTheFile.UseVisualStyleBackColor = false;
            this.buttonSortTheFile.Click += new System.EventHandler(this.buttonSortTheFile_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonUpdate.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdate.Location = new System.Drawing.Point(170, 83);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(135, 35);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.Location = new System.Drawing.Point(328, 26);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(135, 35);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(170, 26);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonShowModifFile);
            this.groupBox2.Controls.Add(this.buttonShowInputFile);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(655, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Показ файлов";
            // 
            // buttonShowModifFile
            // 
            this.buttonShowModifFile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShowModifFile.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowModifFile.ForeColor = System.Drawing.Color.Black;
            this.buttonShowModifFile.Location = new System.Drawing.Point(6, 83);
            this.buttonShowModifFile.Name = "buttonShowModifFile";
            this.buttonShowModifFile.Size = new System.Drawing.Size(232, 35);
            this.buttonShowModifFile.TabIndex = 5;
            this.buttonShowModifFile.Text = "Модифицированный файл";
            this.buttonShowModifFile.UseVisualStyleBackColor = false;
            this.buttonShowModifFile.Click += new System.EventHandler(this.buttonShowModifFile_Click);
            // 
            // buttonShowInputFile
            // 
            this.buttonShowInputFile.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonShowInputFile.ForeColor = System.Drawing.Color.Black;
            this.buttonShowInputFile.Location = new System.Drawing.Point(45, 26);
            this.buttonShowInputFile.Name = "buttonShowInputFile";
            this.buttonShowInputFile.Size = new System.Drawing.Size(152, 35);
            this.buttonShowInputFile.TabIndex = 4;
            this.buttonShowInputFile.Text = "Исходный файл";
            this.buttonShowInputFile.UseVisualStyleBackColor = false;
            this.buttonShowInputFile.Click += new System.EventHandler(this.buttonShowInputFile_Click);
            // 
            // labelRegion
            // 
            this.labelRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegion.ForeColor = System.Drawing.Color.White;
            this.labelRegion.Location = new System.Drawing.Point(3, 0);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(646, 40);
            this.labelRegion.TabIndex = 2;
            this.labelRegion.Text = "Таблица \"Регион\"";
            this.labelRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRegion
            // 
            this.dataGridViewRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegion.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_region,
            this.name_country,
            this.count_car,
            this.count_car_norm,
            this.add_count_emissions,
            this.avg_count_emissions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegion.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewRegion.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewRegion.Name = "dataGridViewRegion";
            this.dataGridViewRegion.Size = new System.Drawing.Size(646, 426);
            this.dataGridViewRegion.TabIndex = 3;
            // 
            // name_region
            // 
            this.name_region.HeaderText = "Регион";
            this.name_region.Name = "name_region";
            // 
            // name_country
            // 
            this.name_country.HeaderText = "Страна";
            this.name_country.Name = "name_country";
            // 
            // count_car
            // 
            this.count_car.HeaderText = "Кол.-во машин млн. шт.";
            this.count_car.Name = "count_car";
            // 
            // count_car_norm
            // 
            this.count_car_norm.HeaderText = "Кол.-во машин,  санитарные. нормы,%";
            this.count_car_norm.Name = "count_car_norm";
            // 
            // add_count_emissions
            // 
            this.add_count_emissions.HeaderText = "Доп. кол. выбросов (1 машина за год, т)";
            this.add_count_emissions.Name = "add_count_emissions";
            // 
            // avg_count_emissions
            // 
            this.avg_count_emissions.HeaderText = "Ср. кол. выбросов (1 машина за год т)";
            this.avg_count_emissions.Name = "avg_count_emissions";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonMetrics3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.buttonMetrics2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonMetrics1);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Medium", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(655, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 267);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Метрики";
            // 
            // buttonMetrics1
            // 
            this.buttonMetrics1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonMetrics1.ForeColor = System.Drawing.Color.Black;
            this.buttonMetrics1.Location = new System.Drawing.Point(45, 49);
            this.buttonMetrics1.Name = "buttonMetrics1";
            this.buttonMetrics1.Size = new System.Drawing.Size(152, 35);
            this.buttonMetrics1.TabIndex = 5;
            this.buttonMetrics1.Text = "Показать";
            this.buttonMetrics1.UseVisualStyleBackColor = false;
            this.buttonMetrics1.Click += new System.EventHandler(this.buttonMetrics1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество машин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ср. кол-во выбросов";
            // 
            // buttonMetrics2
            // 
            this.buttonMetrics2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonMetrics2.ForeColor = System.Drawing.Color.Black;
            this.buttonMetrics2.Location = new System.Drawing.Point(45, 129);
            this.buttonMetrics2.Name = "buttonMetrics2";
            this.buttonMetrics2.Size = new System.Drawing.Size(152, 35);
            this.buttonMetrics2.TabIndex = 7;
            this.buttonMetrics2.Text = "Показать";
            this.buttonMetrics2.UseVisualStyleBackColor = false;
            this.buttonMetrics2.Click += new System.EventHandler(this.buttonMetrics2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Кол-во машин сан. нормы";
            // 
            // buttonMetrics3
            // 
            this.buttonMetrics3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonMetrics3.ForeColor = System.Drawing.Color.Black;
            this.buttonMetrics3.Location = new System.Drawing.Point(45, 210);
            this.buttonMetrics3.Name = "buttonMetrics3";
            this.buttonMetrics3.Size = new System.Drawing.Size(152, 35);
            this.buttonMetrics3.TabIndex = 9;
            this.buttonMetrics3.Text = "Показать";
            this.buttonMetrics3.UseVisualStyleBackColor = false;
            this.buttonMetrics3.Click += new System.EventHandler(this.buttonMetrics3_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(926, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Practice";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.DataGridView dataGridViewRegion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФайлToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_car_norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_count_emissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_count_emissions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowModifFile;
        private System.Windows.Forms.Button buttonShowInputFile;
        private System.Windows.Forms.Button buttonSortTheFile;
        private System.Windows.Forms.Button buttonFilters;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMetrics3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMetrics2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMetrics1;
    }
}

