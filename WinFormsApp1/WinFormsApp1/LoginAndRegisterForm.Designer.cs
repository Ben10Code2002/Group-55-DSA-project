using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace WinFormsApp1
{
    
    partial class LoginAndRegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginAndRegisterForm));
            MainSignUp = new Button();
            ESP_txt = new Label();
            MainSignIn = new Button();
            CopyRights_txt = new Label();
            FirstName_Sign_Up = new TextBox();
            LastName_Sign_Up = new TextBox();
            BigSignUp = new Button();
            panel1_SignIn = new Panel();
            FirstName_txt = new Label();
            Confirm_pw_signup = new Label();
            Pw_Sign_Up_txt = new Label();
            Username_txt_signup = new Label();
            Lastname_txt = new Label();
            ConfirmPW_Sign_Up = new TextBox();
            PW_SignUp = new TextBox();
            UserName_Sign_Up = new TextBox();
            panel2_SignUp = new Panel();
            pw_txt_login = new Label();
            Username_txt_login = new Label();
            UPWlogin = new TextBox();
            UNameLogIn = new TextBox();
            BigSignIn = new Button();
            label1 = new Label();
            Management_txt = new Label();
            Close_Button = new PictureBox();
            Clear = new Button();
            ShowPW = new CheckBox();
            panel1_SignIn.SuspendLayout();
            panel2_SignUp.SuspendLayout();
            ((ISupportInitialize)Close_Button).BeginInit();
            SuspendLayout();
            // 
            // MainSignUp
            // 
            MainSignUp.BackColor = SystemColors.ActiveCaption;
            MainSignUp.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainSignUp.Location = new Point(773, 34);
            MainSignUp.Name = "MainSignUp";
            MainSignUp.Size = new Size(129, 58);
            MainSignUp.TabIndex = 0;
            MainSignUp.Text = "Sign Up";
            MainSignUp.UseVisualStyleBackColor = false;
            MainSignUp.Click += MainSignUp_Click;
            // 
            // ESP_txt
            // 
            ESP_txt.AutoSize = true;
            ESP_txt.BackColor = Color.Transparent;
            ESP_txt.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            ESP_txt.ForeColor = SystemColors.MenuText;
            ESP_txt.Location = new Point(307, 132);
            ESP_txt.Name = "ESP_txt";
            ESP_txt.Size = new Size(483, 43);
            ESP_txt.TabIndex = 1;
            ESP_txt.Text = "Engineering Student Project";
            // 
            // MainSignIn
            // 
            MainSignIn.BackColor = SystemColors.ActiveCaption;
            MainSignIn.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainSignIn.Location = new Point(640, 34);
            MainSignIn.Name = "MainSignIn";
            MainSignIn.Size = new Size(115, 58);
            MainSignIn.TabIndex = 2;
            MainSignIn.Text = "Sign In";
            MainSignIn.UseVisualStyleBackColor = false;
            MainSignIn.Click += MainSignIn_Click;
            // 
            // CopyRights_txt
            // 
            CopyRights_txt.AutoSize = true;
            CopyRights_txt.BackColor = Color.Transparent;
            CopyRights_txt.Font = new Font("Stencil", 6F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CopyRights_txt.ForeColor = SystemColors.ButtonFace;
            CopyRights_txt.Location = new Point(827, 814);
            CopyRights_txt.Name = "CopyRights_txt";
            CopyRights_txt.Size = new Size(188, 19);
            CopyRights_txt.TabIndex = 3;
            CopyRights_txt.Text = "@copyrights reseved";
            // 
            // FirstName_Sign_Up
            // 
            FirstName_Sign_Up.BackColor = SystemColors.InactiveCaption;
            FirstName_Sign_Up.Location = new Point(293, 31);
            FirstName_Sign_Up.Name = "FirstName_Sign_Up";
            FirstName_Sign_Up.Size = new Size(619, 39);
            FirstName_Sign_Up.TabIndex = 16;
            FirstName_Sign_Up.TextChanged += FirstName_TextChanged;
            // 
            // LastName_Sign_Up
            // 
            LastName_Sign_Up.BackColor = SystemColors.InactiveCaption;
            LastName_Sign_Up.Location = new Point(293, 95);
            LastName_Sign_Up.Name = "LastName_Sign_Up";
            LastName_Sign_Up.Size = new Size(619, 39);
            LastName_Sign_Up.TabIndex = 15;
            LastName_Sign_Up.TextChanged += LastName_TextChanged;
            // 
            // BigSignUp
            // 
            BigSignUp.BackColor = SystemColors.ActiveCaption;
            BigSignUp.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BigSignUp.Location = new Point(448, 378);
            BigSignUp.Name = "BigSignUp";
            BigSignUp.Size = new Size(189, 50);
            BigSignUp.TabIndex = 8;
            BigSignUp.Text = "Sign Up";
            BigSignUp.UseVisualStyleBackColor = false;
            BigSignUp.Click += BigSignUp_Click;
            // 
            // panel1_SignIn
            // 
            panel1_SignIn.BackColor = Color.Transparent;
            panel1_SignIn.Controls.Add(FirstName_Sign_Up);
            panel1_SignIn.Controls.Add(FirstName_txt);
            panel1_SignIn.Controls.Add(Confirm_pw_signup);
            panel1_SignIn.Controls.Add(Pw_Sign_Up_txt);
            panel1_SignIn.Controls.Add(Username_txt_signup);
            panel1_SignIn.Controls.Add(Lastname_txt);
            panel1_SignIn.Controls.Add(ConfirmPW_Sign_Up);
            panel1_SignIn.Controls.Add(PW_SignUp);
            panel1_SignIn.Controls.Add(LastName_Sign_Up);
            panel1_SignIn.Controls.Add(UserName_Sign_Up);
            panel1_SignIn.Controls.Add(BigSignUp);
            panel1_SignIn.Location = new Point(12, 235);
            panel1_SignIn.Name = "panel1_SignIn";
            panel1_SignIn.Size = new Size(1107, 512);
            panel1_SignIn.TabIndex = 9;
            // 
            // FirstName_txt
            // 
            FirstName_txt.AutoSize = true;
            FirstName_txt.BackColor = Color.Black;
            FirstName_txt.ForeColor = Color.White;
            FirstName_txt.Location = new Point(68, 31);
            FirstName_txt.Margin = new Padding(5, 0, 5, 0);
            FirstName_txt.Name = "FirstName_txt";
            FirstName_txt.Size = new Size(122, 32);
            FirstName_txt.TabIndex = 10;
            FirstName_txt.Text = "FirstName";
            // 
            // Confirm_pw_signup
            // 
            Confirm_pw_signup.AutoSize = true;
            Confirm_pw_signup.BackColor = Color.Black;
            Confirm_pw_signup.ForeColor = Color.White;
            Confirm_pw_signup.Location = new Point(68, 294);
            Confirm_pw_signup.Margin = new Padding(5, 0, 5, 0);
            Confirm_pw_signup.Name = "Confirm_pw_signup";
            Confirm_pw_signup.Size = new Size(197, 32);
            Confirm_pw_signup.TabIndex = 14;
            Confirm_pw_signup.Text = "ConfirmPassword";
            // 
            // Pw_Sign_Up_txt
            // 
            Pw_Sign_Up_txt.AutoSize = true;
            Pw_Sign_Up_txt.BackColor = Color.Black;
            Pw_Sign_Up_txt.ForeColor = Color.White;
            Pw_Sign_Up_txt.Location = new Point(68, 230);
            Pw_Sign_Up_txt.Margin = new Padding(5, 0, 5, 0);
            Pw_Sign_Up_txt.Name = "Pw_Sign_Up_txt";
            Pw_Sign_Up_txt.Size = new Size(111, 32);
            Pw_Sign_Up_txt.TabIndex = 13;
            Pw_Sign_Up_txt.Text = "Password";
            // 
            // Username_txt_signup
            // 
            Username_txt_signup.AutoSize = true;
            Username_txt_signup.BackColor = Color.Black;
            Username_txt_signup.ForeColor = Color.White;
            Username_txt_signup.Location = new Point(72, 167);
            Username_txt_signup.Margin = new Padding(5, 0, 5, 0);
            Username_txt_signup.Name = "Username_txt_signup";
            Username_txt_signup.Size = new Size(125, 32);
            Username_txt_signup.TabIndex = 12;
            Username_txt_signup.Text = "UserName";
            // 
            // Lastname_txt
            // 
            Lastname_txt.AutoSize = true;
            Lastname_txt.BackColor = Color.Black;
            Lastname_txt.ForeColor = Color.White;
            Lastname_txt.Location = new Point(72, 98);
            Lastname_txt.Margin = new Padding(5, 0, 5, 0);
            Lastname_txt.Name = "Lastname_txt";
            Lastname_txt.Size = new Size(119, 32);
            Lastname_txt.TabIndex = 11;
            Lastname_txt.Text = "LastName";
            // 
            // ConfirmPW_Sign_Up
            // 
            ConfirmPW_Sign_Up.BackColor = SystemColors.InactiveCaption;
            ConfirmPW_Sign_Up.Location = new Point(293, 294);
            ConfirmPW_Sign_Up.Name = "ConfirmPW_Sign_Up";
            ConfirmPW_Sign_Up.Size = new Size(619, 39);
            ConfirmPW_Sign_Up.TabIndex = 7;
            ConfirmPW_Sign_Up.UseSystemPasswordChar = true;
            ConfirmPW_Sign_Up.TextChanged += ConfirmSignUp_TextChanged;
            // 
            // PW_SignUp
            // 
            PW_SignUp.BackColor = SystemColors.InactiveCaption;
            PW_SignUp.Location = new Point(293, 223);
            PW_SignUp.Name = "PW_SignUp";
            PW_SignUp.Size = new Size(619, 39);
            PW_SignUp.TabIndex = 7;
            PW_SignUp.TextChanged += PWSignUp_TextChanged;
            // 
            // UserName_Sign_Up
            // 
            UserName_Sign_Up.BackColor = SystemColors.InactiveCaption;
            UserName_Sign_Up.Location = new Point(293, 160);
            UserName_Sign_Up.Name = "UserName_Sign_Up";
            UserName_Sign_Up.Size = new Size(619, 39);
            UserName_Sign_Up.TabIndex = 6;
            UserName_Sign_Up.TextChanged += UserName_TextChanged;
            // 
            // panel2_SignUp
            // 
            panel2_SignUp.BackColor = Color.Transparent;
            panel2_SignUp.Controls.Add(pw_txt_login);
            panel2_SignUp.Controls.Add(Username_txt_login);
            panel2_SignUp.Controls.Add(UPWlogin);
            panel2_SignUp.Controls.Add(UNameLogIn);
            panel2_SignUp.Controls.Add(BigSignIn);
            panel2_SignUp.Location = new Point(-17, 246);
            panel2_SignUp.Name = "panel2_SignUp";
            panel2_SignUp.Size = new Size(1121, 518);
            panel2_SignUp.TabIndex = 10;
            // 
            // pw_txt_login
            // 
            pw_txt_login.AutoSize = true;
            pw_txt_login.BackColor = Color.Black;
            pw_txt_login.ForeColor = Color.White;
            pw_txt_login.Location = new Point(176, 221);
            pw_txt_login.Margin = new Padding(5, 0, 5, 0);
            pw_txt_login.Name = "pw_txt_login";
            pw_txt_login.Size = new Size(111, 32);
            pw_txt_login.TabIndex = 10;
            pw_txt_login.Text = "Password";
            // 
            // Username_txt_login
            // 
            Username_txt_login.AutoSize = true;
            Username_txt_login.BackColor = Color.Black;
            Username_txt_login.ForeColor = Color.White;
            Username_txt_login.Location = new Point(176, 147);
            Username_txt_login.Margin = new Padding(5, 0, 5, 0);
            Username_txt_login.Name = "Username_txt_login";
            Username_txt_login.Size = new Size(121, 32);
            Username_txt_login.TabIndex = 9;
            Username_txt_login.Text = "Username";
            // 
            // UPWlogin
            // 
            UPWlogin.BackColor = SystemColors.InactiveCaption;
            UPWlogin.Location = new Point(324, 214);
            UPWlogin.Name = "UPWlogin";
            UPWlogin.Size = new Size(553, 39);
            UPWlogin.TabIndex = 7;
            UPWlogin.UseSystemPasswordChar = true;
            UPWlogin.TextChanged += UPWlogin_TextChanged;
            // 
            // UNameLogIn
            // 
            UNameLogIn.BackColor = SystemColors.InactiveCaption;
            UNameLogIn.Location = new Point(324, 147);
            UNameLogIn.Name = "UNameLogIn";
            UNameLogIn.Size = new Size(553, 39);
            UNameLogIn.TabIndex = 11;
            UNameLogIn.TextChanged += UNameLogIn_TextChanged;
            // 
            // BigSignIn
            // 
            BigSignIn.BackColor = SystemColors.ActiveCaption;
            BigSignIn.Font = new Font("Times New Roman", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BigSignIn.Location = new Point(521, 319);
            BigSignIn.Name = "BigSignIn";
            BigSignIn.Size = new Size(117, 57);
            BigSignIn.TabIndex = 8;
            BigSignIn.Text = "Sign In";
            BigSignIn.UseVisualStyleBackColor = false;
            BigSignIn.Click += BigSignIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 6F, FontStyle.Italic);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(0, 814);
            label1.Name = "label1";
            label1.Size = new Size(272, 19);
            label1.TabIndex = 12;
            label1.Text = "Presented by Team SigmaSpark";
            // 
            // Management_txt
            // 
            Management_txt.AutoSize = true;
            Management_txt.BackColor = Color.Transparent;
            Management_txt.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            Management_txt.ForeColor = SystemColors.InactiveCaptionText;
            Management_txt.Location = new Point(437, 189);
            Management_txt.Name = "Management_txt";
            Management_txt.Size = new Size(232, 43);
            Management_txt.TabIndex = 11;
            Management_txt.Text = "Management";
            // 
            // Close_Button
            // 
            Close_Button.BackColor = SystemColors.ActiveBorder;
            Close_Button.BackgroundImage = (Image)resources.GetObject("Close_Button.BackgroundImage");
            Close_Button.BackgroundImageLayout = ImageLayout.Zoom;
            Close_Button.Cursor = Cursors.Hand;
            Close_Button.Location = new Point(933, 34);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(41, 42);
            Close_Button.TabIndex = 12;
            Close_Button.TabStop = false;
            Close_Button.Click += close_button_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Location = new Point(627, 782);
            Clear.Name = "Clear";
            Clear.Size = new Size(128, 39);
            Clear.TabIndex = 9;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += ClearPw;
            // 
            // ShowPW
            // 
            ShowPW.AutoSize = true;
            ShowPW.BackColor = Color.Transparent;
            ShowPW.ForeColor = SystemColors.ButtonFace;
            ShowPW.Location = new Point(329, 782);
            ShowPW.Margin = new Padding(5);
            ShowPW.Name = "ShowPW";
            ShowPW.Size = new Size(208, 36);
            ShowPW.TabIndex = 13;
            ShowPW.Text = "Show Password";
            ShowPW.UseVisualStyleBackColor = false;
            ShowPW.CheckedChanged += show_password_CheckedChanged;
            // 
            // LoginAndRegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1017, 832);
            Controls.Add(label1);
            Controls.Add(ShowPW);
            Controls.Add(Clear);
            Controls.Add(Close_Button);
            Controls.Add(Management_txt);
            Controls.Add(CopyRights_txt);
            Controls.Add(MainSignIn);
            Controls.Add(ESP_txt);
            Controls.Add(MainSignUp);
            Controls.Add(panel2_SignUp);
            Controls.Add(panel1_SignIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginAndRegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1_SignIn.ResumeLayout(false);
            panel1_SignIn.PerformLayout();
            panel2_SignUp.ResumeLayout(false);
            panel2_SignUp.PerformLayout();
            ((ISupportInitialize)Close_Button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainSignUp;
        private Label ESP_txt;
        private Button MainSignIn;
        private Label CopyRights_txt;
        private TextBox FirstName_Sign_Up;
        private TextBox LastName_Sign_Up;
        private Button BigSignUp;
        private Panel panel1_SignIn;
        private TextBox ConfirmPW_Sign_Up;
        private TextBox PW_SignUp;
        private TextBox UserName_Sign_Up;
        private Label Management_txt;
        private Panel panel2_SignUp;
        private TextBox UPWlogin;
        private TextBox UNameLogIn;
        private Button BigSignIn;
        private PictureBox Close_Button;
        private Button Clear;
        private CheckBox ShowPW;
        private Label pw_txt_login;
        private Label Username_txt_login;
        private Label Confirm_pw_signup;
        private Label Pw_Sign_Up_txt;
        private Label Username_txt_signup;
        private Label Lastname_txt;
        private Label FirstName_txt;
        private Label label1;
    }
}
