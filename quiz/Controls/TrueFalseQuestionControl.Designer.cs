namespace quiz.Controls
{
    partial class TrueFalseQuestionControl
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
            falseButton = new RadioButton();
            trueButton = new RadioButton();
            SuspendLayout();
            // 
            // questionTb
            // 
            questionTb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            questionTb.Location = new Point(3, 3);
            questionTb.Multiline = true;
            questionTb.Name = "questionTb";
            questionTb.ReadOnly = true;
            questionTb.Size = new Size(564, 171);
            questionTb.TabIndex = 7;
            questionTb.Text = "asdfghjkléá";
            // 
            // falseButton
            // 
            falseButton.Appearance = Appearance.Button;
            falseButton.AutoSize = true;
            falseButton.Font = new Font("Segoe UI", 18F);
            falseButton.Location = new Point(198, 237);
            falseButton.Name = "falseButton";
            falseButton.Size = new Size(90, 42);
            falseButton.TabIndex = 8;
            falseButton.TabStop = true;
            falseButton.Text = "Hamis";
            falseButton.UseVisualStyleBackColor = true;
            // 
            // trueButton
            // 
            trueButton.Appearance = Appearance.Button;
            trueButton.AutoSize = true;
            trueButton.Font = new Font("Segoe UI", 18F);
            trueButton.Location = new Point(294, 237);
            trueButton.Name = "trueButton";
            trueButton.Size = new Size(67, 42);
            trueButton.TabIndex = 9;
            trueButton.TabStop = true;
            trueButton.Text = "Igaz";
            trueButton.UseVisualStyleBackColor = true;
            // 
            // TrueFalseQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(trueButton);
            Controls.Add(falseButton);
            Controls.Add(questionTb);
            Name = "TrueFalseQuestionControl";
            Size = new Size(570, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionTb;
        private RadioButton falseButton;
        private RadioButton trueButton;
    }
}
