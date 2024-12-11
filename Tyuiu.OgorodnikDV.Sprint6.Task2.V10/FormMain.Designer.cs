namespace Tyuiu.OgorodnikDV.Sprint6.Task2.V10
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_ODV = new TextBox();
            textBoxInput = new TextBox();
            textBox_StartValue = new TextBox();
            textBox_StopValue = new TextBox();
            textBoxResult = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ODV
            // 
            groupBoxTask_ODV.Location = new Point(12, 12);
            groupBoxTask_ODV.Multiline = true;
            groupBoxTask_ODV.Name = "groupBoxTask_ODV";
            groupBoxTask_ODV.Size = new Size(455, 326);
            groupBoxTask_ODV.TabIndex = 0;
            groupBoxTask_ODV.Text = "Условия \r\nПротабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график Функции.";
            groupBoxTask_ODV.TextChanged += groupBoxTask_ODV_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(12, 344);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(275, 94);
            textBoxInput.TabIndex = 1;
            textBoxInput.Text = "Ввод данных\r\nСтарт шага:         Конец шага:";
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // textBox_StartValue
            // 
            textBox_StartValue.Location = new Point(24, 396);
            textBox_StartValue.Name = "textBox_StartValue";
            textBox_StartValue.Size = new Size(125, 30);
            textBox_StartValue.TabIndex = 2;
            textBox_StartValue.Text = "-5";
            textBox_StartValue.TextChanged += textBox_StartValue_TextChanged;
            // 
            // textBox_StopValue
            // 
            textBox_StopValue.Location = new Point(155, 396);
            textBox_StopValue.Name = "textBox_StopValue";
            textBox_StopValue.Size = new Size(125, 30);
            textBox_StopValue.TabIndex = 3;
            textBox_StopValue.Text = "5";
            textBox_StopValue.TextChanged += textBox_StopValue_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(473, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(525, 426);
            textBoxResult.TabIndex = 4;
            textBoxResult.Text = "Вывод данных\r\nРезультат:";
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(293, 344);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(65, 94);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(364, 344);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(103, 94);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction.Location = new Point(485, 68);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(105, 358);
            dataGridViewFunction.TabIndex = 7;
            dataGridViewFunction.CellContentClick += dataGridViewFunction_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(596, 51);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(503, 375);
            chartFunction.TabIndex = 8;
            chartFunction.Text = "chart1";
            chartFunction.Click += chartFunction_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
            Controls.Add(chartFunction);
            Controls.Add(dataGridViewFunction);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxResult);
            Controls.Add(textBox_StopValue);
            Controls.Add(textBox_StartValue);
            Controls.Add(textBoxInput);
            Controls.Add(groupBoxTask_ODV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 10 | Огородник Д.В.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupBoxTask_ODV;
        private TextBox textBoxInput;
        private TextBox textBox_StartValue;
        private TextBox textBox_StopValue;
        private TextBox textBoxResult;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
