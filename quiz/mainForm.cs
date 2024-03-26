namespace quiz
{
    public partial class mainForm : Form
    {
        int maxQuestions;
        public static int questionCount;

        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxQuestions = DataManager.Questions.Count;
            if (Int32.TryParse(comboBox1.Text, out int result) && result <= maxQuestions && result > 0)
            {
                questionCount = result;
                var form = new Quiz();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            DataManager.LoadData();
            maxLabel.Text = $"(1 - {DataManager.Questions.Count})";
        }
    }
}
