namespace Tyuiu.OgorodnikDV.Sprint6.Task5.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            buttonResult = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_ODV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ODV).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(801, 114);
            textBox1.TabIndex = 0;
            textBox1.Text = "Условие:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 113);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(225, 337);
            textBox2.TabIndex = 1;
            textBox2.Text = "Вывод данные";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 26);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(409, 81);
            textBox4.TabIndex = 3;
            textBox4.Text = "Вывести все вещественные числа.  Построить диаграмму по этим значениям.";
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Green;
            buttonResult.ForeColor = SystemColors.ControlText;
            buttonResult.Location = new Point(427, 26);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(111, 81);
            buttonResult.TabIndex = 4;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = SystemColors.Highlight;
            buttonOpenFile.Location = new Point(544, 26);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(113, 81);
            buttonOpenFile.TabIndex = 5;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.GrayText;
            buttonHelp.Location = new Point(684, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(103, 81);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(222, 113);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(580, 337);
            chartFunction.TabIndex = 7;
            chartFunction.Text = "chart1";
            chartFunction.Click += formsPlotChartResult_ODV_Click;
            // 
            // dataGridViewResult_ODV
            // 
            dataGridViewResult_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_ODV.Location = new Point(12, 143);
            dataGridViewResult_ODV.Name = "dataGridViewResult_ODV";
            dataGridViewResult_ODV.RowHeadersWidth = 51;
            dataGridViewResult_ODV.Size = new Size(204, 294);
            dataGridViewResult_ODV.TabIndex = 8;
            dataGridViewResult_ODV.CellContentClick += dataGridViewResult_ODV_CellContentClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 449);
            Controls.Add(dataGridViewResult_ODV);
            Controls.Add(chartFunction);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenFile);
            Controls.Add(buttonResult);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Button buttonResult;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewResult_ODV;
    }
}
