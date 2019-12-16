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
    public partial class class6 : Form
    {
       public  int xxx = 1;

        public int count = 1;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

   
        public class6()
        {
            InitializeComponent();
           
     
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {


            panel4.Visible = true;

        }

        private void class6_Load(object sender, EventArgs e)
        {
            //this.axWindowsMediaPlayer1.Ctlcontrols.play();
            //  panel1.Size=(1236, 352);  1236, 627     3,61   1 4 
            clossse();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
           
            clossse();
          //  this.axWindowsMediaPlayer1.close();
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
            //this.axWindowsMediaPlayer1.fullScreen = true;


            //this.axWindowsMediaPlayer1.fullScreen = true;
            p_intro.Refresh();

            p_intro.Show();
          //  timer1.Start();

        }

       private void clossse()
        {

           // this.axWindowsMediaPlayer1.Ctlcontrols.stop();
            p_intro.Hide();
            player.Stop();



        }
       int x = 0;
       private void timer1_Tick(object sender, EventArgs e)
       {

         


           x++;


           if (x == 200)
           {
             

               clossse();

               x = 0;
               timer1.Stop();
           }







       }

       private void bunifuThinButton28_Click(object sender, EventArgs e)
       {
         
       }

       private void bunifuThinButton27_Click(object sender, EventArgs e)
       {
          // p_intro.Visible=true;
           player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

           player.Play();
           panel1.Visible = false;

           timer2.Stop();
           timer3.Stop();

           clossse();
        
          
       }

       private void bunifuThinButton26_Click(object sender, EventArgs e)
       {
                  panel1.Visible = true;
           
           
                  player.SoundLocation = "1st/intro (online-audio-converter.com).wav";

                   player.Play();

                   panel2.Visible = false;
                   panel3.Visible = false;

       }

       private void bunifuThinButton28_Click_1(object sender, EventArgs e)
       {
          
           Form1 f = new Form1(12);
           f.Show();
           
           this.Dispose();
       }

       private void bunifuThinButton29_Click(object sender, EventArgs e)
       {


           clossse();

           
           xxx = 1;
           
           this.axWindowsMediaPlayer2.Visible = true;
         
           this.axWindowsMediaPlayer2.Ctlcontrols.play();
         //  this.axWindowsMediaPlayer2.fullScreen = true;
       }

       private void player_LoadCompleted(object sender, EventArgs e)
       {

       }


       private void axWindowsMediaPlayer2_StatusChange(object sender, EventArgs e)
       {

       }

       private void axWindowsMediaPlayer2_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
       {

           if (e.newState == 3)//Playing
           {
               axWindowsMediaPlayer2.fullScreen = true;
           }

           if (e.newState == 1)//Playing
           {
               this.axWindowsMediaPlayer2.Ctlcontrols.stop();

               this.axWindowsMediaPlayer2.Visible = false;
               this.axWindowsMediaPlayer2.close();


               this.axWindowsMediaPlayer3.Visible = true;

               this.axWindowsMediaPlayer3.Ctlcontrols.play();
           }


         
       }

       private void axWindowsMediaPlayer3_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
       {
           if (e.newState == 3)//Playing
           {
               axWindowsMediaPlayer3.fullScreen = false;
               axWindowsMediaPlayer3.fullScreen = true;
           }

           if (e.newState == 1)//Playing
           {
               this.axWindowsMediaPlayer3.Ctlcontrols.stop();
               axWindowsMediaPlayer3.fullScreen = false;
               this.axWindowsMediaPlayer3.Visible = false;
               this.axWindowsMediaPlayer3.close();
               clossse();

               player.SoundLocation = "1st/20180815 143856 (online-audio-converter.com).wav";

           player.Play();

           }

         


       }

       private void bunifuThinButton29_MouseHover(object sender, EventArgs e)
       {
           clossse();

           player.SoundLocation = "1st/20180815 143537 (online-audio-converter.com).wav";

           player.Play();
       }

       private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
       {
           
           if (e.newState == 1)//Playing
           {
               this.axWindowsMediaPlayer1.Ctlcontrols.stop();
               this.axWindowsMediaPlayer1.fullScreen = false;
            
               this.axWindowsMediaPlayer1.close();
               clossse();
               
           

           }
       }



        private void load()
       {
         
          

           

       }
       private void bunifuThinButton211_Click(object sender, EventArgs e)
       {

           clossse();

           player.SoundLocation = "1st/importance (online-audio-converter.com).wav";

           player.Play();
          
           panel2.Visible = true;

           timer2.Start();
           panel3.Visible = false;
         

          
           //panel1.Visible = false;







       }




       private void bunifuThinButton210_Click(object sender, EventArgs e)
       {

           clossse();

           player.SoundLocation = "1st/use of ict (online-audio-converter.com).wav";

           player.Play();
        
           panel3.Visible = true;
           timer3.Start();

           panel2.Visible = false;
          
          // panel1.Visible = false;


       }

       private void timer2_Tick(object sender, EventArgs e)
       {
          // load();
           if (count == 1)
           {
               count =2;
           }

           else if(count==2)
           {
               count = 3;

           }

           else if (count == 3)
           {
               count = 4;

           }
           else if (count == 4)
           {
               count = 5;

           }
           else if (count == 5)
           {
               count = 6;

           }
           else if (count == 6)
           {
               count = 7;

           }
           else if (count == 7)
           {
               count = 8;

           }
           else if (count ==8)
           {
               count = 9;

           }

           else if (count == 9)
           {
               count = 1;

           }




           show.ImageLocation = string.Format(@"images\{0}.png", count);

          
       }

       private void show_Click(object sender, EventArgs e)
       {

       }

       private void timer3_Tick(object sender, EventArgs e)
       {

           if (xxx == 1)
           {
               xxx = 2;
           }

           else if (xxx == 2)
           {
               xxx = 3;

           }

           else if (xxx == 3)
           {
               xxx = 4;

           }
           else if (xxx == 4)
           {
               xxx = 5;

           }

           else if (xxx == 5)
           {
               xxx = 1;

           }


           pictureBox1.ImageLocation = string.Format(@"img\{0}.jpg", xxx);

       }

       private void bunifuThinButton212_Click(object sender, EventArgs e)
       {

       }

       private void bunifuThinButton27_MouseHover(object sender, EventArgs e)
       {
           player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuThinButton28_MouseHover(object sender, EventArgs e)
       {
           player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuThinButton27_MouseHover_1(object sender, EventArgs e)
       {
           player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuThinButton28_MouseHover_1(object sender, EventArgs e)
       {
           player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

           player.Play();
       }

      

       private void bunifuThinButton213_Click_1(object sender, EventArgs e)
       {
           panel3.Visible = false;
           clossse();
       }

       private void bunifuImageButton14_Click(object sender, EventArgs e)
       {

           MessageBox.Show("hello");
       }

       private void bunifuImageButton14_MouseHover(object sender, EventArgs e)
       {


           clossse();
           player.SoundLocation = "1st/2nd class.wav";

           player.Play();

       }

       private void bunifuThinButton214_Click(object sender, EventArgs e)
       {

           panel5.Visible=false;

           panel6.Visible = true;



       }

       private void bunifuThinButton215_Click(object sender, EventArgs e)
       {

           panel6.Visible = false;

           panel5.Visible = true;
       }

       private void bunifuThinButton217_Click(object sender, EventArgs e)
       {
           quiz q = new quiz(0);

           q.Show();
       }

       private void bunifuThinButton216_Click(object sender, EventArgs e)
       {
           quiz q = new quiz(1);

           q.Show();
       }

       private void bunifuImageButton20_MouseHover(object sender, EventArgs e)
       {
           clossse();
           player.SoundLocation = "2nd/had disk (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton20_Click(object sender, EventArgs e)
       {
           clossse();
           player.SoundLocation = "2nd/harddisk intro (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton18_MouseHover(object sender, EventArgs e)
       {
           clossse();
           player.SoundLocation = "2nd/web camp (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton13_MouseHover(object sender, EventArgs e)
       {
           clossse();
           player.SoundLocation = "2nd/software (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton13_Click(object sender, EventArgs e)
       {
           clossse();
           player.SoundLocation = "2nd/softwere intro (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton19_MouseHover(object sender, EventArgs e)
       {
           

                clossse();
                player.SoundLocation = "2nd/speaker (online-audio-converter.com).wav";

           player.Play();
       }

       private void bunifuImageButton19_Click(object sender, EventArgs e)
       {
              clossse();
              player.SoundLocation = "2nd/speaker intro (online-audio-converter.com).wav";

           player.Play();
       }

        private void bunifuImageButton14_MouseHover_1(object sender, EventArgs e)
        {
          clossse();
                player.SoundLocation = "2nd/touch sreen (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton14_Click_1(object sender, EventArgs e)
        {
        clossse();
                player.SoundLocation = "2nd/touch screen intro (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton12_MouseHover(object sender, EventArgs e)
        {
          clossse();
                player.SoundLocation = "2nd/scanner (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
             clossse();
                player.SoundLocation = "2nd/scanner intro (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton11_MouseHover(object sender, EventArgs e)
        {
          clossse();
                player.SoundLocation = "2nd/keyboard (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            clossse();
                player.SoundLocation = "2nd/keyboard intro (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton10_MouseHover(object sender, EventArgs e)
        {
        clossse();
                player.SoundLocation = "2nd/barcode reader (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
              clossse();
                player.SoundLocation = "2nd/barcode reader intro (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton9_MouseHover(object sender, EventArgs e)
        {
         clossse();
                player.SoundLocation = "2nd/mother board (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
               clossse();
                player.SoundLocation = "2nd/moterboard intro (online-audio-converter.com).wav";

           player.Play();
        }

        private void bunifuImageButton3_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/ram (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/ram intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton6_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/monitr (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/monitr intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton15_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/processor (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/processor intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton5_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/microphone (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/micro phon intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton7_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/pn drive (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/pn drive intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton16_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/omr (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/omr intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton4_MouseHover(object sender, EventArgs e)
        {
             clossse();
             player.SoundLocation = "2nd/mouse (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/mouse intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton8_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/jot strick (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/joystick intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton17_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/digital camera (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "2nd/digital camera intro (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {


            clossse();


            this.axWindowsMediaPlayer4.Ctlcontrols.play();

            panel7.Show();


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {


            clossse();


            this.axWindowsMediaPlayer6.Ctlcontrols.play();

            panel9.Show();



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            clossse();


            this.axWindowsMediaPlayer5.Ctlcontrols.play();

            panel8.Show();
        }

        private void bunifuThinButton219_Click(object sender, EventArgs e)
        {


            panel10.Show();

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton223_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

            player.Play();
            panel10.Visible = false;

            timer2.Stop();
            timer3.Stop();

            clossse();
        
        }

        private void bunifuThinButton222_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "1st/picha jan (online-audio-converter.com).wav";

            player.Play();
            panel4.Visible = false;

            timer2.Stop();
            timer3.Stop();

            clossse();
        
        }

        private void bunifuThinButton26_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/name of 1st chapter (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton25_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/2nd cchapter name (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton23_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/3rdname (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton22_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/4th chaptar name (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton21_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/5thname (online-audio-converter.com).wav";

            player.Play();
        }

        private void bunifuThinButton217_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/Exam 1.wav";

            player.Play();
        }

        private void bunifuThinButton216_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/Exam 2.wav";

            player.Play();
        }

        private void bunifuThinButton219_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/Dologoto.wav";

            player.Play();
        }

        private void bunifuThinButton24_MouseHover(object sender, EventArgs e)
        {
            clossse();
            player.SoundLocation = "1st/Bhumika.wav";

            player.Play();
        }
       }

     

       

  



    }

