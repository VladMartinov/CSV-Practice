namespace DBPracticeApp
{
    partial class FormShowFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowFile));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewRegion = new System.Windows.Forms.DataGridView();
            this.name_region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_car = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_car_norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_count_emissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avg_count_emissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRegion = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.96994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.03006F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewRegion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRegion, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.218905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.7811F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 427);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridViewRegion
            // 
            this.dataGridViewRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegion.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegion.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewRegion.Location = new System.Drawing.Point(3, 29);
            this.dataGridViewRegion.Name = "dataGridViewRegion";
            this.dataGridViewRegion.Size = new System.Drawing.Size(644, 395);
            this.dataGridViewRegion.TabIndex = 4;
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
            this.labelRegion.Size = new System.Drawing.Size(644, 26);
            this.labelRegion.TabIndex = 2;
            this.labelRegion.Text = "Таблица \"Регион\"";
            this.labelRegion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormShowFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormShowFile";
            this.Text = "Data from file";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.DataGridView dataGridViewRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_car;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_car_norm;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_count_emissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn avg_count_emissions;
    }
}