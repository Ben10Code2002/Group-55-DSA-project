namespace WinFormsApp1
{
    partial class DataForm3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm3));
            Sunday_Label = new Label();
            Monday_Label = new Label();
            Tuesday_Label = new Label();
            Wednesday_Label = new Label();
            Thursday_Label = new Label();
            Friday_Label = new Label();
            Saturday_Label = new Label();
            No_Hours_Label = new Label();
            Su_E_C_H = new ComboBox();
            M_E_C_H = new ComboBox();
            Tu_E_C_H = new ComboBox();
            W_E_C_H = new ComboBox();
            Thu_E_C_H = new ComboBox();
            F_E_C_H = new ComboBox();
            Sat_E_C_H = new ComboBox();
            Back_bttn = new Button();
            Next_bttn = new Button();
            Su_S_H = new ComboBox();
            M_S_H = new ComboBox();
            Tu_S_H = new ComboBox();
            W_S_H = new ComboBox();
            Thu_S_H = new ComboBox();
            F_S_H = new ComboBox();
            Sat_S_H = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Sunday_Label
            // 
            Sunday_Label.AutoSize = true;
            Sunday_Label.BackColor = Color.Transparent;
            Sunday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Sunday_Label.ForeColor = SystemColors.ButtonFace;
            Sunday_Label.Location = new Point(59, 203);
            Sunday_Label.Name = "Sunday_Label";
            Sunday_Label.Size = new Size(107, 26);
            Sunday_Label.TabIndex = 1;
            Sunday_Label.Text = "Sunday";
            // 
            // Monday_Label
            // 
            Monday_Label.AutoSize = true;
            Monday_Label.BackColor = Color.Transparent;
            Monday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Monday_Label.ForeColor = SystemColors.ButtonFace;
            Monday_Label.Location = new Point(59, 264);
            Monday_Label.Name = "Monday_Label";
            Monday_Label.Size = new Size(112, 26);
            Monday_Label.TabIndex = 2;
            Monday_Label.Text = "Monday";
            // 
            // Tuesday_Label
            // 
            Tuesday_Label.AutoSize = true;
            Tuesday_Label.BackColor = Color.Transparent;
            Tuesday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Tuesday_Label.ForeColor = SystemColors.ButtonFace;
            Tuesday_Label.Location = new Point(59, 323);
            Tuesday_Label.Name = "Tuesday_Label";
            Tuesday_Label.Size = new Size(123, 26);
            Tuesday_Label.TabIndex = 3;
            Tuesday_Label.Text = "Tuesday";
            // 
            // Wednesday_Label
            // 
            Wednesday_Label.AutoSize = true;
            Wednesday_Label.BackColor = Color.Transparent;
            Wednesday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Wednesday_Label.ForeColor = SystemColors.ButtonFace;
            Wednesday_Label.Location = new Point(59, 391);
            Wednesday_Label.Name = "Wednesday_Label";
            Wednesday_Label.Size = new Size(158, 26);
            Wednesday_Label.TabIndex = 4;
            Wednesday_Label.Text = "Wednesday";
            // 
            // Thursday_Label
            // 
            Thursday_Label.AutoSize = true;
            Thursday_Label.BackColor = Color.Transparent;
            Thursday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Thursday_Label.ForeColor = SystemColors.ButtonFace;
            Thursday_Label.Location = new Point(59, 455);
            Thursday_Label.Name = "Thursday_Label";
            Thursday_Label.Size = new Size(139, 26);
            Thursday_Label.TabIndex = 5;
            Thursday_Label.Text = "Thursday";
            // 
            // Friday_Label
            // 
            Friday_Label.AutoSize = true;
            Friday_Label.BackColor = Color.Transparent;
            Friday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Friday_Label.ForeColor = SystemColors.ButtonFace;
            Friday_Label.Location = new Point(59, 513);
            Friday_Label.Name = "Friday_Label";
            Friday_Label.Size = new Size(100, 26);
            Friday_Label.TabIndex = 6;
            Friday_Label.Text = "Friday";
            // 
            // Saturday_Label
            // 
            Saturday_Label.AutoSize = true;
            Saturday_Label.BackColor = Color.Transparent;
            Saturday_Label.Font = new Font("Algerian", 9F, FontStyle.Bold);
            Saturday_Label.ForeColor = SystemColors.ButtonFace;
            Saturday_Label.Location = new Point(54, 571);
            Saturday_Label.Name = "Saturday_Label";
            Saturday_Label.Size = new Size(142, 26);
            Saturday_Label.TabIndex = 7;
            Saturday_Label.Text = "Saturday";
            // 
            // No_Hours_Label
            // 
            No_Hours_Label.AutoSize = true;
            No_Hours_Label.BackColor = Color.Transparent;
            No_Hours_Label.Font = new Font("Pristina", 20F);
            No_Hours_Label.ForeColor = SystemColors.ButtonFace;
            No_Hours_Label.Location = new Point(297, 36);
            No_Hours_Label.Name = "No_Hours_Label";
            No_Hours_Label.Size = new Size(408, 71);
            No_Hours_Label.TabIndex = 8;
            No_Hours_Label.Text = "No. of Hours per day ";
            // 
            // Su_E_C_H
            // 
            Su_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Su_E_C_H.FormattingEnabled = true;
            Su_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            Su_E_C_H.Location = new Point(239, 195);
            Su_E_C_H.Name = "Su_E_C_H";
            Su_E_C_H.Size = new Size(254, 40);
            Su_E_C_H.TabIndex = 9;
            Su_E_C_H.SelectedIndexChanged += Su_E_C_H_SelectedIndexChanged;
            // 
            // M_E_C_H
            // 
            M_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            M_E_C_H.FormattingEnabled = true;
            M_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            M_E_C_H.Location = new Point(239, 256);
            M_E_C_H.Name = "M_E_C_H";
            M_E_C_H.Size = new Size(254, 40);
            M_E_C_H.TabIndex = 10;
            M_E_C_H.SelectedIndexChanged += M_E_C_H_SelectedIndexChanged;
            // 
            // Tu_E_C_H
            // 
            Tu_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Tu_E_C_H.FormattingEnabled = true;
            Tu_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            Tu_E_C_H.Location = new Point(239, 320);
            Tu_E_C_H.Name = "Tu_E_C_H";
            Tu_E_C_H.Size = new Size(254, 40);
            Tu_E_C_H.TabIndex = 11;
            Tu_E_C_H.SelectedIndexChanged += Tu_E_C_H_SelectedIndexChanged;
            // 
            // W_E_C_H
            // 
            W_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            W_E_C_H.FormattingEnabled = true;
            W_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            W_E_C_H.Location = new Point(239, 383);
            W_E_C_H.Name = "W_E_C_H";
            W_E_C_H.Size = new Size(254, 40);
            W_E_C_H.TabIndex = 12;
            W_E_C_H.SelectedIndexChanged += W_E_C_H_SelectedIndexChanged;
            // 
            // Thu_E_C_H
            // 
            Thu_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Thu_E_C_H.FormattingEnabled = true;
            Thu_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            Thu_E_C_H.Location = new Point(239, 447);
            Thu_E_C_H.Name = "Thu_E_C_H";
            Thu_E_C_H.Size = new Size(254, 40);
            Thu_E_C_H.TabIndex = 13;
            Thu_E_C_H.SelectedIndexChanged += Thu_E_C_H_SelectedIndexChanged;
            // 
            // F_E_C_H
            // 
            F_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            F_E_C_H.FormattingEnabled = true;
            F_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            F_E_C_H.Location = new Point(239, 505);
            F_E_C_H.Name = "F_E_C_H";
            F_E_C_H.Size = new Size(254, 40);
            F_E_C_H.TabIndex = 14;
            F_E_C_H.SelectedIndexChanged += F_E_C_H_SelectedIndexChanged;
            // 
            // Sat_E_C_H
            // 
            Sat_E_C_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Sat_E_C_H.FormattingEnabled = true;
            Sat_E_C_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9" });
            Sat_E_C_H.Location = new Point(239, 568);
            Sat_E_C_H.Name = "Sat_E_C_H";
            Sat_E_C_H.Size = new Size(254, 40);
            Sat_E_C_H.TabIndex = 15;
            Sat_E_C_H.SelectedIndexChanged += Sat_E_C_H_SelectedIndexChanged;
            // 
            // Back_bttn
            // 
            Back_bttn.Location = new Point(41, 680);
            Back_bttn.Name = "Back_bttn";
            Back_bttn.Size = new Size(150, 46);
            Back_bttn.TabIndex = 16;
            Back_bttn.Text = "Back";
            Back_bttn.UseVisualStyleBackColor = true;
            Back_bttn.Click += button1_Click;
            // 
            // Next_bttn
            // 
            Next_bttn.Location = new Point(731, 680);
            Next_bttn.Name = "Next_bttn";
            Next_bttn.Size = new Size(150, 46);
            Next_bttn.TabIndex = 17;
            Next_bttn.Text = "Next";
            Next_bttn.UseVisualStyleBackColor = true;
            Next_bttn.Click += button2_Click;
            // 
            // Su_S_H
            // 
            Su_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Su_S_H.FormattingEnabled = true;
            Su_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Su_S_H.Location = new Point(549, 198);
            Su_S_H.Name = "Su_S_H";
            Su_S_H.Size = new Size(242, 40);
            Su_S_H.TabIndex = 19;
            Su_S_H.SelectedIndexChanged += Su_S_H_SelectedIndexChanged;
            // 
            // M_S_H
            // 
            M_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            M_S_H.FormattingEnabled = true;
            M_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            M_S_H.Location = new Point(549, 259);
            M_S_H.Name = "M_S_H";
            M_S_H.Size = new Size(242, 40);
            M_S_H.TabIndex = 20;
            M_S_H.SelectedIndexChanged += M_S_H_SelectedIndexChanged;
            // 
            // Tu_S_H
            // 
            Tu_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Tu_S_H.FormattingEnabled = true;
            Tu_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Tu_S_H.Location = new Point(549, 323);
            Tu_S_H.Name = "Tu_S_H";
            Tu_S_H.Size = new Size(242, 40);
            Tu_S_H.TabIndex = 21;
            Tu_S_H.SelectedIndexChanged += Tu_S_H_SelectedIndexChanged;
            // 
            // W_S_H
            // 
            W_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            W_S_H.FormattingEnabled = true;
            W_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            W_S_H.Location = new Point(549, 386);
            W_S_H.Name = "W_S_H";
            W_S_H.Size = new Size(242, 40);
            W_S_H.TabIndex = 22;
            W_S_H.SelectedIndexChanged += W_S_H_SelectedIndexChanged;
            // 
            // Thu_S_H
            // 
            Thu_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Thu_S_H.FormattingEnabled = true;
            Thu_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Thu_S_H.Location = new Point(549, 447);
            Thu_S_H.Name = "Thu_S_H";
            Thu_S_H.Size = new Size(242, 40);
            Thu_S_H.TabIndex = 23;
            Thu_S_H.SelectedIndexChanged += Thu_S_H_SelectedIndexChanged;
            // 
            // F_S_H
            // 
            F_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            F_S_H.FormattingEnabled = true;
            F_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            F_S_H.Location = new Point(549, 508);
            F_S_H.Name = "F_S_H";
            F_S_H.Size = new Size(242, 40);
            F_S_H.TabIndex = 24;
            F_S_H.SelectedIndexChanged += F_S_H_SelectedIndexChanged;
            // 
            // Sat_S_H
            // 
            Sat_S_H.DropDownStyle = ComboBoxStyle.DropDownList;
            Sat_S_H.FormattingEnabled = true;
            Sat_S_H.Items.AddRange(new object[] { "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            Sat_S_H.Location = new Point(549, 568);
            Sat_S_H.Name = "Sat_S_H";
            Sat_S_H.Size = new Size(242, 40);
            Sat_S_H.TabIndex = 25;
            Sat_S_H.SelectedIndexChanged += Sat_S_H_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(239, 136);
            label1.Name = "label1";
            label1.Size = new Size(254, 26);
            label1.TabIndex = 27;
            label1.Text = "Extra Curricular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(614, 136);
            label2.Name = "label2";
            label2.Size = new Size(113, 26);
            label2.TabIndex = 28;
            label2.Text = "Resting";
            // 
            // DataForm3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 752);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Sat_S_H);
            Controls.Add(F_S_H);
            Controls.Add(Thu_S_H);
            Controls.Add(W_S_H);
            Controls.Add(Tu_S_H);
            Controls.Add(M_S_H);
            Controls.Add(Su_S_H);
            Controls.Add(Next_bttn);
            Controls.Add(Back_bttn);
            Controls.Add(Sat_E_C_H);
            Controls.Add(F_E_C_H);
            Controls.Add(Thu_E_C_H);
            Controls.Add(W_E_C_H);
            Controls.Add(Tu_E_C_H);
            Controls.Add(M_E_C_H);
            Controls.Add(Su_E_C_H);
            Controls.Add(No_Hours_Label);
            Controls.Add(Saturday_Label);
            Controls.Add(Friday_Label);
            Controls.Add(Thursday_Label);
            Controls.Add(Wednesday_Label);
            Controls.Add(Tuesday_Label);
            Controls.Add(Monday_Label);
            Controls.Add(Sunday_Label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataForm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm3";
            Load += DataForm3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Sunday_Label;
        private Label Monday_Label;
        private Label Tuesday_Label;
        private Label Wednesday_Label;
        private Label Thursday_Label;
        private Label Friday_Label;
        private Label Saturday_Label;
        private Label No_Hours_Label;
        private ComboBox Su_E_C_H;
        private ComboBox M_E_C_H;
        private ComboBox Tu_E_C_H;
        private ComboBox W_E_C_H;
        private ComboBox Thu_E_C_H;
        private ComboBox F_E_C_H;
        private ComboBox Sat_E_C_H;
        private Button Back_bttn;
        private Button Next_bttn;
        private ComboBox Su_S_H;
        private ComboBox M_S_H;
        private ComboBox Tu_S_H;
        private ComboBox W_S_H;
        private ComboBox Thu_S_H;
        private ComboBox F_S_H;
        private ComboBox Sat_S_H;
        private Label label1;
        private Label label2;
    }
}