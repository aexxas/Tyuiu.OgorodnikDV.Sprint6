using System.IO;
using Tyuiu.OgorodnikDV.Sprint6.Task5.V3.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formsPlotChartResult_ODV_Click(object sender, EventArgs e)
        {

        }


        string path = @"C:\Users\Dasha\source\repos\Tyuiu.OgorodnikDV.Sprint6\Tyuiu.OgorodnikDV.Sprint6.Task5.V3\InPutDataFileTask5V3.txt";

        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ODV.ColumnCount = 2;
            dataGridViewResult_ODV.Columns[0].Width = 20;
            dataGridViewResult_ODV.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ODV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-24-1 Огородник Дарья Вячеславовна", "Справка");
        }

        private void dataGridViewResult_ODV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

