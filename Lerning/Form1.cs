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
    public partial class Form1 : Form
    {



        System.Media.SoundPlayer player = new System.Media.SoundPlayer();





        public Form1()
        {
            InitializeComponent();





           


        }

           public Form1(int x)
        {
            InitializeComponent();


            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.Visible = false;
            panel2.Visible = true;



           


        }






        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;   
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.Visible = false;
            panel2.Visible = true;
        }

      

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

            player.SoundLocation = "bal.wav";

            player.Play();






        }

        private void bunifuThinButton22_MouseHover(object sender, EventArgs e)
        {





            player.SoundLocation = "1st/srani nirbachon (online-audio-converter.com).wav";

            player.Play();


            autoh();
            ani1.ShowSync(panel3);

        }

        private void bunifuThinButton22_MouseLeave(object sender, EventArgs e)
        {
            
        }


        public void autoh()
        {

            ani1.HideSync(panel3);



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            autoh();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton24_MouseHover(object sender, EventArgs e)
        {
            autoh();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            class1 c1 = new class1 ();

            c1.Show();

            this.Hide();
            // 1227, 646

            //12, 52
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            c2 c = new c2();
            c.Show();
            this.Hide();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            class6 c = new class6();


            c.Show();


            this.Hide();
        }

        private void bunifuThinButton27_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/2nd class.wav";

            player.Play();
        }

        private void bunifuThinButton29_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/3rd class.wav";

            player.Play();
        }

        private void bunifuThinButton211_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/4th class.wav";

            player.Play();
        }

        private void bunifuThinButton212_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/5th class.wav";

            player.Play();
        }

        private void bunifuThinButton210_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/6th class.wav";

            player.Play();
        }

        private void bunifuThinButton28_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/1st class (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton21_MouseHover(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/Enter.wav";

            player.Play();
        }

    }
}
