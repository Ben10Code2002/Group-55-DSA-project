using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ResultForm1 : Form
    {
        // Links for the seven days of the week. For editing purposes adding new data this method is efficient
        //More than traversal , we have considered insering and deleting and editing nodes efficiently for time complexity
        dLinkedList sunday = new dLinkedList();
        dLinkedList Monday = new dLinkedList();
        dLinkedList Tuesday = new dLinkedList();
        dLinkedList Wednesday = new dLinkedList();
        dLinkedList Thursday = new dLinkedList();
        dLinkedList Friday = new dLinkedList();
        dLinkedList saturday = new dLinkedList();

        public ResultForm1()
        {
            InitializeComponent();
            this.Load += new EventHandler(ResultForm1_Load);
        }

        private void ResultForm1_Load(object sender, EventArgs e)
        {
            AssignDataBaseValues();
        }

        public void AssignDataBaseValues()
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            string queryTable2 = "SELECT * FROM data_table_2 ORDER BY user_Id DESC LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(queryTable2, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AssignTSAToDay(sunday, reader, "s_");
                                AssignTSAToDay(Monday, reader, "m_");
                                AssignTSAToDay(Tuesday, reader, "tu_");
                                AssignTSAToDay(Wednesday, reader, "w_");
                                AssignTSAToDay(Thursday, reader, "thu_");
                                AssignTSAToDay(Friday, reader, "f_");
                                AssignTSAToDay(saturday, reader, "sat_");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching database values: {ex.Message}");
            }
        }

        //Data Assigning Algorithm
        private void AssignTSAToDay(dLinkedList day, MySqlDataReader reader, string columnPrefix)
        {
            string[] tsa = new string[9];
            for (int i = 0; i < 9; i++)
            {
                string columnName = $"{columnPrefix}{i + 1}";
                tsa[i] = reader.IsDBNull(reader.GetOrdinal(columnName)) ? "UNKNOWN" : reader.GetString(columnName);
            }

            day.insertLast(0, 0, tsa);
        }
        //Time calculation Algorithm 
        private void DisplayFreeTimeForDay(string dayName, dLinkedList day)
        {
            Node? current = day.GetHead();

            if (current == null)
            {
                lstOutput.Items.Add($"{dayName}: No Data Available");
                lsOutput2.Items.Add($"{dayName}: No Data Available");
                lsOutput3.Items.Add($"{dayName}: No Data Available");
                return;
            }

            int[] freeTimeArray = day.freeTimeCalac(current);

            lstOutput.Items.Add($"{dayName}:");
            lsOutput2.Items.Add($"{dayName} (FREE Slots):");
            lsOutput3.Items.Add($"{dayName} (BUSY Slots):");

            for (int i = 0; i < freeTimeArray.Length; i++)
            {
                string status = freeTimeArray[i] == 0 ? "FREE" : freeTimeArray[i] == 1 ? "BUSY" : "UNKNOWN";
                lstOutput.Items.Add($"  Slot {i + 1}: {status}");

                if (status == "FREE")
                {
                    lsOutput2.Items.Add($"  Slot {i + 1}: {status}");
                }

                if (status == "BUSY")
                {
                    lsOutput3.Items.Add($"  Slot {i + 1}: {status}");
                }
            }

            lstOutput.Items.Add("");
            lsOutput2.Items.Add("");
            lsOutput3.Items.Add("");
        }

        private void start_bttn_Click(object sender, EventArgs e)
        {
            //list boxes 
            lstOutput.Items.Clear();
            lsOutput2.Items.Clear();
            lsOutput3.Items.Clear();

            DisplayFreeTimeForDay("Sunday", sunday);
            DisplayFreeTimeForDay("Monday", Monday);
            DisplayFreeTimeForDay("Tuesday", Tuesday);
            DisplayFreeTimeForDay("Wednesday", Wednesday);
            DisplayFreeTimeForDay("Thursday", Thursday);
            DisplayFreeTimeForDay("Friday", Friday);
            DisplayFreeTimeForDay("Saturday", saturday);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            //moves the same data to the next forms preventing data lost from moving from one form to the other form
            ResultForm2 newForm = new ResultForm2(sunday, Monday, Tuesday, Wednesday, Thursday, Friday, saturday);
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void ResultForm1_Load_1(object sender, EventArgs e)
        {

        }

        private void lsOutput2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
