namespace quiz_drag
{
    public partial class Form1 : Form
    {
        bool mouseDown = false;

        public void down(Button btn, MouseEventArgs e)
        {
            if (mouseDown)
            {
                btn.Left = e.X + btn.Left - btn.Width / 2;
                btn.Top = e.Y + btn.Top - btn.Height / 2;
            }
        }

        public void snap(Panel answer, Button btn)
        {
            int answerLocationLeft = answer.Left;
            int answerLocationTop = answer.Top;
            int answerLocationRight = answer.Left + answer.Width;
            int answerLocationBottom = answer.Top + answer.Height;
            int btnLocationLeft = btn.Left;
            int btnLocationTop = btn.Top;
            int btnLocationRight = btn.Left + btn.Width;
            int btnLocationBottom = btn.Top + btn.Height;
            if (btnLocationTop <= 0 || btnLocationBottom >= this.Height || btnLocationLeft <= 0 || btnLocationRight >= this.Width)
            {
                btn.Top = 300;
                btn.Left = 300;
            }
            else if (btnLocationLeft >= answerLocationLeft && btnLocationTop >= answerLocationTop && btnLocationLeft <= answerLocationRight && btnLocationTop <= answerLocationBottom || btnLocationRight <= answerLocationRight && btnLocationBottom <= answerLocationBottom && btnLocationRight >= answerLocationLeft && btnLocationBottom >= answerLocationTop || btnLocationLeft >= answerLocationLeft && btnLocationBottom <= answerLocationBottom && btnLocationLeft <= answerLocationRight && btnLocationBottom >= answerLocationTop || btnLocationRight <= answerLocationRight && btnLocationTop >= answerLocationTop && btnLocationRight >= answerLocationLeft && btnLocationTop <= answerLocationBottom)
            {

                if (answerLocationLeft == btn1.Left && answerLocationTop == btn1.Top || answerLocationLeft == btn2.Left && answerLocationTop == btn2.Top || answerLocationLeft == btn3.Left && answerLocationTop == btn3.Top || answerLocationLeft == btn4.Left && answerLocationTop == btn4.Top)
                {
                    btn.Left = answerLocationRight + 50;
                    btn.Top = (answerLocationTop + answerLocationBottom) / 2 - btn.Height / 2;
                }
                else
                {
                    btn.Left = answer.Left;
                    btn.Top = answer.Top;
                }
            }
        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

            snap(answer1, btn1);
            snap(answer2, btn1);
            snap(answer3, btn1);
            snap(answer4, btn1);

        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btn1_MouseMove(object sender, MouseEventArgs e)
        {
            down(btn1, e);
        }

        private void btn2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            snap(answer1, btn2);
            snap(answer2, btn2);
            snap(answer3, btn2);
            snap(answer4, btn2);
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btn2_MouseMove(object sender, MouseEventArgs e)
        {
            down(btn2, e);
        }
        private void btn3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

            snap(answer1, btn3);
            snap(answer2, btn3);
            snap(answer3, btn3);
            snap(answer4, btn3);

        }

        private void btn3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btn3_MouseMove(object sender, MouseEventArgs e)
        {
            down(btn3, e);
        }
        private void btn4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

            snap(answer1, btn4);
            snap(answer2, btn4);
            snap(answer3, btn4);
            snap(answer4, btn4);

        }

        private void btn4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void btn4_MouseMove(object sender, MouseEventArgs e)
        {
            down(btn4, e);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            if (btn1.Top == answer1.Top)
            {
                btn1.BackColor = Color.Green;
            }
            else
            {
                btn1.BackColor = Color.Red;
            }
            if (btn2.Top == answer2.Top)
            {
                btn2.BackColor = Color.Green;
            }
            else
            {
                btn2.BackColor = Color.Red;
            }
            if (btn3.Top == answer3.Top)
            {
                btn3.BackColor = Color.Green;
            }
            else
            {
                btn3.BackColor = Color.Red;
            }
            if (btn4.Top == answer4.Top)
            {
                btn4.BackColor = Color.Green;
            }
            else
            {
                btn4.BackColor = Color.Red;
            }
        }
    }
}
