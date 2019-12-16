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
    public partial class c2 : Form
    {
        public c2()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(label1.Text) < 10)
            {
                label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label1.Text) > 0)
            {
                label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

            int xx =  bunifuImageButton9.Location.Y - (Convert.ToInt32(label1.Text) * 30);
            bunifuImageButton9.Location = new Point(
     this.bunifuImageButton9.Location.X,
     xx);

        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            int xx = bunifuImageButton9.Location.Y + (Convert.ToInt32(label1.Text) * 30);
            bunifuImageButton9.Location = new Point(
     this.bunifuImageButton9.Location.X,
     xx);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            int xx = bunifuImageButton9.Location.X - (Convert.ToInt32(label1.Text) * 30);
            bunifuImageButton9.Location = new Point(
     xx,
     bunifuImageButton9.Location.Y);
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            int xx = bunifuImageButton9.Location.X + (Convert.ToInt32(label1.Text) * 30);
            bunifuImageButton9.Location = new Point(
     xx,
     bunifuImageButton9.Location.Y);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            hidee();
            panel1.Show();
        }







        private void hidee()
        {

            panel1.Hide();



        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
