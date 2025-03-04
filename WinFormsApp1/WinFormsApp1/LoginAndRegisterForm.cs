using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class LoginAndRegisterForm : Form
    {
        public LoginAndRegisterForm()
        {
            InitializeComponent();
        }

        private void MainSignUp_Click(object sender, EventArgs e)
        {
            panel1_SignIn.BringToFront();
        }

        private void MainSignIn_Click(object sender, EventArgs e)
        {
            panel2_SignUp.BringToFront();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BigSignIn_Click(object sender, EventArgs e)
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connstring = "server=localhost;uid=root;pwd=@Bumeega2002;database=lrlogin"; 
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT COUNT(*) FROM lr_data WHERE username=@username AND password=@password";
                    //lr_data is a table in our current local host 
                    // username and password are columns in that table
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", UNameLogIn.Text);
                        cmd.Parameters.AddWithValue("@password", UPWlogin.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!");

                            // Moving to the admin form
                            if (UNameLogIn.Text == "Admin")
                            {
                                AdminForm newForm = new AdminForm(); 
                                this.Hide();
                                newForm.Show();
                                newForm.FormClosed += (s, args) => this.Close();
                            }
                            // Navigate to the Introduction form
                            else {
                                Introduction newForm = new Introduction();
                                this.Hide();
                                newForm.Show();
                                newForm.FormClosed += (s, args) => this.Close();
                            }
                        }
                        
                        else
                        {
                            MessageBox.Show("Username or password is incorrect. Please try again.");
                            ClearPw(sender, e);
                        }
                    }
                }
                //exception handling
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
       
        private void ClearPw(object sender, EventArgs e)
        {
            // Clear all input fields
            FirstName_Sign_Up.Text = "";
            LastName_Sign_Up.Text = "";
            UserName_Sign_Up.Text = "";
            PW_SignUp.Text = "";
            ConfirmPW_Sign_Up.Text = "";
            UNameLogIn.Text = "";
            UPWlogin.Text = "";
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            UPWlogin.UseSystemPasswordChar = !ShowPW.Checked;
            PW_SignUp.UseSystemPasswordChar = !ShowPW.Checked;
            ConfirmPW_Sign_Up.UseSystemPasswordChar = !ShowPW.Checked;
        }

        private void BigSignUp_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(UserName_Sign_Up.Text) ||
                string.IsNullOrWhiteSpace(PW_SignUp.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPW_Sign_Up.Text) ||
                string.IsNullOrWhiteSpace(FirstName_Sign_Up.Text) ||
                string.IsNullOrWhiteSpace(LastName_Sign_Up.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.");
                return;
            }

            // Check if password and confirm password match
            if (PW_SignUp.Text == ConfirmPW_Sign_Up.Text)
            {
                //This is our local host database connection string
                //If needed to check the working operation of the database import the GIT database file to localhost and
                //change the connecting string
                string connstring = "server=localhost;uid=root;pwd=@Bumeega2002;database=lrlogin";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    try
                    {
                        con.Open();
                        string sql = "INSERT INTO lr_data (username, password, firstname, lastname) VALUES (@username, @password, @firstname, @lastname)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@username", UserName_Sign_Up.Text);
                            cmd.Parameters.AddWithValue("@password", PW_SignUp.Text);
                            cmd.Parameters.AddWithValue("@firstname", FirstName_Sign_Up.Text);
                            cmd.Parameters.AddWithValue("@lastname", LastName_Sign_Up.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successful!");

                            // Navigate to the Introduction form
                            Introduction newForm = new Introduction();
                            this.Hide();
                            newForm.Show();
                            newForm.FormClosed += (s, args) => this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                ClearPw(sender, e);
            }
        }

        //Avoid removing these functions as they are connected to the front end and may generate an error
        private void UPWlogin_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void PWSignUp_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void ConfirmSignUp_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }

        private void UNameLogIn_TextChanged(object sender, EventArgs e)
        {
            // Placeholder for text changed event
        }
    }
}
