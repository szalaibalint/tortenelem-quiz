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
    public partial class TrueFalseQuestionControl : UserControl, IQuestionControl
    {
        TrueFalseQuestion question;
        public TrueFalseQuestionControl(TrueFalseQuestion question)
        {
            InitializeComponent();

            this.question = question;
            questionTb.Text = question.Text;
        }

        public bool IsCorrect()
        {
            return (question.IsCorrect && trueButton.Checked) || (!question.IsCorrect && falseButton.Checked);
        }

        private void trueButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
