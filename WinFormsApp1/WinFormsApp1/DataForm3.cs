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
    public partial class DataForm3 : Form
    {
        public DataForm3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataForm2 newForm = new DataForm2();

            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This is our local host database connection string
            //If needed to check the working operation of the database import the GIT database file to localhost and
            //change the connecting string
            string connstring = "server=localhost;uid=root;pwd=@Bumeega2002;database=dataform1";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                try
                {
                    con.Open();
                    string sql = "INSERT INTO data_table_3 (Sunday_EXC, Monday_EXC, Tuesday_EXC, Wednesday_EXC, Thursday_EXC, Friday_EXC, Saturday_EXC, Sunday_SleepHrs, Monday_SleepHrs, Tuesday_SleepHrs, Wednesday_SleepHrs, Thursday_SleepHrs, Friday_SleepHrs, Saturday_SleepHrs) VALUES (@Sunday_EXC, @Monday_EXC, @Tuesday_EXC, @Wednesday_EXC, @Thursday_EXC, @Friday_EXC, @Saturday_EXC, @Sunday_SleepHrs, @Monday_SleepHrs, @Tuesday_SleepHrs, @Wednesday_SleepHrs, @Thursday_SleepHrs, @Friday_SleepHrs, @Saturday_SleepHrs)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Sunday_EXC", Convert.ToInt32(Su_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Monday_EXC", Convert.ToInt32(M_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Tuesday_EXC", Convert.ToInt32(Tu_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Wednesday_EXC", Convert.ToInt32(W_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Thursday_EXC", Convert.ToInt32(Thu_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Friday_EXC", Convert.ToInt32(F_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Saturday_EXC", Convert.ToInt32(Sat_E_C_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Sunday_SleepHrs", Convert.ToInt32(Su_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Monday_SleepHrs", Convert.ToInt32(M_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Tuesday_SleepHrs", Convert.ToInt32(Tu_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Wednesday_SleepHrs", Convert.ToInt32(W_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Thursday_SleepHrs", Convert.ToInt32(Thu_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Friday_SleepHrs", Convert.ToInt32(F_S_H.SelectedItem));
                        cmd.Parameters.AddWithValue("@Saturday_SleepHrs", Convert.ToInt32(Sat_S_H.SelectedItem));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been updated!");

                        // Navigate to the ResultsAnz form
                        ResultsAnz newForm = new ResultsAnz();
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



        private void Su_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void M_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tu_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void W_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Thu_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sat_E_C_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Su_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void M_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tu_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void W_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Thu_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void F_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sat_S_H_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataForm3_Load(object sender, EventArgs e)
        {

        }
    }
}
