namespace WinFormsApp1
{
    partial class ResultsAnz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsAnz));
            Analyze_bttn = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // Analyze_bttn
            // 
            Analyze_bttn.BackColor = SystemColors.InactiveCaption;
            Analyze_bttn.Font = new Font("Algerian", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Analyze_bttn.Location = new Point(269, 309);
            Analyze_bttn.Name = "Analyze_bttn";
            Analyze_bttn.Size = new Size(376, 62);
            Analyze_bttn.TabIndex = 0;
            Analyze_bttn.Text = "Start to Analyze";
            Analyze_bttn.UseVisualStyleBackColor = false;
            Analyze_bttn.Click += Analyze_bttn_Click;
            // 
            // ResultsAnz
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(942, 736);
            Controls.Add(Analyze_bttn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsAnz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultsAnz";
            Load += ResultsAnz_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Analyze_bttn;
        private ColorDialog colorDialog1;
    }
}