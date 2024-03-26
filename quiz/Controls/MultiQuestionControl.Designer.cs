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
            label1 = new Label();
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
            answer1Check.BackColor = Color.BurlyWood;
            answer1Check.FlatAppearance.BorderSize = 0;
            answer1Check.FlatStyle = FlatStyle.Flat;
            answer1Check.Font = new Font("Segoe UI", 9F);
            answer1Check.Location = new Point(45, 202);
            answer1Check.Name = "answer1Check";
            answer1Check.Size = new Size(190, 48);
            answer1Check.TabIndex = 7;
            answer1Check.Text = "answer1";
            answer1Check.TextAlign = ContentAlignment.MiddleCenter;
            answer1Check.UseVisualStyleBackColor = false;
            // 
            // answer3Check
            // 
            answer3Check.Appearance = Appearance.Button;
            answer3Check.BackColor = Color.BurlyWood;
            answer3Check.FlatAppearance.BorderSize = 0;
            answer3Check.FlatStyle = FlatStyle.Flat;
            answer3Check.Font = new Font("Segoe UI", 9F);
            answer3Check.Location = new Point(329, 202);
            answer3Check.Name = "answer3Check";
            answer3Check.Size = new Size(190, 48);
            answer3Check.TabIndex = 8;
            answer3Check.Text = "answer3";
            answer3Check.TextAlign = ContentAlignment.MiddleCenter;
            answer3Check.UseVisualStyleBackColor = false;
            // 
            // answer4Check
            // 
            answer4Check.Appearance = Appearance.Button;
            answer4Check.BackColor = Color.BurlyWood;
            answer4Check.FlatAppearance.BorderSize = 0;
            answer4Check.FlatStyle = FlatStyle.Flat;
            answer4Check.Font = new Font("Segoe UI", 9F);
            answer4Check.Location = new Point(329, 277);
            answer4Check.Name = "answer4Check";
            answer4Check.Size = new Size(190, 48);
            answer4Check.TabIndex = 9;
            answer4Check.Text = "answer4";
            answer4Check.TextAlign = ContentAlignment.MiddleCenter;
            answer4Check.UseVisualStyleBackColor = false;
            // 
            // answer2Check
            // 
            answer2Check.Appearance = Appearance.Button;
            answer2Check.BackColor = Color.BurlyWood;
            answer2Check.FlatAppearance.BorderSize = 0;
            answer2Check.FlatStyle = FlatStyle.Flat;
            answer2Check.Font = new Font("Segoe UI", 9F);
            answer2Check.Location = new Point(45, 277);
            answer2Check.Name = "answer2Check";
            answer2Check.Size = new Size(190, 48);
            answer2Check.TabIndex = 10;
            answer2Check.Text = "answer2";
            answer2Check.TextAlign = ContentAlignment.MiddleCenter;
            answer2Check.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PapayaWhip;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 177);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 11;
            label1.Text = "Több válasz is lehetséges";
            // 
            // MultiQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            Controls.Add(label1);
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
        private Label label1;
    }
}
