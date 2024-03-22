namespace quiz
{
    partial class Quiz
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            questionsTab = new TabControl();
            button1 = new Button();
            pointsLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(683, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Pontok:";
            // 
            // questionsTab
            // 
            questionsTab.Location = new Point(23, 23);
            questionsTab.Name = "questionsTab";
            questionsTab.SelectedIndex = 0;
            questionsTab.Size = new Size(580, 360);
            questionsTab.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(488, 389);
            button1.Name = "button1";
            button1.Size = new Size(111, 40);
            button1.TabIndex = 2;
            button1.Text = "Következő";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pointsLbl
            // 
            pointsLbl.AutoSize = true;
            pointsLbl.Location = new Point(729, 9);
            pointsLbl.Name = "pointsLbl";
            pointsLbl.Size = new Size(13, 15);
            pointsLbl.TabIndex = 3;
            pointsLbl.Text = "0";
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pointsLbl);
            Controls.Add(button1);
            Controls.Add(questionsTab);
            Controls.Add(label1);
            Name = "Quiz";
            Text = "Quiz";
            Load += Quiz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl questionsTab;
        private Button button1;
        private Label pointsLbl;
    }
}