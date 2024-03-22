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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((questionsTab.TabPages[questionsTab.SelectedIndex].Controls[0] as IQuestionControl).IsCorrect()) 
            {
                points++;
            }
            questionsTab.SelectedIndex++;
            pointsLbl.Text = points.ToString();
        }
    }
}
