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
    public partial class SingleQuestionControl : UserControl, IQuestionControl
    {
        SelectionQuestion question;
        List<RadioButton> radioButtons = new List<RadioButton>();

        public SingleQuestionControl(SelectionQuestion question)
        {
            InitializeComponent();

            this.question = question;
            questionTb.Text = question.Text;
            answer1Rb.Text = question.Answers[0].text;
            answer2Rb.Text = question.Answers[1].text;
            answer3Rb.Text = question.Answers[2].text;
            answer4Rb.Text = question.Answers[3].text;

            radioButtons.Add(answer1Rb);
            radioButtons.Add(answer2Rb);
            radioButtons.Add(answer3Rb);
            radioButtons.Add(answer4Rb);
        }

        public bool IsCorrect()
        {
            for (int i = 0; i < 4; i++)
            {
                if (radioButtons[i].Checked && question.Answers[i].correct)
                    return true;
            }
            return false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
