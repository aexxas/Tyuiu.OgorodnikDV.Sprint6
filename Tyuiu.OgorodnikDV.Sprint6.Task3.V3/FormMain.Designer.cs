namespace Tyuiu.OgorodnikDV.Sprint6.Task3.V3
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
            groupBoxTask_ODV = new TextBox();
            textBoxInput_ODV = new TextBox();
            buttonRes_ODV = new Button();
            buttonHelp_ODV = new Button();
            dataGridView_ODV = new DataGridView();
            dataGridViewOut_ODV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ODV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ODV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ODV
            // 
            groupBoxTask_ODV.Location = new Point(12, 25);
            groupBoxTask_ODV.Multiline = true;
            groupBoxTask_ODV.Name = "groupBoxTask_ODV";
            groupBoxTask_ODV.ReadOnly = true;
            groupBoxTask_ODV.Size = new Size(242, 414);
            groupBoxTask_ODV.TabIndex = 0;
            groupBoxTask_ODV.Text = "Условие \r\nДана матритца 5 на 5\r\n-18  21  10  -2  12\r\n -18 -10  33 -20  32\r\n  14 -15 -14  12 -18\r\n -19   5  -3  28 -17\r\n -14  -9  23 -13  11\r\nВыполнить сортировку по возрастанию во втором столбце.";
            // 
            // textBoxInput_ODV
            // 
            textBoxInput_ODV.Location = new Point(490, 24);
            textBoxInput_ODV.Multiline = true;
            textBoxInput_ODV.Name = "textBoxInput_ODV";
            textBoxInput_ODV.ReadOnly = true;
            textBoxInput_ODV.Size = new Size(298, 344);
            textBoxInput_ODV.TabIndex = 1;
            textBoxInput_ODV.Text = "Вывод данных\r\nРезультат \r\n";
            // 
            // buttonRes_ODV
            // 
            buttonRes_ODV.Location = new Point(662, 391);
            buttonRes_ODV.Name = "buttonRes_ODV";
            buttonRes_ODV.Size = new Size(126, 47);
            buttonRes_ODV.TabIndex = 2;
            buttonRes_ODV.Text = "Выполнить ";
            buttonRes_ODV.UseVisualStyleBackColor = true;
            buttonRes_ODV.Click += buttonRes_ODV_Click;
            // 
            // buttonHelp_ODV
            // 
            buttonHelp_ODV.Location = new Point(537, 392);
            buttonHelp_ODV.Name = "buttonHelp_ODV";
            buttonHelp_ODV.Size = new Size(119, 47);
            buttonHelp_ODV.TabIndex = 3;
            buttonHelp_ODV.Text = "?";
            buttonHelp_ODV.UseVisualStyleBackColor = true;
            buttonHelp_ODV.Click += buttonHelp_ODV_Click;
            // 
            // dataGridView_ODV
            // 
            dataGridView_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ODV.Location = new Point(260, 26);
            dataGridView_ODV.Name = "dataGridView_ODV";
            dataGridView_ODV.RowHeadersWidth = 51;
            dataGridView_ODV.Size = new Size(224, 413);
            dataGridView_ODV.TabIndex = 4;
            // 
            // dataGridViewOut_ODV
            // 
            dataGridViewOut_ODV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_ODV.Location = new Point(502, 77);
            dataGridViewOut_ODV.Name = "dataGridViewOut_ODV";
            dataGridViewOut_ODV.RowHeadersVisible = false;
            dataGridViewOut_ODV.RowHeadersWidth = 51;
            dataGridViewOut_ODV.Size = new Size(273, 273);
            dataGridViewOut_ODV.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewOut_ODV);
            Controls.Add(dataGridView_ODV);
            Controls.Add(buttonHelp_ODV);
            Controls.Add(buttonRes_ODV);
            Controls.Add(textBoxInput_ODV);
            Controls.Add(groupBoxTask_ODV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 3 | Огородник Д.В.";
            ((System.ComponentModel.ISupportInitialize)dataGridView_ODV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ODV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupBoxTask_ODV;
        private TextBox textBoxInput_ODV;
        private Button buttonRes_ODV;
        private Button buttonHelp_ODV;
        private DataGridView dataGridView_ODV;
        private DataGridView dataGridViewOut_ODV;
    }
}
