namespace WinFormsApp1
{
    partial class GroupData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupData));
            label1 = new Label();
            radioButton1 = new RadioButton();
            label2 = new Label();
            radioButton2 = new RadioButton();
            label3 = new Label();
            member_name = new TextBox();
            label4 = new Label();
            Member_Add_Button = new Button();
            members_listBox = new ListBox();
            AbOrder = new Button();
            next_bttn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 18F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(390, 35);
            label1.Name = "label1";
            label1.Size = new Size(330, 54);
            label1.TabIndex = 0;
            label1.Text = "Group Details";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Times New Roman", 10F);
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(124, 206);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(155, 35);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Individual";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 148);
            label2.Name = "label2";
            label2.Size = new Size(474, 36);
            label2.TabIndex = 2;
            label2.Text = "Is your project Individual or Group?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Times New Roman", 10F);
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(124, 259);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 35);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Group";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(67, 346);
            label3.Name = "label3";
            label3.Size = new Size(390, 36);
            label3.TabIndex = 4;
            label3.Text = "If your project is Group (Fill)";
            // 
            // member_name
            // 
            member_name.BackColor = Color.Azure;
            member_name.Location = new Point(241, 428);
            member_name.Name = "member_name";
            member_name.Size = new Size(672, 39);
            member_name.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(58, 431);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 6;
            label4.Text = "Add Members";
            // 
            // Member_Add_Button
            // 
            Member_Add_Button.Location = new Point(931, 424);
            Member_Add_Button.Name = "Member_Add_Button";
            Member_Add_Button.Size = new Size(47, 46);
            Member_Add_Button.TabIndex = 7;
            Member_Add_Button.Text = "+";
            Member_Add_Button.UseVisualStyleBackColor = true;
            Member_Add_Button.Click += Member_Add_Button_Click;
            // 
            // members_listBox
            // 
            members_listBox.FormattingEnabled = true;
            members_listBox.Location = new Point(243, 489);
            members_listBox.Name = "members_listBox";
            members_listBox.Size = new Size(670, 100);
            members_listBox.TabIndex = 8;
            // 
            // AbOrder
            // 
            AbOrder.BackColor = SystemColors.ActiveCaptionText;
            AbOrder.ForeColor = SystemColors.ButtonFace;
            AbOrder.Location = new Point(312, 605);
            AbOrder.Name = "AbOrder";
            AbOrder.Size = new Size(554, 46);
            AbOrder.TabIndex = 9;
            AbOrder.Text = "Press To arrange in Alphebatical Order";
            AbOrder.UseVisualStyleBackColor = false;
            AbOrder.Click += AbOrder_Click;
            // 
            // next_bttn
            // 
            next_bttn.Location = new Point(842, 691);
            next_bttn.Name = "next_bttn";
            next_bttn.Size = new Size(150, 46);
            next_bttn.TabIndex = 10;
            next_bttn.Text = "Next";
            next_bttn.UseVisualStyleBackColor = true;
            next_bttn.Click += next_bttn_Click;
            // 
            // GroupData
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1023, 749);
            Controls.Add(next_bttn);
            Controls.Add(AbOrder);
            Controls.Add(members_listBox);
            Controls.Add(Member_Add_Button);
            Controls.Add(label4);
            Controls.Add(member_name);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(label2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GroupData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GroupData";
            Load += GroupData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private Label label2;
        private RadioButton radioButton2;
        private Label label3;
        private TextBox member_name;
        private Label label4;
        private Button Member_Add_Button;
        private ListBox members_listBox;
        private Button AbOrder;
        private Button next_bttn;
    }
}