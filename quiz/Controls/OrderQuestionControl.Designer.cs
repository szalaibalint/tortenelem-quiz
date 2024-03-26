namespace quiz.Controls
{
    partial class OrderQuestionControl
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
            listBox1 = new ListBox();
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
            questionTb.TabIndex = 9;
            questionTb.TabStop = false;
            questionTb.Text = "asdfghjkléá";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Tan;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(181, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(194, 165);
            listBox1.TabIndex = 10;
            // 
            // OrderQuestionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            Controls.Add(listBox1);
            Controls.Add(questionTb);
            Name = "OrderQuestionControl";
            Size = new Size(570, 350);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionTb;
        private ListBox listBox1;
    }
}
