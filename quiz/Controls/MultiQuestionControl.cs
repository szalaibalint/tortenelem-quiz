using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz.Controls
{
    public partial class MultiQuestionControl : UserControl, IQuestionControl
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        SelectionQuestion question;
        public MultiQuestionControl(SelectionQuestion question)
        {
            InitializeComponent();

            questionTb.Text = question.Text;
            answer1Check.Text = question.Answers[0].text;
            answer2Check.Text = question.Answers[1].text;
            answer3Check.Text = question.Answers[2].text;
            answer4Check.Text = question.Answers[3].text;

            checkBoxes.Add(answer1Check);
            checkBoxes.Add(answer2Check);
            checkBoxes.Add(answer3Check);
            checkBoxes.Add(answer4Check);

            this.question = question;
        }

        public bool isSelected()
        {
            for (int i = 0; i < 4; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsCorrect()
        {
            for (int i = 0; i < checkBoxes.Count; i++)
            {
                if ((checkBoxes[i].Checked && !question.Answers[i].correct) || !checkBoxes[i].Checked && question.Answers[i].correct)
                    return false;
            }
            return true;
        }
    }
}
