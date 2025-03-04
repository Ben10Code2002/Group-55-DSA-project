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
    public partial class ResultsAnz : Form
    {
        public ResultsAnz()
        {
            InitializeComponent();
        }

        private void Analyze_bttn_Click(object sender, EventArgs e)
        {
            ResultForm1 newForm = new ResultForm1();
            this.Hide();
            newForm.Show();
            newForm.FormClosed += (s, args) => this.Close();
        }

        private void ResultsAnz_Load(object sender, EventArgs e)
        {

        }
    }
}
