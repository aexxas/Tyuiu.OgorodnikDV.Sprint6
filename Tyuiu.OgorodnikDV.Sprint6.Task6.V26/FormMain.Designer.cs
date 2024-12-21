namespace Tyuiu.OgorodnikDV.Sprint6.Task6.V26
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_ODV = new Button();
            buttonSave_ODV = new Button();
            buttonOpen_ODV = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            textBoxConclusion_ODV = new TextBox();
            panel4 = new Panel();
            groupBoxConclusion_ODV = new GroupBox();
            textBoxInput_ODV = new TextBox();
            openFileDialogTask_ODV = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxConclusion_ODV.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_ODV);
            panel1.Controls.Add(buttonSave_ODV);
            panel1.Controls.Add(buttonOpen_ODV);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 121);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_ODV
            // 
            buttonHelp_ODV.Image = (Image)resources.GetObject("buttonHelp_ODV.Image");
            buttonHelp_ODV.Location = new Point(666, 7);
            buttonHelp_ODV.Name = "buttonHelp_ODV";
            buttonHelp_ODV.Size = new Size(122, 100);
            buttonHelp_ODV.TabIndex = 2;
            buttonHelp_ODV.UseVisualStyleBackColor = true;
            buttonHelp_ODV.TextChanged += buttonHelp_ODV_Click;
            buttonHelp_ODV.Click += buttonHelp_ODV_Click;
            // 
            // buttonSave_ODV
            // 
            buttonSave_ODV.Image = (Image)resources.GetObject("buttonSave_ODV.Image");
            buttonSave_ODV.Location = new Point(147, 7);
            buttonSave_ODV.Name = "buttonSave_ODV";
            buttonSave_ODV.Size = new Size(138, 100);
            buttonSave_ODV.TabIndex = 1;
            buttonSave_ODV.UseVisualStyleBackColor = true;
            buttonSave_ODV.TextChanged += buttonSave_ODV_Click;
            buttonSave_ODV.Click += buttonSave_ODV_Click;
            // 
            // buttonOpen_ODV
            // 
            buttonOpen_ODV.Image = (Image)resources.GetObject("buttonOpen_ODV.Image");
            buttonOpen_ODV.Location = new Point(3, 3);
            buttonOpen_ODV.Name = "buttonOpen_ODV";
            buttonOpen_ODV.Size = new Size(122, 115);
            buttonOpen_ODV.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpen_ODV, "Выберите нужный файл для обработки");
            buttonOpen_ODV.UseVisualStyleBackColor = true;
            buttonOpen_ODV.TextChanged += buttonOpen_ODV_Click;
            buttonOpen_ODV.Click += buttonOpen_ODV_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 325);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(373, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(429, 322);
            panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxConclusion_ODV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 322);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод:";
            // 
            // textBoxConclusion_ODV
            // 
            textBoxConclusion_ODV.Location = new Point(6, 29);
            textBoxConclusion_ODV.Multiline = true;
            textBoxConclusion_ODV.Name = "textBoxConclusion_ODV";
            textBoxConclusion_ODV.ScrollBars = ScrollBars.Vertical;
            textBoxConclusion_ODV.Size = new Size(409, 287);
            textBoxConclusion_ODV.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxConclusion_ODV);
            panel4.Location = new Point(3, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 322);
            panel4.TabIndex = 0;
            // 
            // groupBoxConclusion_ODV
            // 
            groupBoxConclusion_ODV.Controls.Add(textBoxInput_ODV);
            groupBoxConclusion_ODV.Dock = DockStyle.Fill;
            groupBoxConclusion_ODV.Location = new Point(0, 0);
            groupBoxConclusion_ODV.Name = "groupBoxConclusion_ODV";
            groupBoxConclusion_ODV.Size = new Size(364, 322);
            groupBoxConclusion_ODV.TabIndex = 1;
            groupBoxConclusion_ODV.TabStop = false;
            groupBoxConclusion_ODV.Text = "Ввод:";
            // 
            // textBoxInput_ODV
            // 
            textBoxInput_ODV.Location = new Point(3, 26);
            textBoxInput_ODV.Multiline = true;
            textBoxInput_ODV.Name = "textBoxInput_ODV";
            textBoxInput_ODV.ScrollBars = ScrollBars.Vertical;
            textBoxInput_ODV.Size = new Size(355, 290);
            textBoxInput_ODV.TabIndex = 0;
            // 
            // openFileDialogTask_ODV
            // 
            openFileDialogTask_ODV.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 459);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Огородник Д.В.";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxConclusion_ODV.ResumeLayout(false);
            groupBoxConclusion_ODV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private Panel panel4;
        private GroupBox groupBoxConclusion_ODV;
        private Button buttonSave_ODV;
        private Button buttonOpen_ODV;
        private OpenFileDialog openFileDialogTask_ODV;
        private ToolTip toolTip1;
        private Button buttonHelp_ODV;
        private TextBox textBoxConclusion_ODV;
        private TextBox textBoxInput_ODV;
    }
}
