using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ResultForm3 : Form
    {
        // Using the custom stack with a capacity of 100
        private Stack projectIdeasStack = new Stack(100);

        public ResultForm3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the listboxes before fetching new data
            NameOut_listbox.Items.Clear();
            ProjectOut_listbox.Items.Clear();
            departmentOut_listbox.Items.Clear();
            startDateOut_listbox.Items.Clear();
            endDateOut_listbox.Items.Clear();

            // Call the method to fetch the latest data based on user_Id
            FetchLatestData();
        }

        private void FetchLatestData()
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            string query = "SELECT name, project_name, department, start_date, start_month, start_year, end_date, end_month, end_year FROM data_table_1 ORDER BY user_Id DESC LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string projectName = reader["project_name"].ToString();
                                string department = reader["department"].ToString();
                                string startDateFormatted = $"{reader["start_date"]}/{reader["start_month"]}/{reader["start_year"]}";
                                string endDateFormatted = $"{reader["end_date"]}/{reader["end_month"]}/{reader["end_year"]}";

                                NameOut_listbox.Items.Add(name);
                                ProjectOut_listbox.Items.Add(projectName);
                                departmentOut_listbox.Items.Add(department);
                                startDateOut_listbox.Items.Add(startDateFormatted);
                                endDateOut_listbox.Items.Add(endDateFormatted);
                            }
                            else
                            {
                                MessageBox.Show("No data found in the table.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching latest data: {ex.Message}");
            }
        }


        //Pushes a new project idea to the stack and updates the listbox.

        private void button1_Click(object sender, EventArgs e)
        {
            string projectIdea = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(projectIdea))
            {
                projectIdeasStack.Push(projectIdea);
                UpdateProjectIdeasListBox();
                MessageBox.Show("Project idea added to the stack!");
            }
            else
            {
                MessageBox.Show("Please enter a valid project idea.");
            }

            textBox1.Clear();
        }


        //Removes the last added project idea from the stack and updates the listbox.

        private void button3_Click(object sender, EventArgs e)
        {
            if (!projectIdeasStack.IsEmpty())
            {
                string removedIdea = projectIdeasStack.Pop();
                UpdateProjectIdeasListBox();
                MessageBox.Show($"Removed project idea: {removedIdea}");
            }
            else
            {
                MessageBox.Show("Stack is empty. Nothing to remove.");
            }
        }


        //iterates through the stack and displays all elements in order.

        private void UpdateProjectIdeasListBox()
        {
            listBox1.Items.Clear();

            // Loop through the stack manually to show all elements from top to bottom
            for (int i = 0; i <= projectIdeasStack.GetTop(); i++)
            {
                listBox1.Items.Add($"{i + 1}: {projectIdeasStack.GetElement(i)}");
            }
        }

        private void NameOut_listbox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ProjectOut_listbox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void departmentOut_listbox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void startDateOut_listbox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void endDateOut_listbox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void next_bttn_Click(object sender, EventArgs e)
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            int currentBatchNumber = 1;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch the last batch number from the table
                    string checkBatchQuery = "SELECT MAX(num_elements) FROM project_idea_table";
                    using (MySqlCommand cmdBatch = new MySqlCommand(checkBatchQuery, connection))
                    {
                        var result = cmdBatch.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            currentBatchNumber = Convert.ToInt32(result) + 1;
                        }
                    }

                    // Insert stack elements into the database
                    for (int i = 0; i <= projectIdeasStack.GetTop(); i++)
                    {
                        string insertQuery = "INSERT INTO project_idea_table (project_idea, num_elements) VALUES (@projectIdea, @num_elements)";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@projectIdea", projectIdeasStack.GetElement(i));
                            cmd.Parameters.AddWithValue("@num_elements", currentBatchNumber);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Project ideas have been saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving project ideas: {ex.Message}");
            }

            GroupData newForm = new GroupData();
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultForm3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
