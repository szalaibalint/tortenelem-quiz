namespace quiz
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(541, 86);
            label1.TabIndex = 0;
            label1.Text = "Történelem Quiz";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(224, 192);
            button1.Name = "button1";
            button1.Size = new Size(65, 65);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10", "20", "30", "40", "50" });
            comboBox1.Location = new Point(197, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(197, 122);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "Kérdések száma";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(541, 269);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(557, 308);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            MinimumSize = new Size(557, 308);
            Name = "mainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tortenelem-quiz";
            Load += mainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
    }
}
