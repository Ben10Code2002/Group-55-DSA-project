namespace WinFormsApp1
{
    partial class ResultForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm3));
            NameOut_listbox = new ListBox();
            ProjectOut_listbox = new ListBox();
            startDateOut_listbox = new ListBox();
            endDateOut_listbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            departmentOut_listbox = new ListBox();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            next_bttn = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // NameOut_listbox
            // 
            NameOut_listbox.Font = new Font("Times New Roman", 10.875F);
            NameOut_listbox.FormattingEnabled = true;
            NameOut_listbox.ItemHeight = 33;
            NameOut_listbox.Location = new Point(263, 50);
            NameOut_listbox.Margin = new Padding(3, 2, 3, 2);
            NameOut_listbox.Name = "NameOut_listbox";
            NameOut_listbox.Size = new Size(869, 37);
            NameOut_listbox.TabIndex = 0;
            NameOut_listbox.SelectedIndexChanged += NameOut_listbox_SelectedIndexChanged;
            // 
            // ProjectOut_listbox
            // 
            ProjectOut_listbox.Font = new Font("Times New Roman", 10.875F);
            ProjectOut_listbox.FormattingEnabled = true;
            ProjectOut_listbox.ItemHeight = 33;
            ProjectOut_listbox.Location = new Point(263, 110);
            ProjectOut_listbox.Margin = new Padding(3, 2, 3, 2);
            ProjectOut_listbox.Name = "ProjectOut_listbox";
            ProjectOut_listbox.Size = new Size(869, 37);
            ProjectOut_listbox.TabIndex = 1;
            ProjectOut_listbox.SelectedIndexChanged += ProjectOut_listbox_SelectedIndexChanged;
            // 
            // startDateOut_listbox
            // 
            startDateOut_listbox.Font = new Font("Times New Roman", 10.875F);
            startDateOut_listbox.FormattingEnabled = true;
            startDateOut_listbox.ItemHeight = 33;
            startDateOut_listbox.Location = new Point(263, 166);
            startDateOut_listbox.Margin = new Padding(3, 2, 3, 2);
            startDateOut_listbox.Name = "startDateOut_listbox";
            startDateOut_listbox.Size = new Size(869, 37);
            startDateOut_listbox.TabIndex = 2;
            startDateOut_listbox.SelectedIndexChanged += startDateOut_listbox_SelectedIndexChanged;
            // 
            // endDateOut_listbox
            // 
            endDateOut_listbox.Font = new Font("Times New Roman", 10.875F);
            endDateOut_listbox.FormattingEnabled = true;
            endDateOut_listbox.ItemHeight = 33;
            endDateOut_listbox.Location = new Point(263, 224);
            endDateOut_listbox.Margin = new Padding(3, 2, 3, 2);
            endDateOut_listbox.Name = "endDateOut_listbox";
            endDateOut_listbox.Size = new Size(869, 37);
            endDateOut_listbox.TabIndex = 3;
            endDateOut_listbox.SelectedIndexChanged += endDateOut_listbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.875F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(66, 50);
            label1.Name = "label1";
            label1.Size = new Size(83, 33);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.875F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(66, 110);
            label2.Name = "label2";
            label2.Size = new Size(95, 33);
            label2.TabIndex = 5;
            label2.Text = "Project";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.875F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(66, 169);
            label3.Name = "label3";
            label3.Size = new Size(129, 33);
            label3.TabIndex = 6;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.875F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(66, 224);
            label4.Name = "label4";
            label4.Size = new Size(122, 33);
            label4.TabIndex = 7;
            label4.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 10.875F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(60, 395);
            label5.Name = "label5";
            label5.Size = new Size(284, 33);
            label5.TabIndex = 8;
            label5.Text = "Enter your project ideas";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 10.875F);
            textBox1.Location = new Point(58, 436);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(996, 41);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.875F);
            button1.Location = new Point(1073, 436);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(59, 41);
            button1.TabIndex = 10;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 10.875F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(66, 276);
            label6.Name = "label6";
            label6.Size = new Size(149, 33);
            label6.TabIndex = 11;
            label6.Text = "Department";
            // 
            // departmentOut_listbox
            // 
            departmentOut_listbox.Font = new Font("Times New Roman", 10.875F);
            departmentOut_listbox.FormattingEnabled = true;
            departmentOut_listbox.ItemHeight = 33;
            departmentOut_listbox.Location = new Point(263, 276);
            departmentOut_listbox.Margin = new Padding(3, 2, 3, 2);
            departmentOut_listbox.Name = "departmentOut_listbox";
            departmentOut_listbox.Size = new Size(869, 37);
            departmentOut_listbox.TabIndex = 12;
            departmentOut_listbox.SelectedIndexChanged += departmentOut_listbox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Brown;
            label7.Font = new Font("Times New Roman", 10.875F);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(29, 24);
            label7.Name = "label7";
            label7.Size = new Size(0, 33);
            label7.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Times New Roman", 10.875F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(985, 339);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 14;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 10.875F);
            button3.Location = new Point(1071, 504);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(61, 41);
            button3.TabIndex = 16;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.Font = new Font("Times New Roman", 10.875F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 33;
            listBox1.Location = new Point(58, 504);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1001, 70);
            listBox1.TabIndex = 17;
            // 
            // next_bttn
            // 
            next_bttn.BackColor = SystemColors.ActiveCaptionText;
            next_bttn.Font = new Font("Times New Roman", 10.875F);
            next_bttn.ForeColor = SystemColors.ButtonHighlight;
            next_bttn.Location = new Point(1045, 613);
            next_bttn.Margin = new Padding(3, 2, 3, 2);
            next_bttn.Name = "next_bttn";
            next_bttn.Size = new Size(143, 46);
            next_bttn.TabIndex = 18;
            next_bttn.Text = "Next";
            next_bttn.UseVisualStyleBackColor = false;
            next_bttn.Click += next_bttn_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(53, 603);
            button4.Name = "button4";
            button4.Size = new Size(408, 46);
            button4.TabIndex = 19;
            button4.Text = "Sort Ideas Alphabetically";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ResultForm3
            // 
            AutoScaleDimensions = new SizeF(15F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1250, 685);
            Controls.Add(button4);
            Controls.Add(next_bttn);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(departmentOut_listbox);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDateOut_listbox);
            Controls.Add(startDateOut_listbox);
            Controls.Add(ProjectOut_listbox);
            Controls.Add(NameOut_listbox);
            Font = new Font("Algerian", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ResultForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultForm3";
            Load += ResultForm3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox NameOut_listbox;
        private ListBox ProjectOut_listbox;
        private ListBox startDateOut_listbox;
        private ListBox endDateOut_listbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Label label6;
        private ListBox departmentOut_listbox;
        private Label label7;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button next_bttn;
        private Button button4;
    }
}