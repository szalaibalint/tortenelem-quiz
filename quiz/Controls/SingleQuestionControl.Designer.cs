namespace quiz.Controls
{
    partial class SingleQuestionControl
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
            answer1Rb = new RadioButton();
            answer2Rb = new RadioButton();
            answer4Rb = new RadioButton();
            answer3Rb = new RadioButton();
            questionTb = new TextBox();
            SuspendLayout();
            // 
            // answer1Rb
            // 
            answer1Rb.AutoSize = true;
            answer1Rb.Location = new Point(34, 213);
            answer1Rb.Name = "answer1Rb";
            answer1Rb.Size = new Size(68, 19);
            answer1Rb.TabIndex = 1;
            answer1Rb.TabStop = true;
            answer1Rb.Text = "answer1";
            answer1Rb.UseVisualStyleBackColor = true;
            // 
            // answer2Rb
            // 
            answer2Rb.AutoSize = true;
            answer2Rb.Location = new Point(34, 288);
            answer2Rb.Name = "answer2Rb";
            answer2Rb.Size = new Size(68, 19);
            answer2Rb.TabIndex = 2;
            answer2Rb.TabStop = true;
            answer2Rb.Text = "answer2";
            answer2Rb.UseVisualStyleBackColor = true;
            answer2Rb.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // answer4Rb
            // 
            answer4Rb.AutoSize = true;
            answer4Rb.Location = new Point(318, 288);
            answer4Rb.Name = "answer4Rb";
            answer4Rb.Size = new Size(68, 19);
            answer4Rb.TabIndex = 4;
            answer4Rb.TabStop = true;
            answer4Rb.Text = "answer4";
            answer4Rb.UseVisualStyleBackColor = true;
            // 
            // answer3Rb
            // 
            answer3Rb.AutoSize = true;
            answer3Rb.Location = new Point(318, 213);
            answer3Rb.Name = "answer3Rb";
            answer3Rb.Size = new Size(68, 19);
            answer3Rb.TabIndex = 3;
            answer3Rb.TabStop = true;
            answer3Rb.Text = "answer3";
            answer3Rb.UseVisualStyleBackColor = true;
            // 
            // questionTb
            // 
            questionTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            questionTb.Location = new Point(3, 3);
            questionTb.Multiline = true;
            questionTb.Name = "questionTb";
            questionTb.ReadOnly = true;
            questionTb.Size = new Size(564, 171);
            questionTb.TabIndex = 5;
            questionTb.Text = "asdfghjkléá";
            // 
            // SingleQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(questionTb);
            Controls.Add(answer4Rb);
            Controls.Add(answer3Rb);
            Controls.Add(answer2Rb);
            Controls.Add(answer1Rb);
            Name = "SingleQuestionControl";
            Size = new Size(570, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton answer1Rb;
        private RadioButton answer2Rb;
        private RadioButton answer4Rb;
        private RadioButton answer3Rb;
        private TextBox questionTb;
    }
}
