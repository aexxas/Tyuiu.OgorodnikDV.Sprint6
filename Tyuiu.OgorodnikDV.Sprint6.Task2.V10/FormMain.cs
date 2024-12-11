using Tyuiu.OgorodnikDV.Sprint6.Task2.V10.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBox_StartValue.Text);
                int stopStep = Convert.ToInt32(textBox_StopValue.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("������ ������ �������");

                this.chartFunction.ChartAreas[0].AxisX.Title = "��� �";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 �������� ������� ������ ����-24-1 ��������� ����� ������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxTask_ODV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_StartValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_StopValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartFunction_Click(object sender, EventArgs e)
        {

        }
    }
}
