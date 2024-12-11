using Tyuiu.OgorodnikDV.Sprint6.Task0.V17.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }


        private void buttonDone_ODV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ODV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_ODV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxX_ODV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ODV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент группы ИСПб-24-1 Огородник Дарья Вячеславовна", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxX_ODV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInpun_ODV_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_ODV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_Click(object sender, EventArgs e)
        {

        }
    }
}
