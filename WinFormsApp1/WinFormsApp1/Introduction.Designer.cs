namespace WinFormsApp1
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            Topic_Intro = new Label();
            About_Us_Link_bttn = new Button();
            Lets_Go_Link_bttn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Topic_Intro
            // 
            Topic_Intro.AutoSize = true;
            Topic_Intro.BackColor = Color.Transparent;
            Topic_Intro.Font = new Font("Times New Roman", 20F);
            Topic_Intro.ForeColor = Color.LightGray;
            Topic_Intro.Location = new Point(99, 50);
            Topic_Intro.Name = "Topic_Intro";
            Topic_Intro.Size = new Size(847, 61);
            Topic_Intro.TabIndex = 0;
            Topic_Intro.Text = "Welcome to ESP management System";
            Topic_Intro.Click += label1_Click;
            // 
            // About_Us_Link_bttn
            // 
            About_Us_Link_bttn.Font = new Font("Arial Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            About_Us_Link_bttn.Location = new Point(99, 515);
            About_Us_Link_bttn.Name = "About_Us_Link_bttn";
            About_Us_Link_bttn.Size = new Size(167, 53);
            About_Us_Link_bttn.TabIndex = 3;
            About_Us_Link_bttn.Text = "About Us";
            About_Us_Link_bttn.UseVisualStyleBackColor = true;
            About_Us_Link_bttn.Click += button1_Click;
            // 
            // Lets_Go_Link_bttn
            // 
            Lets_Go_Link_bttn.Font = new Font("Arial Black", 9F);
            Lets_Go_Link_bttn.Location = new Point(799, 516);
            Lets_Go_Link_bttn.Name = "Lets_Go_Link_bttn";
            Lets_Go_Link_bttn.Size = new Size(147, 52);
            Lets_Go_Link_bttn.TabIndex = 4;
            Lets_Go_Link_bttn.Text = "Lets Go!";
            Lets_Go_Link_bttn.UseVisualStyleBackColor = true;
            Lets_Go_Link_bttn.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(189, 242);
            label1.Name = "label1";
            label1.Size = new Size(683, 37);
            label1.TabIndex = 5;
            label1.Text = "\"Knowledge is no value, unless you put it into practice\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(411, 328);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 6;
            label2.Text = "~Anton Chekov~";
            label2.Click += label2_Click;
            // 
            // Introduction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 639);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lets_Go_Link_bttn);
            Controls.Add(About_Us_Link_bttn);
            Controls.Add(Topic_Intro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Introduction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Introduction";
            Load += Introduction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Topic_Intro;
        private Button About_Us_Link_bttn;
        private Button Lets_Go_Link_bttn;
        private Label label1;
        private Label label2;
    }
}