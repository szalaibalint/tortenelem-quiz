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

        int points;
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            

            questionsTab.Appearance = TabAppearance.FlatButtons;
            questionsTab.ItemSize = new Size(0, 1);
            questionsTab.SizeMode = TabSizeMode.Fixed;
            
            

            foreach (Question q in DataManager.Questions)
            {
                TabPage tab = new TabPage();
                if (q is SelectionQuestion)
                {
                    tab.Controls.Add(new SingleQuestionControl(q as SelectionQuestion));
                    questionsTab.TabPages.Add(tab);
                    continue;
                }
                if(q is DateQuestion)
                {
                    tab.Controls.Add(new DateQuestionControl(q as DateQuestion));
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
            if ((questionsTab.TabPages[questionsTab.SelectedIndex].Controls[0] as IQuestionControl).IsCorrect()) 
            {
                points++;
            }
            if (currentIndex < mainForm.questionCount - 1)
            {
                currentIndex++;
                questionsTab.SelectedIndex = indexList[currentIndex];
            }
            else
            {
                // majd ide durrants befele a hogy mi tortenjen ha vége u know mert lusta vagyok type shit

                questionsTab.Visible = false;
                button1.Visible = false;
            }
            pointsLbl.Text = points.ToString();
        }
    }
}
