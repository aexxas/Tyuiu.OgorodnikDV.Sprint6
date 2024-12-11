namespace Tyuiu.OgorodnikDV.Sprint6.Task0.V17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_ODV = new TextBox();
            pictureBoxFormula = new PictureBox();
            textBoxInpun_ODV = new TextBox();
            textBoxX_ODV = new TextBox();
            textBox1 = new TextBox();
            buttonDone_ODV = new Button();
            buttonHelp_ODV = new Button();
            textBoxResult_ODV = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_ODV
            // 
            groupBoxTask_ODV.Location = new Point(12, 43);
            groupBoxTask_ODV.Multiline = true;
            groupBoxTask_ODV.Name = "groupBoxTask_ODV";
            groupBoxTask_ODV.ReadOnly = true;
            groupBoxTask_ODV.Size = new Size(608, 174);
            groupBoxTask_ODV.TabIndex = 0;
            groupBoxTask_ODV.Text = "Вычислить выражение по формуле";
            groupBoxTask_ODV.TextChanged += groupBoxTask_ODV_TextChanged;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.ErrorImage = (Image)resources.GetObject("pictureBoxFormula.ErrorImage");
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.InitialImage = (Image)resources.GetObject("pictureBoxFormula.InitialImage");
            pictureBoxFormula.Location = new Point(639, 43);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(109, 119);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBoxFormula_Click;
            // 
            // textBoxInpun_ODV
            // 
            textBoxInpun_ODV.Location = new Point(12, 250);
            textBoxInpun_ODV.Multiline = true;
            textBoxInpun_ODV.Name = "textBoxInpun_ODV";
            textBoxInpun_ODV.ReadOnly = true;
            textBoxInpun_ODV.Size = new Size(340, 188);
            textBoxInpun_ODV.TabIndex = 2;
            textBoxInpun_ODV.Text = "Ввод данных\r\n\r\nПеременная Х";
            textBoxInpun_ODV.TextChanged += textBoxInpun_ODV_TextChanged;
            // 
            // textBoxX_ODV
            // 
            textBoxX_ODV.Location = new Point(21, 324);
            textBoxX_ODV.Name = "textBoxX_ODV";
            textBoxX_ODV.Size = new Size(125, 30);
            textBoxX_ODV.TabIndex = 3;
            textBoxX_ODV.Text = "3";
            textBoxX_ODV.KeyPress += textBoxX_ODV_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(403, 250);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(375, 115);
            textBox1.TabIndex = 4;
            textBox1.Text = "Вывод данных\r\n\r\nРезультат:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone_ODV
            // 
            buttonDone_ODV.Location = new Point(527, 380);
            buttonDone_ODV.Name = "buttonDone_ODV";
            buttonDone_ODV.Size = new Size(251, 58);
            buttonDone_ODV.TabIndex = 5;
            buttonDone_ODV.Text = "Выполнить";
            buttonDone_ODV.UseVisualStyleBackColor = true;
            buttonDone_ODV.Click += buttonDone_ODV_Click;
            // 
            // buttonHelp_ODV
            // 
            buttonHelp_ODV.FlatStyle = FlatStyle.Flat;
            buttonHelp_ODV.Location = new Point(403, 380);
            buttonHelp_ODV.Name = "buttonHelp_ODV";
            buttonHelp_ODV.Size = new Size(102, 58);
            buttonHelp_ODV.TabIndex = 6;
            buttonHelp_ODV.Text = "?";
            buttonHelp_ODV.UseVisualStyleBackColor = true;
            buttonHelp_ODV.Click += buttonHelp_ODV_Click;
            // 
            // textBoxResult_ODV
            // 
            textBoxResult_ODV.Location = new Point(413, 324);
            textBoxResult_ODV.Name = "textBoxResult_ODV";
            textBoxResult_ODV.ReadOnly = true;
            textBoxResult_ODV.Size = new Size(291, 30);
            textBoxResult_ODV.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 7);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(247, 30);
            textBox2.TabIndex = 8;
            textBox2.Text = "Условие";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBoxResult_ODV);
            Controls.Add(buttonHelp_ODV);
            Controls.Add(buttonDone_ODV);
            Controls.Add(textBox1);
            Controls.Add(textBoxX_ODV);
            Controls.Add(textBoxInpun_ODV);
            Controls.Add(pictureBoxFormula);
            Controls.Add(groupBoxTask_ODV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6| Таск 0 | Вариант 17 | Огородник Д.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox groupBoxTask_ODV;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxInpun_ODV;
        private TextBox textBoxX_ODV;
        private TextBox textBox1;
        private Button buttonDone_ODV;
        private Button buttonHelp_ODV;
        private TextBox textBoxResult_ODV;
        private TextBox textBox2;
    }
}
