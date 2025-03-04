namespace WinFormsApp1
{
    partial class ResultForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm1));
            start_bttn = new Button();
            lstOutput = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lsOutput2 = new ListBox();
            label3 = new Label();
            lsOutput3 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // start_bttn
            // 
            start_bttn.BackColor = SystemColors.ActiveCaptionText;
            start_bttn.ForeColor = Color.WhiteSmoke;
            start_bttn.Location = new Point(88, 35);
            start_bttn.Name = "start_bttn";
            start_bttn.Size = new Size(183, 46);
            start_bttn.TabIndex = 0;
            start_bttn.Text = "Start";
            start_bttn.UseVisualStyleBackColor = false;
            start_bttn.Click += start_bttn_Click;
            // 
            // lstOutput
            // 
            lstOutput.BackColor = SystemColors.ControlDark;
            lstOutput.BorderStyle = BorderStyle.FixedSingle;
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(88, 140);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(324, 514);
            lstOutput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Romantic", 9F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(88, 98);
            label1.Name = "label1";
            label1.Size = new Size(324, 27);
            label1.TabIndex = 2;
            label1.Text = "Daily Academic Time Schedule";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Romantic", 9F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(471, 98);
            label2.Name = "label2";
            label2.Size = new Size(308, 27);
            label2.TabIndex = 3;
            label2.Text = "Free hours (Academic) Perday";
            // 
            // lsOutput2
            // 
            lsOutput2.BackColor = SystemColors.InactiveCaption;
            lsOutput2.BorderStyle = BorderStyle.FixedSingle;
            lsOutput2.FormattingEnabled = true;
            lsOutput2.Location = new Point(471, 140);
            lsOutput2.Name = "lsOutput2";
            lsOutput2.Size = new Size(331, 226);
            lsOutput2.TabIndex = 4;
            lsOutput2.SelectedIndexChanged += lsOutput2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Romantic", 9F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(471, 386);
            label3.Name = "label3";
            label3.Size = new Size(314, 27);
            label3.TabIndex = 5;
            label3.Text = "Busy hours (Academic) Perday";
            // 
            // lsOutput3
            // 
            lsOutput3.BackColor = SystemColors.InactiveCaption;
            lsOutput3.BorderStyle = BorderStyle.FixedSingle;
            lsOutput3.FormattingEnabled = true;
            lsOutput3.Location = new Point(471, 427);
            lsOutput3.Name = "lsOutput3";
            lsOutput3.Size = new Size(331, 226);
            lsOutput3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(992, 628);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "NEXT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ResultForm1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1163, 703);
            Controls.Add(button1);
            Controls.Add(lsOutput3);
            Controls.Add(label3);
            Controls.Add(lsOutput2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstOutput);
            Controls.Add(start_bttn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultForm1";
            Load += ResultForm1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start_bttn;
        private ListBox lstOutput;
        private Label label1;
        private Label label2;
        private ListBox lsOutput2;
        private Label label3;
        private ListBox lsOutput3;
        private Button button1;
    }
}