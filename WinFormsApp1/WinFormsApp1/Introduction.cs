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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Directs to the about us forms
        private void button1_Click(object sender, EventArgs e)
        {
            AboutUs newForm = new AboutUs();

            this.Hide(); //hides the previous form and directs the next form
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();//closes the previous form and directs the next form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataForm1 newForm = new DataForm1();

            this.Hide();//hides the previous form and directs the next form
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();//closes the previous form and directs the next form
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }
    }
}
