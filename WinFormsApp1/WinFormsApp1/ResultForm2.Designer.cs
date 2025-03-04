namespace WinFormsApp1
{
    partial class ResultForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm2));
            label1 = new Label();
            listboxOutput1 = new ListBox();
            label2 = new Label();
            listBoxOutput2 = new ListBox();
            label3 = new Label();
            button1 = new Button();
            SearchByDateComboBox = new ComboBox();
            listBoxOutput3 = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 9F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(71, 134);
            label1.Name = "label1";
            label1.Size = new Size(317, 26);
            label1.TabIndex = 0;
            label1.Text = "Extra Curricular Hours";
            // 
            // listboxOutput1
            // 
            listboxOutput1.BackColor = SystemColors.ScrollBar;
            listboxOutput1.FormattingEnabled = true;
            listboxOutput1.Location = new Point(71, 172);
            listboxOutput1.Name = "listboxOutput1";
            listboxOutput1.Size = new Size(317, 132);
            listboxOutput1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 9F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(492, 134);
            label2.Name = "label2";
            label2.Size = new Size(198, 26);
            label2.TabIndex = 2;
            label2.Text = "Sleeping Hours";
            // 
            // listBoxOutput2
            // 
            listBoxOutput2.BackColor = SystemColors.ScrollBar;
            listBoxOutput2.FormattingEnabled = true;
            listBoxOutput2.Location = new Point(492, 172);
            listBoxOutput2.Name = "listBoxOutput2";
            listBoxOutput2.Size = new Size(318, 132);
            listBoxOutput2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Algerian", 9F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(71, 398);
            label3.Name = "label3";
            label3.Size = new Size(415, 26);
            label3.TabIndex = 4;
            label3.Text = "Search Your Free hours by date";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(71, 40);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SearchByDateComboBox
            // 
            SearchByDateComboBox.FormattingEnabled = true;
            SearchByDateComboBox.Items.AddRange(new object[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            SearchByDateComboBox.Location = new Point(71, 439);
            SearchByDateComboBox.Name = "SearchByDateComboBox";
            SearchByDateComboBox.Size = new Size(415, 40);
            SearchByDateComboBox.TabIndex = 6;
            SearchByDateComboBox.SelectedIndexChanged += SearchByDateComboBox_SelectedIndexChanged;
            // 
            // listBoxOutput3
            // 
            listBoxOutput3.BackColor = SystemColors.InactiveCaption;
            listBoxOutput3.FormattingEnabled = true;
            listBoxOutput3.Location = new Point(71, 495);
            listBoxOutput3.Name = "listBoxOutput3";
            listBoxOutput3.Size = new Size(415, 68);
            listBoxOutput3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(795, 581);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ResultForm2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 654);
            Controls.Add(button2);
            Controls.Add(listBoxOutput3);
            Controls.Add(SearchByDateComboBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBoxOutput2);
            Controls.Add(label2);
            Controls.Add(listboxOutput1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultForm2";
            Load += ResultForm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listboxOutput1;
        private Label label2;
        private ListBox listBoxOutput2;
        private Label label3;
        private Button button1;
        private ComboBox SearchByDateComboBox;
        private ListBox listBoxOutput3;
        private Button button2;
    }
}