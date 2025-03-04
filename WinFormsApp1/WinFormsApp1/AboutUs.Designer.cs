namespace WinFormsApp1
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            back_aboutus_bttn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // back_aboutus_bttn
            // 
            back_aboutus_bttn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back_aboutus_bttn.Location = new Point(54, 567);
            back_aboutus_bttn.Name = "back_aboutus_bttn";
            back_aboutus_bttn.Size = new Size(93, 49);
            back_aboutus_bttn.TabIndex = 2;
            back_aboutus_bttn.Text = "Back ";
            back_aboutus_bttn.UseVisualStyleBackColor = true;
            back_aboutus_bttn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(54, 255);
            label1.Name = "label1";
            label1.Size = new Size(1065, 40);
            label1.TabIndex = 3;
            label1.Text = "We are a young group of Engineers, Who are trying to make a positive impact on  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(273, 295);
            label2.Name = "label2";
            label2.Size = new Size(612, 45);
            label2.TabIndex = 4;
            label2.Text = "the world through Engineering Inovations";
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1120, 662);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(back_aboutus_bttn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutUs";
            Load += AboutUs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button back_aboutus_bttn;
        private Label label1;
        private Label label2;
    }
}