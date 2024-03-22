namespace quiz.Controls
{
    partial class DateQuestionControl
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
            dateInput = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dateInput).BeginInit();
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
            questionTb.TabIndex = 6;
            questionTb.Text = "asdfghjkléá";
            // 
            // dateInput
            // 
            dateInput.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dateInput.Location = new Point(197, 226);
            dateInput.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            dateInput.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(183, 65);
            dateInput.TabIndex = 7;
            // 
            // DateQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateInput);
            Controls.Add(questionTb);
            Name = "DateQuestionControl";
            Size = new Size(570, 350);
            ((System.ComponentModel.ISupportInitialize)dateInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionTb;
        private NumericUpDown dateInput;
    }
}
