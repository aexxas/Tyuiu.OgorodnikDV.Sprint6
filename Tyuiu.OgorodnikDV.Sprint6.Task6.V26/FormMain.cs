using System.IO;
using Tyuiu.OgorodnikDV.Sprint6.Task6.V26.Lib;

namespace Tyuiu.OgorodnikDV.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonOpen_ODV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ODV.ShowDialog();
            openFilePath = openFileDialogTask_ODV.FileName;
            textBoxInput_ODV.Text = File.ReadAllText(openFilePath);
            groupBoxConclusion_ODV.Text = groupBoxConclusion_ODV.Text + " " + openFileDialogTask_ODV.FileName;
            buttonSave_ODV.Enabled = true;
        }

        private void buttonSave_ODV_Click(object sender, EventArgs e)
        {
            textBoxConclusion_ODV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_ODV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
