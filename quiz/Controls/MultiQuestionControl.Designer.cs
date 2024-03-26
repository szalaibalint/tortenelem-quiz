namespace quiz.Controls
{
    partial class MultiQuestionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionTb = new TextBox();
            answer1Check = new CheckBox();
            answer3Check = new CheckBox();
            answer4Check = new CheckBox();
            answer2Check = new CheckBox();
            SuspendLayout();
            // 
            // questionTb
            // 
            questionTb.BackColor = Color.Tan;
            questionTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            questionTb.Location = new Point(3, 3);
            questionTb.Multiline = true;
            questionTb.Name = "questionTb";
            questionTb.ReadOnly = true;
            questionTb.Size = new Size(564, 171);
            questionTb.TabIndex = 6;
            questionTb.Text = "asdfghjkléá";
            // 
            // answer1Check
            // 
            answer1Check.Appearance = Appearance.Button;
            answer1Check.AutoSize = true;
            answer1Check.Location = new Point(113, 230);
            answer1Check.Name = "answer1Check";
            answer1Check.Size = new Size(60, 25);
            answer1Check.TabIndex = 7;
            answer1Check.Text = "answer1";
            answer1Check.UseVisualStyleBackColor = true;
            // 
            // answer3Check
            // 
            answer3Check.Appearance = Appearance.Button;
            answer3Check.AutoSize = true;
            answer3Check.Location = new Point(376, 230);
            answer3Check.Name = "answer3Check";
            answer3Check.Size = new Size(60, 25);
            answer3Check.TabIndex = 8;
            answer3Check.Text = "answer3";
            answer3Check.UseVisualStyleBackColor = true;
            // 
            // answer4Check
            // 
            answer4Check.Appearance = Appearance.Button;
            answer4Check.AutoSize = true;
            answer4Check.Location = new Point(376, 283);
            answer4Check.Name = "answer4Check";
            answer4Check.Size = new Size(60, 25);
            answer4Check.TabIndex = 9;
            answer4Check.Text = "answer4";
            answer4Check.UseVisualStyleBackColor = true;
            // 
            // answer2Check
            // 
            answer2Check.Appearance = Appearance.Button;
            answer2Check.AutoSize = true;
            answer2Check.Location = new Point(113, 283);
            answer2Check.Name = "answer2Check";
            answer2Check.Size = new Size(60, 25);
            answer2Check.TabIndex = 10;
            answer2Check.Text = "answer2";
            answer2Check.UseVisualStyleBackColor = true;
            // 
            // MultiQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(answer2Check);
            Controls.Add(answer4Check);
            Controls.Add(answer3Check);
            Controls.Add(answer1Check);
            Controls.Add(questionTb);
            Name = "MultiQuestionControl";
            Size = new Size(570, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionTb;
        private CheckBox answer1Check;
        private CheckBox answer3Check;
        private CheckBox answer4Check;
        private CheckBox answer2Check;
    }
}
