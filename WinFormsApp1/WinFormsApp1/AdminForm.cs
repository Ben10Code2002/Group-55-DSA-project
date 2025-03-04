using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class AdminForm : Form
    {
        private BinarySearchTree bst = new BinarySearchTree();

        public AdminForm()
        {
            InitializeComponent();
        }

        // Button 1: Load usernames from the database
        private void button1_Click(object sender, EventArgs e)
        {
            bst = new BinarySearchTree(); // Reset BST before inserting data
            LoadUsernamesFromDatabase();
            DisplaySortedUsernames();
        }

        private void LoadUsernamesFromDatabase()
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=lrlogin";
            string query = "SELECT username FROM lr_data";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string username = reader["username"].ToString();
                                bst.Insert(username);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void DisplaySortedUsernames()
        {
            listBox1.Items.Clear();
            List<string> sortedData = bst.InOrderTraversal();
            foreach (string item in sortedData)
            {
                listBox1.Items.Add(item);
            }
        }

        // Button 2: Load project data from the database
        private void button2_Click(object sender, EventArgs e)
        {
            bst = new BinarySearchTree(); // Reset BST before inserting data
            LoadProjectDataFromDatabase();
            DisplaySortedProjectData();
        }

        private void LoadProjectDataFromDatabase()
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            string query = "SELECT name, project_name, end_date, end_month, end_year FROM data_table_1";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string clientName = reader["name"].ToString();
                                string projectName = reader["project_name"].ToString();
                                int endDay = Convert.ToInt32(reader["end_date"]);
                                int endMonth = Convert.ToInt32(reader["end_month"]);
                                int endYear = Convert.ToInt32(reader["end_year"]);

                                // Convert to DateTime
                                DateTime endDate = new DateTime(endYear, endMonth, endDay);
                                DateTime today = DateTime.Today;

                                // Calculate remaining time
                                int remainingDays = (endDate - today).Days;
                                int years = remainingDays / 365;
                                int months = (remainingDays % 365) / 30;
                                int days = (remainingDays % 365) % 30;

                                // Format project details
                                string projectDetails = $"{clientName} - {projectName} | Remaining: {years} years, {months} months, {days} days";

                                // Insert into BST (sorted by remaining days)
                                bst.Insert(remainingDays, projectDetails);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void DisplaySortedProjectData()
        {
            listBox1.Items.Clear();
            List<string> sortedData = bst.InOrderTraversal();
            foreach (string item in sortedData)
            {
                listBox1.Items.Add(item);
            }
        }

        // Button 3: Close application
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
