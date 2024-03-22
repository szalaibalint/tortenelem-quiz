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
        public Quiz()
        {
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            DateQuestion test = Question.LoadFromJSON("data/evszam1.json") as DateQuestion;

            questionsTab.Appearance = TabAppearance.FlatButtons;
            questionsTab.ItemSize = new Size(0, 1);
            questionsTab.SizeMode = TabSizeMode.Fixed;
            
            
            TabPage tab = new TabPage();
            tab.Controls.Add(new DateQuestionControl(test));
            questionsTab.TabPages.Add(tab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((questionsTab.TabPages[questionsTab.SelectedIndex].Controls[0] as IQuestionControl).IsCorrect()) 
            {
                MessageBox.Show("helyes válasz");
            }
            else
            {
                MessageBox.Show("helytelen válasz :P");
            }
        }
    }
}
