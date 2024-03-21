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
            questionsTab.Appearance = TabAppearance.FlatButtons;
            questionsTab.ItemSize = new Size(0, 1);
            questionsTab.SizeMode = TabSizeMode.Fixed;
        }
    }
}
