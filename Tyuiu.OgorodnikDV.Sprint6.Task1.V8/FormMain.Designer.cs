namespace Tyuiu.OgorodnikDV.Sprint6.Task1.V8
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
            textBox2 = new TextBox();
            textBox_StartValue = new TextBox();
            textBox_StopValue = new TextBox();
            buttonhelp = new Button();
            buttonDone = new Button();
            groupBoxResult = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // groupBoxTask_ODV
            // 
            groupBoxTask_ODV.Location = new Point(4, 12);
            groupBoxTask_ODV.Multiline = true;
            groupBoxTask_ODV.Name = "groupBoxTask_ODV";
            groupBoxTask_ODV.ReadOnly = true;
            groupBoxTask_ODV.Size = new Size(503, 318);
            groupBoxTask_ODV.TabIndex = 0;
            groupBoxTask_ODV.Text = "Условие\r\nПотабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблице.";
            groupBoxTask_ODV.TextChanged += groupBoxTask_ODV_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(4, 336);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(283, 102);
            textBox2.TabIndex = 1;
            textBox2.Text = "Ввод данных\r\nСтарт шага:           Конец шага:";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox_StartValue
            // 
            textBox_StartValue.Location = new Point(12, 395);
            textBox_StartValue.Name = "textBox_StartValue";
            textBox_StartValue.Size = new Size(125, 30);
            textBox_StartValue.TabIndex = 2;
            textBox_StartValue.Text = "-5";
            textBox_StartValue.TextChanged += textBox_StartValue_TextChanged;
            // 
            // textBox_StopValue
            // 
            textBox_StopValue.Location = new Point(153, 395);
            textBox_StopValue.Name = "textBox_StopValue";
            textBox_StopValue.Size = new Size(125, 30);
            textBox_StopValue.TabIndex = 3;
            textBox_StopValue.Text = "5";
            textBox_StopValue.TextChanged += textBox_StopValue_TextChanged;
            // 
            // buttonhelp
            // 
            buttonhelp.BackColor = SystemColors.MenuHighlight;
            buttonhelp.Location = new Point(293, 336);
            buttonhelp.Name = "buttonhelp";
            buttonhelp.Size = new Size(94, 102);
            buttonhelp.TabIndex = 4;
            buttonhelp.Text = "Справка";
            buttonhelp.UseVisualStyleBackColor = false;
            buttonhelp.Click += buttonhelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(393, 336);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(114, 102);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Location = new Point(513, 12);
            groupBoxResult.Multiline = true;
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.ReadOnly = true;
            groupBoxResult.Size = new Size(275, 426);
            groupBoxResult.TabIndex = 6;
            groupBoxResult.Text = "Вывод данных\r\nРезультат:";
            groupBoxResult.TextChanged += groupBoxResult_TextChanged;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(522, 62);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(258, 363);
            textBoxResult.TabIndex = 7;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(groupBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(buttonhelp);
            Controls.Add(textBox_StopValue);
            Controls.Add(textBox_StartValue);
            Controls.Add(textBox2);
            Controls.Add(groupBoxTask_ODV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Огородник Д.В.";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupBoxTask_ODV;
        private TextBox textBox2;
        private TextBox textBox_StartValue;
        private TextBox textBox_StopValue;
        private Button buttonhelp;
        private Button buttonDone;
        private TextBox groupBoxResult;
        private TextBox textBoxResult;
    }
}
