namespace WinFormsApp1
{
    partial class DataForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm1));
            Topic_label = new Label();
            Name_Label = new Label();
            Name_Txt_Box = new TextBox();
            department_box = new TextBox();
            Department = new Label();
            label1 = new Label();
            label2 = new Label();
            Project_Name_Label = new Label();
            Project_Name_txt = new TextBox();
            Timeline_label = new Label();
            Project_Start_Date = new TextBox();
            Project_Start_Month = new TextBox();
            Project_Start_Year = new TextBox();
            Project_End_Date = new TextBox();
            Project_End_Month = new TextBox();
            Project_End_Year = new TextBox();
            start_label = new Label();
            end_label = new Label();
            DD_Start_Label = new Label();
            MM_Start_Label = new Label();
            YY_Start_Label = new Label();
            DD_End_Label = new Label();
            MM_End_Label = new Label();
            YY_End_Label = new Label();
            Next_bttn = new Button();
            close_bttn = new Button();
            SuspendLayout();
            // 
            // Topic_label
            // 
            Topic_label.AutoSize = true;
            Topic_label.BackColor = Color.Transparent;
            Topic_label.Font = new Font("Engravers MT", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Topic_label.ForeColor = SystemColors.ButtonFace;
            Topic_label.Location = new Point(221, 48);
            Topic_label.Name = "Topic_label";
            Topic_label.Size = new Size(692, 47);
            Topic_label.TabIndex = 0;
            Topic_label.Text = "Create Your Own Plan";
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.BackColor = Color.Transparent;
            Name_Label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_Label.ForeColor = SystemColors.ButtonHighlight;
            Name_Label.Location = new Point(79, 206);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(89, 36);
            Name_Label.TabIndex = 1;
            Name_Label.Text = "Name";
            // 
            // Name_Txt_Box
            // 
            Name_Txt_Box.BackColor = SystemColors.InactiveCaption;
            Name_Txt_Box.Location = new Point(198, 203);
            Name_Txt_Box.Name = "Name_Txt_Box";
            Name_Txt_Box.Size = new Size(811, 39);
            Name_Txt_Box.TabIndex = 2;
            Name_Txt_Box.TextChanged += Name_Txt_Box_TextChanged;
            // 
            // department_box
            // 
            department_box.BackColor = SystemColors.InactiveCaption;
            department_box.Location = new Point(263, 260);
            department_box.Name = "department_box";
            department_box.Size = new Size(746, 39);
            department_box.TabIndex = 4;
            department_box.TextChanged += department_box_TextChanged;
            // 
            // Department
            // 
            Department.AutoSize = true;
            Department.BackColor = Color.Transparent;
            Department.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Department.ForeColor = SystemColors.ButtonFace;
            Department.Location = new Point(79, 263);
            Department.Name = "Department";
            Department.Size = new Size(163, 36);
            Department.TabIndex = 3;
            Department.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(221, 316);
            label1.Name = "label1";
            label1.Size = new Size(803, 27);
            label1.TabIndex = 5;
            label1.Text = "Electrical - EE , Computer - CSE , Mechanical - ME, Civil - CE , Marine - MENA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(324, 353);
            label2.Name = "label2";
            label2.Size = new Size(447, 27);
            label2.TabIndex = 6;
            label2.Text = "(Enter in the above mentioned abbreviations)";
            // 
            // Project_Name_Label
            // 
            Project_Name_Label.AutoSize = true;
            Project_Name_Label.BackColor = Color.Transparent;
            Project_Name_Label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Project_Name_Label.ForeColor = SystemColors.ButtonHighlight;
            Project_Name_Label.Location = new Point(79, 408);
            Project_Name_Label.Name = "Project_Name_Label";
            Project_Name_Label.Size = new Size(188, 36);
            Project_Name_Label.TabIndex = 7;
            Project_Name_Label.Text = "Project Name";
            // 
            // Project_Name_txt
            // 
            Project_Name_txt.BackColor = SystemColors.InactiveCaption;
            Project_Name_txt.Location = new Point(278, 405);
            Project_Name_txt.Name = "Project_Name_txt";
            Project_Name_txt.Size = new Size(731, 39);
            Project_Name_txt.TabIndex = 8;
            Project_Name_txt.TextChanged += Project_Name_txt_TextChanged;
            // 
            // Timeline_label
            // 
            Timeline_label.AutoSize = true;
            Timeline_label.BackColor = Color.Transparent;
            Timeline_label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Timeline_label.ForeColor = SystemColors.ButtonHighlight;
            Timeline_label.Location = new Point(79, 471);
            Timeline_label.Name = "Timeline_label";
            Timeline_label.Size = new Size(126, 36);
            Timeline_label.TabIndex = 9;
            Timeline_label.Text = "Timeline";
            // 
            // Project_Start_Date
            // 
            Project_Start_Date.BackColor = SystemColors.InactiveCaption;
            Project_Start_Date.Location = new Point(278, 468);
            Project_Start_Date.Name = "Project_Start_Date";
            Project_Start_Date.Size = new Size(123, 39);
            Project_Start_Date.TabIndex = 10;
            Project_Start_Date.TextChanged += Project_Start_Date_TextChanged;
            // 
            // Project_Start_Month
            // 
            Project_Start_Month.BackColor = SystemColors.InactiveCaption;
            Project_Start_Month.Location = new Point(278, 528);
            Project_Start_Month.Name = "Project_Start_Month";
            Project_Start_Month.Size = new Size(123, 39);
            Project_Start_Month.TabIndex = 11;
            Project_Start_Month.TextChanged += Project_Start_Month_TextChanged;
            // 
            // Project_Start_Year
            // 
            Project_Start_Year.BackColor = SystemColors.InactiveCaption;
            Project_Start_Year.Location = new Point(278, 587);
            Project_Start_Year.Name = "Project_Start_Year";
            Project_Start_Year.Size = new Size(123, 39);
            Project_Start_Year.TabIndex = 12;
            Project_Start_Year.TextChanged += Project_Start_Year_TextChanged;
            // 
            // Project_End_Date
            // 
            Project_End_Date.BackColor = SystemColors.InactiveCaption;
            Project_End_Date.Location = new Point(720, 471);
            Project_End_Date.Name = "Project_End_Date";
            Project_End_Date.Size = new Size(123, 39);
            Project_End_Date.TabIndex = 13;
            Project_End_Date.TextChanged += Project_End_Date_TextChanged;
            // 
            // Project_End_Month
            // 
            Project_End_Month.BackColor = SystemColors.InactiveCaption;
            Project_End_Month.Location = new Point(720, 531);
            Project_End_Month.Name = "Project_End_Month";
            Project_End_Month.Size = new Size(123, 39);
            Project_End_Month.TabIndex = 14;
            Project_End_Month.TextChanged += Project_End_Month_TextChanged;
            // 
            // Project_End_Year
            // 
            Project_End_Year.BackColor = SystemColors.InactiveCaption;
            Project_End_Year.Location = new Point(720, 590);
            Project_End_Year.Name = "Project_End_Year";
            Project_End_Year.Size = new Size(123, 39);
            Project_End_Year.TabIndex = 15;
            Project_End_Year.TextChanged += Project_End_Year_TextChanged;
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.BackColor = Color.Transparent;
            start_label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_label.ForeColor = SystemColors.ButtonShadow;
            start_label.Location = new Point(482, 528);
            start_label.Name = "start_label";
            start_label.Size = new Size(76, 36);
            start_label.TabIndex = 16;
            start_label.Text = "Start";
            // 
            // end_label
            // 
            end_label.AutoSize = true;
            end_label.BackColor = Color.Transparent;
            end_label.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            end_label.ForeColor = SystemColors.ButtonHighlight;
            end_label.Location = new Point(922, 528);
            end_label.Name = "end_label";
            end_label.Size = new Size(66, 36);
            end_label.TabIndex = 17;
            end_label.Text = "End";
            // 
            // DD_Start_Label
            // 
            DD_Start_Label.AutoSize = true;
            DD_Start_Label.BackColor = Color.Transparent;
            DD_Start_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DD_Start_Label.ForeColor = SystemColors.Control;
            DD_Start_Label.Location = new Point(407, 471);
            DD_Start_Label.Name = "DD_Start_Label";
            DD_Start_Label.Size = new Size(46, 27);
            DD_Start_Label.TabIndex = 18;
            DD_Start_Label.Text = "DD";
            // 
            // MM_Start_Label
            // 
            MM_Start_Label.AutoSize = true;
            MM_Start_Label.BackColor = Color.Transparent;
            MM_Start_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MM_Start_Label.ForeColor = SystemColors.ButtonHighlight;
            MM_Start_Label.Location = new Point(407, 531);
            MM_Start_Label.Name = "MM_Start_Label";
            MM_Start_Label.Size = new Size(54, 27);
            MM_Start_Label.TabIndex = 19;
            MM_Start_Label.Text = "MM";
            // 
            // YY_Start_Label
            // 
            YY_Start_Label.AutoSize = true;
            YY_Start_Label.BackColor = Color.Transparent;
            YY_Start_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YY_Start_Label.ForeColor = SystemColors.ButtonFace;
            YY_Start_Label.Location = new Point(407, 595);
            YY_Start_Label.Name = "YY_Start_Label";
            YY_Start_Label.Size = new Size(46, 27);
            YY_Start_Label.TabIndex = 20;
            YY_Start_Label.Text = "YY";
            // 
            // DD_End_Label
            // 
            DD_End_Label.AutoSize = true;
            DD_End_Label.BackColor = Color.Transparent;
            DD_End_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DD_End_Label.ForeColor = SystemColors.ButtonHighlight;
            DD_End_Label.Location = new Point(849, 478);
            DD_End_Label.Name = "DD_End_Label";
            DD_End_Label.Size = new Size(46, 27);
            DD_End_Label.TabIndex = 21;
            DD_End_Label.Text = "DD";
            // 
            // MM_End_Label
            // 
            MM_End_Label.AutoSize = true;
            MM_End_Label.BackColor = Color.Transparent;
            MM_End_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MM_End_Label.ForeColor = SystemColors.ButtonFace;
            MM_End_Label.Location = new Point(849, 536);
            MM_End_Label.Name = "MM_End_Label";
            MM_End_Label.Size = new Size(54, 27);
            MM_End_Label.TabIndex = 22;
            MM_End_Label.Text = "MM";
            MM_End_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // YY_End_Label
            // 
            YY_End_Label.AutoSize = true;
            YY_End_Label.BackColor = Color.Transparent;
            YY_End_Label.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            YY_End_Label.ForeColor = SystemColors.ButtonFace;
            YY_End_Label.Location = new Point(849, 595);
            YY_End_Label.Name = "YY_End_Label";
            YY_End_Label.Size = new Size(46, 27);
            YY_End_Label.TabIndex = 23;
            YY_End_Label.Text = "YY";
            // 
            // Next_bttn
            // 
            Next_bttn.BackColor = SystemColors.ActiveCaption;
            Next_bttn.Location = new Point(515, 669);
            Next_bttn.Name = "Next_bttn";
            Next_bttn.Size = new Size(150, 46);
            Next_bttn.TabIndex = 24;
            Next_bttn.Text = "NEXT";
            Next_bttn.UseVisualStyleBackColor = false;
            Next_bttn.Click += Next_bttn_Click;
            // 
            // close_bttn
            // 
            close_bttn.Location = new Point(1029, 25);
            close_bttn.Name = "close_bttn";
            close_bttn.Size = new Size(54, 46);
            close_bttn.TabIndex = 25;
            close_bttn.Text = "X";
            close_bttn.UseVisualStyleBackColor = true;
            close_bttn.Click += close_bttn_Click;
            // 
            // DataForm1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1124, 798);
            Controls.Add(close_bttn);
            Controls.Add(Next_bttn);
            Controls.Add(YY_End_Label);
            Controls.Add(MM_End_Label);
            Controls.Add(DD_End_Label);
            Controls.Add(YY_Start_Label);
            Controls.Add(MM_Start_Label);
            Controls.Add(DD_Start_Label);
            Controls.Add(end_label);
            Controls.Add(start_label);
            Controls.Add(Project_End_Year);
            Controls.Add(Project_End_Month);
            Controls.Add(Project_End_Date);
            Controls.Add(Project_Start_Year);
            Controls.Add(Project_Start_Month);
            Controls.Add(Project_Start_Date);
            Controls.Add(Timeline_label);
            Controls.Add(Project_Name_txt);
            Controls.Add(Project_Name_Label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(department_box);
            Controls.Add(Department);
            Controls.Add(Name_Txt_Box);
            Controls.Add(Name_Label);
            Controls.Add(Topic_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataForm1";
            Load += DataForm1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Topic_label;
        private Label Name_Label;
        private TextBox Name_Txt_Box;
        private TextBox department_box;
        private Label Department;
        private Label label1;
        private Label label2;
        private Label Project_Name_Label;
        private TextBox Project_Name_txt;
        private Label Timeline_label;
        private TextBox Project_Start_Date;
        private TextBox Project_Start_Month;
        private TextBox Project_Start_Year;
        private TextBox Project_End_Date;
        private TextBox Project_End_Month;
        private TextBox Project_End_Year;
        private Label start_label;
        private Label end_label;
        private Label DD_Start_Label;
        private Label MM_Start_Label;
        private Label YY_Start_Label;
        private Label DD_End_Label;
        private Label MM_End_Label;
        private Label YY_End_Label;
        private Button Next_bttn;
        private Button close_bttn;
    }
}