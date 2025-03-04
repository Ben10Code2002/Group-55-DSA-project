using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DataForm1 : Form
    {
        public DataForm1()
        {
            InitializeComponent();
        }

        private void Name_Txt_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void department_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_Name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_Start_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_Start_Month_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_Start_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_End_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_End_Month_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project_End_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_bttn_Click(object sender, EventArgs e)
        {
            // Validate project start date
            if (!int.TryParse(Project_Start_Date.Text, out int startDate) || startDate < 1 || startDate > 31)
            {
                MessageBox.Show("Invalid start date. Please enter a number between 1 and 31.");
                Project_Start_Date.Clear();
                Project_Start_Date.Focus();
                return;
            }

            // Validate project end date
            if (!int.TryParse(Project_End_Date.Text, out int endDate) || endDate < 1 || endDate > 31)
            {
                MessageBox.Show("Invalid end date. Please enter a number between 1 and 31.");
                Project_End_Date.Clear();
                Project_End_Date.Focus();
                return;
            }

            // Validate project start month
            if (!int.TryParse(Project_Start_Month.Text, out int startMonth) || startMonth < 1 || startMonth > 12)
            {
                MessageBox.Show("Invalid start month. Please enter a number between 1 and 12.");
                Project_Start_Month.Clear();
                Project_Start_Month.Focus();
                return;
            }

            // Validate project end month
            if (!int.TryParse(Project_End_Month.Text, out int endMonth) || endMonth < 1 || endMonth > 12)
            {
                MessageBox.Show("Invalid end month. Please enter a number between 1 and 12.");
                Project_End_Month.Clear();
                Project_End_Month.Focus();
                return;
            }

            // Validate project start year
            if (!int.TryParse(Project_Start_Year.Text, out int startYear) || startYear < 2025 || startYear > 2030)
            {
                MessageBox.Show("Invalid start year. Please enter a year between 2025 and 2030.");
                Project_Start_Year.Clear();
                Project_Start_Year.Focus();
                return;
            }

            // Validate project end year
            if (!int.TryParse(Project_End_Year.Text, out int endYear) || endYear < 2025 || endYear > 2030)
            {
                MessageBox.Show("Invalid end year. Please enter a year between 2025 and 2030.");
                Project_End_Year.Clear();
                Project_End_Year.Focus();
                return;
            }

            // Validate department
            string[] validDepartments = { "CE", "EE", "MENA", "CSE", "ME" };
            if (!validDepartments.Contains(department_box.Text.Trim()))
            {
                MessageBox.Show("Invalid department. Please enter one of the following: CE, EE, MENA, CSE, ME.");
                department_box.Clear();
                department_box.Focus();
                return;
            }

            // Validate timeline
            if (startYear > endYear)
            {
                MessageBox.Show("Invalid timeline. Start year cannot be greater than end year.");
                Project_Start_Year.Clear();
                Project_End_Year.Clear();
                Project_Start_Year.Focus();
                return;
            }

            if (startYear == endYear)
            {
                if (startMonth > endMonth)
                {
                    MessageBox.Show("Invalid timeline. If start year and end year are the same, start month must be less than or equal to end month.");
                    Project_Start_Month.Clear();
                    Project_End_Month.Clear();
                    Project_Start_Month.Focus();
                    return;
                }

                if (startMonth == endMonth && startDate >= endDate)
                {
                    MessageBox.Show("Invalid timeline. If start year, start month, and end month are the same, start date must be less than end date.");
                    Project_Start_Date.Clear();
                    Project_End_Date.Clear();
                    Project_Start_Date.Focus();
                    return;
                }
            }

            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connstring = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO data_table_1 (name, department, project_name,start_date,start_month,start_year,end_date,end_month,end_year) VALUES (@name, @department, @project_name, @start_date, @start_month, @start_year, @end_date, @end_month,@end_year)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@name", Name_Txt_Box.Text);
                        cmd.Parameters.AddWithValue("@department", department_box.Text);
                        cmd.Parameters.AddWithValue("@project_name", Project_Name_txt.Text);
                        cmd.Parameters.AddWithValue("@start_date", Project_Start_Date.Text);
                        cmd.Parameters.AddWithValue("@start_month", Project_Start_Month.Text);
                        cmd.Parameters.AddWithValue("@start_year", Project_Start_Year.Text);
                        cmd.Parameters.AddWithValue("@end_date", Project_End_Date.Text);
                        cmd.Parameters.AddWithValue("@end_month", Project_End_Month.Text);
                        cmd.Parameters.AddWithValue("@end_year", Project_End_Year.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been updated!");

                        // Navigate to the Introduction form
                        DataForm2 newForm = new DataForm2();
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

        private void close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
