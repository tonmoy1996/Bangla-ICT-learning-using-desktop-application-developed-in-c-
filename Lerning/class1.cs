using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lerning
{
    public partial class class1 : Form
    {
        public class1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            this.panel2.Hide();
            this.panel1.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panel2.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {

        }
    }
}
