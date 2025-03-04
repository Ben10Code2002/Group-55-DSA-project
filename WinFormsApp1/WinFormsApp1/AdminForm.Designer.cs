namespace WinFormsApp1
{
    partial class AdminForm
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
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.BackColor = SystemColors.ActiveBorder;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(610, 123);
            button1.Name = "button1";
            button1.Size = new Size(127, 39);
            button1.TabIndex = 1;
            button1.Text = "Click here";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(125, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(864, 324);
            listBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SWRomnd", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(405, 38);
            label1.Name = "label1";
            label1.Size = new Size(372, 55);
            label1.TabIndex = 3;
            label1.Text = "Administration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(125, 126);
            label2.Name = "label2";
            label2.Size = new Size(452, 34);
            label2.TabIndex = 4;
            label2.Text = "Customer Name List (Alphabetical Order)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(125, 180);
            label3.Name = "label3";
            label3.Size = new Size(469, 34);
            label3.TabIndex = 5;
            label3.Text = "Customers According to Projects Duration ";
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.None;
            button2.BackColor = SystemColors.ActiveBorder;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(610, 180);
            button2.Name = "button2";
            button2.Size = new Size(127, 39);
            button2.TabIndex = 6;
            button2.Text = "Click here";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1022, 38);
            button3.Name = "button3";
            button3.Size = new Size(49, 46);
            button3.TabIndex = 7;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            BackgroundImage = Properties.Resources.istockphoto_1001279256_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1108, 717);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}