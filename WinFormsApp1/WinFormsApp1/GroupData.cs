using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class GroupData : Form
    {
        private Stack memberStack; // Creating an instance of the Stack class
        private int currentStackNumber = 0; // Track the current stack number

        public GroupData()
        {
            InitializeComponent();
            memberStack = new Stack(100); // Initialize stack with a capacity of 100
        }

        private void Member_Add_Button_Click(object sender, EventArgs e)
        {
            // Check if the textbox is not empty and radio button 2 is selected
            if (radioButton2.Checked && !string.IsNullOrWhiteSpace(member_name.Text))
            {
                // Add the member to the stack
                memberStack.Push(member_name.Text);

                // Update the listbox with the current stack elements
                members_listBox.Items.Clear();
                for (int i = 0; i < memberStack.Size(); i++)
                {
                    members_listBox.Items.Add(memberStack.GetElement(i));
                }

                // Clear the textbox after adding
                member_name.Text = string.Empty;
            }
            else if (!radioButton2.Checked)
            {
                MessageBox.Show("Please select Radio Button 2 to add members.");
            }
            else
            {
                MessageBox.Show("Please enter a member name.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            member_name.Enabled = false;
            Member_Add_Button.Enabled = false;
            memberStack = new Stack(100); // Clear the stack
            members_listBox.Items.Clear(); // Clear the listbox
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // for selecting group or individual
        {
            member_name.Enabled = true;
            Member_Add_Button.Enabled = true;
        }

        private void AbOrder_Click(object sender, EventArgs e)
        {
            string[] membersArray = new string[memberStack.Size()];
            for (int i = 0; i < memberStack.Size(); i++)
            {
                membersArray[i] = memberStack.GetElement(i);
            }

            // Perform merge sort on the array
            MergeSort(membersArray, 0, membersArray.Length - 1);

            // Update the listbox with sorted elements
            members_listBox.Items.Clear();
            foreach (var member in membersArray)
            {
                members_listBox.Items.Add(member);
            }
        }
        //Merge Sort Algorithm 
        //Worst Case Time Complexity O(nlog n)
        //One of the most efficient searching algorithms


        private void MergeSort(string[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(string[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            string[] leftArray = new string[n1];
            string[] rightArray = new string[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int i = 0; i < n2; i++)
                rightArray[i] = array[mid + 1 + i];

            int k = left, iLeft = 0, iRight = 0;
            while (iLeft < n1 && iRight < n2)
            {
                if (string.Compare(leftArray[iLeft], rightArray[iRight]) <= 0)
                {
                    array[k++] = leftArray[iLeft++];
                }
                else
                {
                    array[k++] = rightArray[iRight++];
                }
            }

            while (iLeft < n1)
                array[k++] = leftArray[iLeft++];

            while (iRight < n2)
                array[k++] = rightArray[iRight++];
        }

        private void next_bttn_Click(object sender, EventArgs e)
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            currentStackNumber++;

            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    for (int i = 0; i < memberStack.Size(); i++)
                    {
                        string query = "INSERT INTO member_table (member_name, stack_no) VALUES (@member_name, @stack_no)";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@member_name", memberStack.GetElement(i));
                            cmd.Parameters.AddWithValue("@stack_no", currentStackNumber);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Data successfully inserted into the database.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting data: {ex.Message}");
                }
            }

            // Clear stack after insertion
            memberStack = new Stack(100);
            members_listBox.Items.Clear();

            Final newForm = new Final();
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void GroupData_Load(object sender, EventArgs e)
        {

        }
    }
}
