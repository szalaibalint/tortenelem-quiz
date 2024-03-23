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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            label1 = new Label();
            questionsTab = new TabControl();
            button1 = new Button();
            pointsLbl = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 0;
            label1.Text = "Pontok: 0";
            // 
            // questionsTab
            // 
            questionsTab.Location = new Point(23, 23);
            questionsTab.Margin = new Padding(0);
            questionsTab.Name = "questionsTab";
            questionsTab.Padding = new Point(0, 0);
            questionsTab.SelectedIndex = 0;
            questionsTab.Size = new Size(570, 350);
            questionsTab.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(73, 323);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 2;
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
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(609, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 450);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Location = new Point(22, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 10);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Location = new Point(22, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(576, 12);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Location = new Point(22, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 352);
            panel4.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Location = new Point(588, 23);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 352);
            panel5.TabIndex = 7;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pointsLbl);
            Controls.Add(questionsTab);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            Load += Quiz_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl questionsTab;
        private Button button1;
        private Label pointsLbl;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}