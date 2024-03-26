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
            answer1Rb.Appearance = Appearance.Button;
            answer1Rb.BackColor = Color.BurlyWood;
            answer1Rb.FlatAppearance.BorderColor = Color.Black;
            answer1Rb.FlatStyle = FlatStyle.Flat;
            answer1Rb.Location = new Point(45, 202);
            answer1Rb.Name = "answer1Rb";
            answer1Rb.Size = new Size(190, 48);
            answer1Rb.TabIndex = 1;
            answer1Rb.Text = "answer1";
            answer1Rb.TextAlign = ContentAlignment.MiddleCenter;
            answer1Rb.UseVisualStyleBackColor = false;
            // 
            // answer2Rb
            // 
            answer2Rb.Appearance = Appearance.Button;
            answer2Rb.BackColor = Color.BurlyWood;
            answer2Rb.FlatAppearance.BorderColor = Color.Black;
            answer2Rb.FlatStyle = FlatStyle.Flat;
            answer2Rb.Location = new Point(45, 277);
            answer2Rb.Name = "answer2Rb";
            answer2Rb.Size = new Size(190, 48);
            answer2Rb.TabIndex = 2;
            answer2Rb.Text = "answer2";
            answer2Rb.TextAlign = ContentAlignment.MiddleCenter;
            answer2Rb.UseVisualStyleBackColor = false;
            answer2Rb.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // answer4Rb
            // 
            answer4Rb.Appearance = Appearance.Button;
            answer4Rb.BackColor = Color.BurlyWood;
            answer4Rb.FlatAppearance.BorderColor = Color.Black;
            answer4Rb.FlatStyle = FlatStyle.Flat;
            answer4Rb.Location = new Point(329, 277);
            answer4Rb.Name = "answer4Rb";
            answer4Rb.Size = new Size(190, 48);
            answer4Rb.TabIndex = 4;
            answer4Rb.Text = "answer4";
            answer4Rb.TextAlign = ContentAlignment.MiddleCenter;
            answer4Rb.UseVisualStyleBackColor = false;
            // 
            // answer3Rb
            // 
            answer3Rb.Appearance = Appearance.Button;
            answer3Rb.BackColor = Color.BurlyWood;
            answer3Rb.FlatAppearance.BorderColor = Color.Black;
            answer3Rb.FlatStyle = FlatStyle.Flat;
            answer3Rb.Location = new Point(329, 202);
            answer3Rb.Name = "answer3Rb";
            answer3Rb.Size = new Size(190, 48);
            answer3Rb.TabIndex = 3;
            answer3Rb.Text = "answer3";
            answer3Rb.TextAlign = ContentAlignment.MiddleCenter;
            answer3Rb.UseVisualStyleBackColor = false;
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
            questionTb.TabIndex = 8;
            questionTb.TabStop = false;
            questionTb.Text = "asdfghjkléá";
            // 
            // SingleQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
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
