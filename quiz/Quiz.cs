using quiz.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Quiz : Form
    {
        List<int> indexList = new List<int>();

        int currentIndex = 0;
        int question = 1;
        int points;
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            questionCounter.Text = $"{question}/{mainForm.questionCount}";
            questionsTab.Appearance = TabAppearance.FlatButtons;
            questionsTab.ItemSize = new Size(0, 1);
            questionsTab.SizeMode = TabSizeMode.Fixed;

            // Kérdés controllok hozzáadása
            questionsTab.TabPages.Clear();
            foreach (Question q in DataManager.Questions)
            {
                TabPage tab = new TabPage();
                if (q is SelectionQuestion)
                {
                    if ((q as SelectionQuestion).Multiselect)
                    {
                        tab.Controls.Add(new MultiQuestionControl(q as SelectionQuestion));
                        questionsTab.TabPages.Add(tab);
                    }
                    else
                    {
                        tab.Controls.Add(new SingleQuestionControl(q as SelectionQuestion));
                        questionsTab.TabPages.Add(tab);
                    }
                    continue;
                }
                if (q is DateQuestion)
                {
                    tab.Controls.Add(new DateQuestionControl(q as DateQuestion));
                    questionsTab.TabPages.Add(tab);
                    continue;
                }
                if (q is TrueFalseQuestion)
                {
                    tab.Controls.Add(new TrueFalseQuestionControl(q as TrueFalseQuestion));
                    questionsTab.TabPages.Add(tab);
                    continue;
                }
                if (q is OrderQuestion)
                {
                    tab.Controls.Add(new OrderQuestionControl(q as OrderQuestion));
                    questionsTab.TabPages.Add(tab);
                    continue;
                }
            }
            Random rnd = new Random();
            int rndNumber;
            for (int i = 0; i < mainForm.questionCount; i++)
            {
                do
                {
                    rndNumber = rnd.Next(DataManager.Questions.Count);
                }
                while (indexList.Contains(rndNumber));
                indexList.Add(rndNumber);
            }
            questionsTab.SelectedIndex = indexList[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((questionsTab.TabPages[questionsTab.SelectedIndex].Controls[0] as IQuestionControl).isSelected())
            {
                bool isCorrect;
                if ((questionsTab.TabPages[questionsTab.SelectedIndex].Controls[0] as IQuestionControl).IsCorrect())
                {
                    points++;
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }

                

                answersList.Items.Add($"{currentIndex + 1} - {(isCorrect ? "Helyes" : "Helytelen")}");

                if (currentIndex < mainForm.questionCount - 1)
                {
                    currentIndex++;
                    questionsTab.SelectedIndex = indexList[currentIndex];
                    question++;
                    questionCounter.Text = $"{question}/{mainForm.questionCount}";
                }
                else
                {
                    answersList.Size = new Size(100, 390);
                    answersList.Location = new Point(61, 31);
                    endPoints.Text = $"Elért pontszám: {points}/{mainForm.questionCount}";

                    label1.Visible = false;
                    questionsTab.Visible = false;
                    button1.Visible = false;

                    restart.Visible = true;
                    endPoints.Visible = true;
                }
                label1.Text = $"Pontok: {points}";
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            var form = new mainForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void questionCounter_Click(object sender, EventArgs e)
        {
        }
    }
}
