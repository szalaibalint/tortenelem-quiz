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
    public partial class DateQuestionControl : UserControl, IQuestionControl
    {
        DateQuestion question;
        public DateQuestionControl(DateQuestion question)
        {
            InitializeComponent();

            this.question = question;
            questionTb.Text = question.Text;
        }

        public bool isSelected()
        {
            return true;
        }

        public bool IsCorrect()
        {
            return dateInput.Value == question.Answer;
        }
    }
}
