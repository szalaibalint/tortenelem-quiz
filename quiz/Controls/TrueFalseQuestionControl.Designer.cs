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
            questionTb.BackColor = Color.Tan;
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
            falseButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            falseButton.Appearance = Appearance.Button;
            falseButton.FlatStyle = FlatStyle.Flat;
            falseButton.Font = new Font("Segoe UI", 18F);
            falseButton.Location = new Point(75, 222);
            falseButton.Name = "falseButton";
            falseButton.Size = new Size(130, 70);
            falseButton.TabIndex = 8;
            falseButton.Text = "Hamis";
            falseButton.TextAlign = ContentAlignment.MiddleCenter;
            falseButton.UseVisualStyleBackColor = true;
            // 
            // trueButton
            // 
            trueButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            trueButton.Appearance = Appearance.Button;
            trueButton.FlatStyle = FlatStyle.Flat;
            trueButton.Font = new Font("Segoe UI", 18F);
            trueButton.Location = new Point(354, 222);
            trueButton.Name = "trueButton";
            trueButton.Size = new Size(130, 70);
            trueButton.TabIndex = 9;
            trueButton.Text = "Igaz";
            trueButton.TextAlign = ContentAlignment.MiddleCenter;
            trueButton.UseVisualStyleBackColor = true;
            trueButton.CheckedChanged += trueButton_CheckedChanged;
            // 
            // TrueFalseQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
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
