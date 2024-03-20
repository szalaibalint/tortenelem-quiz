namespace quiz_drag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            answer1 = new Panel();
            answer2 = new Panel();
            answer4 = new Panel();
            answer3 = new Panel();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            checkBtn = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(291, 38);
            btn1.Name = "btn1";
            btn1.Size = new Size(145, 41);
            btn1.TabIndex = 0;
            btn1.Text = "btn1";
            btn1.UseVisualStyleBackColor = true;
            btn1.MouseDown += btn1_MouseDown;
            btn1.MouseMove += btn1_MouseMove;
            btn1.MouseUp += btn1_MouseUp;
            // 
            // answer1
            // 
            answer1.BackColor = SystemColors.AppWorkspace;
            answer1.Location = new Point(31, 30);
            answer1.Name = "answer1";
            answer1.Size = new Size(180, 55);
            answer1.TabIndex = 1;
            // 
            // answer2
            // 
            answer2.BackColor = SystemColors.AppWorkspace;
            answer2.Location = new Point(31, 116);
            answer2.Name = "answer2";
            answer2.Size = new Size(180, 55);
            answer2.TabIndex = 2;
            // 
            // answer4
            // 
            answer4.BackColor = SystemColors.AppWorkspace;
            answer4.Location = new Point(31, 288);
            answer4.Name = "answer4";
            answer4.Size = new Size(180, 55);
            answer4.TabIndex = 4;
            // 
            // answer3
            // 
            answer3.BackColor = SystemColors.AppWorkspace;
            answer3.Location = new Point(31, 202);
            answer3.Name = "answer3";
            answer3.Size = new Size(180, 55);
            answer3.TabIndex = 3;
            // 
            // btn2
            // 
            btn2.Location = new Point(291, 124);
            btn2.Name = "btn2";
            btn2.Size = new Size(145, 41);
            btn2.TabIndex = 5;
            btn2.Text = "btn2";
            btn2.UseVisualStyleBackColor = true;
            btn2.MouseDown += btn2_MouseDown;
            btn2.MouseMove += btn2_MouseMove;
            btn2.MouseUp += btn2_MouseUp;
            // 
            // btn4
            // 
            btn4.Location = new Point(291, 296);
            btn4.Name = "btn4";
            btn4.Size = new Size(145, 41);
            btn4.TabIndex = 7;
            btn4.Text = "btn4";
            btn4.UseVisualStyleBackColor = true;
            btn4.MouseDown += btn4_MouseDown;
            btn4.MouseMove += btn4_MouseMove;
            btn4.MouseUp += btn4_MouseUp;
            // 
            // btn3
            // 
            btn3.Location = new Point(291, 210);
            btn3.Name = "btn3";
            btn3.Size = new Size(145, 41);
            btn3.TabIndex = 6;
            btn3.Text = "btn3";
            btn3.UseVisualStyleBackColor = true;
            btn3.MouseDown += btn3_MouseDown;
            btn3.MouseMove += btn3_MouseMove;
            btn3.MouseUp += btn3_MouseUp;
            // 
            // checkBtn
            // 
            checkBtn.Location = new Point(662, 179);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(78, 24);
            checkBtn.TabIndex = 8;
            checkBtn.Text = "checkBtn";
            checkBtn.UseVisualStyleBackColor = true;
            checkBtn.Click += checkBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBtn);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(answer4);
            Controls.Add(answer3);
            Controls.Add(answer2);
            Controls.Add(answer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Panel answer1;
        private Panel answer2;
        private Panel answer4;
        private Panel answer3;
        private Button btn2;
        private Button btn4;
        private Button btn3;
        private Button checkBtn;
    }
}
