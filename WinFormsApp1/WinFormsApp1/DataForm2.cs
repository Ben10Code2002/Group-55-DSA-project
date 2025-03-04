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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp1
{
    public partial class DataForm2 : Form
    {
        public DataForm2()
        {
            InitializeComponent();
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
                    string sql = "INSERT INTO data_table_2 (s_1,s_2,s_3,s_4,s_5,s_6,s_7,s_8,s_9,m_1,m_2,m_3,m_4,m_5,m_6,m_7,m_8,m_9,tu_1,tu_2,tu_3,tu_4,tu_5,tu_6,tu_7,tu_8,tu_9,w_1,w_2,w_3,w_4,w_5,w_6,w_7,w_8,w_9,thu_1,thu_2,thu_3,thu_4,thu_5,thu_6,thu_7,thu_8,thu_9,f_1,f_2,f_3,f_4,f_5,f_6,f_7,f_8,f_9,sat_1,sat_2,sat_3,sat_4,sat_5,sat_6,sat_7,sat_8,sat_9) VALUES (@s_1,@s_2,@s_3,@s_4,@s_5,@s_6,@s_7,@s_8,@s_9,@m_1,@m_2,@m_3,@m_4,@m_5,@m_6,@m_7,@m_8,@m_9,@tu_1,@tu_2,@tu_3,@tu_4,@tu_5,@tu_6,@tu_7,@tu_8,@tu_9,@w_1,@w_2,@w_3,@w_4,@w_5,@w_6,@w_7,@w_8,@w_9,@thu_1,@thu_2,@thu_3,@thu_4,@thu_5,@thu_6,@thu_7,@thu_8,@thu_9,@f_1,@f_2,@f_3,@f_4,@f_5,@f_6,@f_7,@f_8,@f_9,@sat_1,@sat_2,@sat_3,@sat_4,@sat_5,@sat_6,@sat_7,@sat_8,@sat_9)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@s_1", s_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_2", s_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_3", s_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_4", s_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_5", s_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_6", s_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_7", s_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_8", s_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@s_9", s_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@m_1", M_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_2", M_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_3", M_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_4", M_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_5", M_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_6", M_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_7", M_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_8", M_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@m_9", M_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@tu_1", tu_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_2", tu_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_3", tu_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_4", tu_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_5", tu_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_6", tu_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_7", tu_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_8", tu_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@tu_9", tu_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@w_1", w_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_2", w_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_3", w_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_4", w_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_5", w_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_6", w_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_7", w_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_8", w_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@w_9", w_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@thu_1", Thu_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_2", Thu_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_3", Thu_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_4", Thu_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_5", Thu_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_6", Thu_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_7", Thu_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_8", Thu_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@thu_9", Thu_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@f_1", f_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_2", f_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_3", f_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_4", f_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_5", f_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_6", f_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_7", f_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_8", f_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@f_9", f_9.SelectedItem?.ToString());

                        cmd.Parameters.AddWithValue("@sat_1", sat_1.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_2", sat_2.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_3", sat_3.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_4", sat_4.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_5", sat_5.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_6", sat_6.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_7", sat_7.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_8", sat_8.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@sat_9", sat_9.SelectedItem?.ToString());


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data has been updated!");

                        DataForm3 newForm = new DataForm3();
                        this.Hide();
                        newForm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        //For easy testing purpose combo boxes were overloaded with values by us
        private void DataForm2_Load(object sender, EventArgs e)
        {
            SetDefaultComboBoxValue(s_1);
            SetDefaultComboBoxValue(s_2);
            SetDefaultComboBoxValue(s_3);
            SetDefaultComboBoxValue(s_4);
            SetDefaultComboBoxValue(s_5);
            SetDefaultComboBoxValue(s_6);
            SetDefaultComboBoxValue(s_7);
            SetDefaultComboBoxValue(s_8);
            SetDefaultComboBoxValue(s_9);

            // Monday
            SetDefaultComboBoxValue(M_1);
            SetDefaultComboBoxValue(M_2);
            SetDefaultComboBoxValue(M_3);
            SetDefaultComboBoxValue(M_4);
            SetDefaultComboBoxValue(M_5);
            SetDefaultComboBoxValue(M_6);
            SetDefaultComboBoxValue(M_7);
            SetDefaultComboBoxValue(M_8);
            SetDefaultComboBoxValue(M_9);

            // Tuesday
            SetDefaultComboBoxValue(tu_1);
            SetDefaultComboBoxValue(tu_2);
            SetDefaultComboBoxValue(tu_3);
            SetDefaultComboBoxValue(tu_4);
            SetDefaultComboBoxValue(tu_5);
            SetDefaultComboBoxValue(tu_6);
            SetDefaultComboBoxValue(tu_7);
            SetDefaultComboBoxValue(tu_8);
            SetDefaultComboBoxValue(tu_9);

            // Wednesday
            SetDefaultComboBoxValue(w_1);
            SetDefaultComboBoxValue(w_2);
            SetDefaultComboBoxValue(w_3);
            SetDefaultComboBoxValue(w_4);
            SetDefaultComboBoxValue(w_5);
            SetDefaultComboBoxValue(w_6);
            SetDefaultComboBoxValue(w_7);
            SetDefaultComboBoxValue(w_8);
            SetDefaultComboBoxValue(w_9);

            // Thursday
            SetDefaultComboBoxValue(Thu_1);
            SetDefaultComboBoxValue(Thu_2);
            SetDefaultComboBoxValue(Thu_3);
            SetDefaultComboBoxValue(Thu_4);
            SetDefaultComboBoxValue(Thu_5);
            SetDefaultComboBoxValue(Thu_6);
            SetDefaultComboBoxValue(Thu_7);
            SetDefaultComboBoxValue(Thu_8);
            SetDefaultComboBoxValue(Thu_9);

            // Friday
            SetDefaultComboBoxValue(f_1);
            SetDefaultComboBoxValue(f_2);
            SetDefaultComboBoxValue(f_3);
            SetDefaultComboBoxValue(f_4);
            SetDefaultComboBoxValue(f_5);
            SetDefaultComboBoxValue(f_6);
            SetDefaultComboBoxValue(f_7);
            SetDefaultComboBoxValue(f_8);
            SetDefaultComboBoxValue(f_9);

            // Saturday
            SetDefaultComboBoxValue(sat_1);
            SetDefaultComboBoxValue(sat_2);
            SetDefaultComboBoxValue(sat_3);
            SetDefaultComboBoxValue(sat_4);
            SetDefaultComboBoxValue(sat_5);
            SetDefaultComboBoxValue(sat_6);
            SetDefaultComboBoxValue(sat_7);
            SetDefaultComboBoxValue(sat_8);
            SetDefaultComboBoxValue(sat_9);
        }

        private void SetDefaultComboBoxValue(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("FREE");
            comboBox.Items.Add("BUSY");
            comboBox.SelectedIndex = 0; // Set "FREE" as default
        }

        private void Close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void random_fill_Click(object sender, EventArgs e) { }
    }
}
