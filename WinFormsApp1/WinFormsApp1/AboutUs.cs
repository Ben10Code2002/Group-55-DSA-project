//About us form contains our group details

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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introduction newForm = new Introduction();  

            this.Hide(); //hides the previous form and directs the next form
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close(); //closes the previous form and directs the next form
        }

        private void close_bttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }
    }
}
