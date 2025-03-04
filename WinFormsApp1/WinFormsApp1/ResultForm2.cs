using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ResultForm2 : Form
    {
        // Receive dLinkedLists from ResultForm1
        //Prevents data Lost from when we were going from one form to the other
        private dLinkedList sunday;
        private dLinkedList Monday;
        private dLinkedList Tuesday;
        private dLinkedList Wednesday;
        private dLinkedList Thursday;
        private dLinkedList Friday;
        private dLinkedList saturday;

        // Constructor receiving the linked lists
        public ResultForm2(dLinkedList sunday, dLinkedList Monday, dLinkedList Tuesday, dLinkedList Wednesday, dLinkedList Thursday, dLinkedList Friday, dLinkedList saturday)
        {
            InitializeComponent();

            // Assign the passed linked lists to the local ones
            this.sunday = sunday;
            this.Monday = Monday;
            this.Tuesday = Tuesday;
            this.Wednesday = Wednesday;
            this.Thursday = Thursday;
            this.Friday = Friday;
            this.saturday = saturday;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous results in the list boxes
            listboxOutput1.Items.Clear();
            listBoxOutput2.Items.Clear();

            // Fetch data from the database and assign EXH and STH for each day
            FetchAndAssignDayProperties(sunday, "Sunday");
            FetchAndAssignDayProperties(Monday, "Monday");
            FetchAndAssignDayProperties(Tuesday, "Tuesday");
            FetchAndAssignDayProperties(Wednesday, "Wednesday");
            FetchAndAssignDayProperties(Thursday, "Thursday");
            FetchAndAssignDayProperties(Friday, "Friday");
            FetchAndAssignDayProperties(saturday, "Saturday");

            // Display the results in the list boxes
            DisplayDayProperties("Sunday", sunday);
            DisplayDayProperties("Monday", Monday);
            DisplayDayProperties("Tuesday", Tuesday);
            DisplayDayProperties("Wednesday", Wednesday);
            DisplayDayProperties("Thursday", Thursday);
            DisplayDayProperties("Friday", Friday);
            DisplayDayProperties("Saturday", saturday);
        }

        private void FetchAndAssignDayProperties(dLinkedList day, string dayName)
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connectionString = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            string queryTable3 = "SELECT * FROM data_table_3 ORDER BY user_Id DESC LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(queryTable3, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fetch data for the specified day
                                int exhValue = reader.IsDBNull(reader.GetOrdinal($"{dayName}_EXC"))
                                                ? 0
                                                : reader.GetInt32(reader.GetOrdinal($"{dayName}_EXC"));

                                int sthValue = reader.IsDBNull(reader.GetOrdinal($"{dayName}_SleepHrs"))
                                                ? 0
                                                : reader.GetInt32(reader.GetOrdinal($"{dayName}_SleepHrs"));

                                // Assign values to the linked list properties
                                day.EXH = exhValue;
                                day.STH = sthValue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data for {dayName}: {ex.Message}");
            }
        }

        private void DisplayDayProperties(string dayName, dLinkedList day)
        {
            listboxOutput1.Items.Add($"{dayName} : {day.EXH}");
            listBoxOutput2.Items.Add($"{dayName} : {day.STH}");
        }

       //button for daily free time hours 
       //This can be also more effectively represented through display of the time slots also
       //As we were asked to demonstrate the DSA knowledge , that step were kept as a future development step.
        private void startFreeHoursDaily_Click(object sender, EventArgs e)
        {
            listBoxOutput3.Items.Clear(); // Clear previous results before calculating

            // Calculate and display free hours using DailyFreeTimeCalc for each day
            listBoxOutput3.Items.Add($"Sunday Free Hours: {sunday.DailyFreeTimeCalc(sunday.freeTimeCalac(sunday.GetHead()))}");
            listBoxOutput3.Items.Add($"Monday Free Hours: {Monday.DailyFreeTimeCalc(Monday.freeTimeCalac(Monday.GetHead()))}");
            listBoxOutput3.Items.Add($"Tuesday Free Hours: {Tuesday.DailyFreeTimeCalc(Tuesday.freeTimeCalac(Tuesday.GetHead()))}");
            listBoxOutput3.Items.Add($"Wednesday Free Hours: {Wednesday.DailyFreeTimeCalc(Wednesday.freeTimeCalac(Wednesday.GetHead()))}");
            listBoxOutput3.Items.Add($"Thursday Free Hours: {Thursday.DailyFreeTimeCalc(Thursday.freeTimeCalac(Thursday.GetHead()))}");
            listBoxOutput3.Items.Add($"Friday Free Hours: {Friday.DailyFreeTimeCalc(Friday.freeTimeCalac(Friday.GetHead()))}");
            listBoxOutput3.Items.Add($"Saturday Free Hours: {saturday.DailyFreeTimeCalc(saturday.freeTimeCalac(saturday.GetHead()))}");
        }

        private void SearchByDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOutput3.Items.Clear(); // Clear the results before showing the selected date
            string selectedDay = SearchByDateComboBox.SelectedItem?.ToString();

            switch (selectedDay)
            {
                case "Sunday":
                    listBoxOutput3.Items.Add($"Sunday Free Hours: {sunday.DailyFreeTimeCalc(sunday.freeTimeCalac(sunday.GetHead()))}");
                    break;
                case "Monday":
                    listBoxOutput3.Items.Add($"Monday Free Hours: {Monday.DailyFreeTimeCalc(Monday.freeTimeCalac(Monday.GetHead()))}");
                    break;
                case "Tuesday":
                    listBoxOutput3.Items.Add($"Tuesday Free Hours: {Tuesday.DailyFreeTimeCalc(Tuesday.freeTimeCalac(Tuesday.GetHead()))}");
                    break;
                case "Wednesday":
                    listBoxOutput3.Items.Add($"Wednesday Free Hours: {Wednesday.DailyFreeTimeCalc(Wednesday.freeTimeCalac(Wednesday.GetHead()))}");
                    break;
                case "Thursday":
                    listBoxOutput3.Items.Add($"Thursday Free Hours: {Thursday.DailyFreeTimeCalc(Thursday.freeTimeCalac(Thursday.GetHead()))}");
                    break;
                case "Friday":
                    listBoxOutput3.Items.Add($"Friday Free Hours: {Friday.DailyFreeTimeCalc(Friday.freeTimeCalac(Friday.GetHead()))}");
                    break;
                case "Saturday":
                    listBoxOutput3.Items.Add($"Saturday Free Hours: {saturday.DailyFreeTimeCalc(saturday.freeTimeCalac(saturday.GetHead()))}");
                    break;
                default:
                    listBoxOutput3.Items.Add("Please select a valid day.");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultForm3 newForm = new ResultForm3();
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void ResultForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
