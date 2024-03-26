using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz.Controls
{
    internal interface IQuestionControl
    {
        public bool IsCorrect();
        public bool isSelected();
    }
}
