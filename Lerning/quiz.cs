using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Lerning
{
    public partial class quiz : Form
    {

        private int track;
        

        public quiz(int x)
        {
            InitializeComponent();



            this.track = x;

            if (x == 0)
            {

                quiz1();


            }
            else
            {

                quiz2();


            }






        }




        int number = 0;

        int mark = 0;

        public void quiz1()
        {

            qus[] q = new qus[15];


            q[0] = new qus();
            q[1] = new qus();
            q[2] = new qus();
            q[3] = new qus();
            q[4] = new qus();
            q[5] = new qus();
            q[6] = new qus();
            q[7] = new qus();
            q[8] = new qus();
            q[9] = new qus();
            q[10] = new qus();
            q[11] = new qus();
            q[12] = new qus();
            q[13] = new qus();
            q[14] = new qus();
            q[0] = new qus();
            q[0] = new qus();


            q[0].quse = "প্রশ্ন:সর্বপ্রথম মানুষ কীভাবে তথ্য বিনিময় করত?";
            q[0].A = "কথা বলে";
            q[0].B = "চিঠি লিখে";
            q[0].C = "পাথরে লিখে";
            q[0].D = "বই লিখে";
            q[0].Ans = "কথা বলে";



            q[1].quse = "প্রশ্ন:ইন্টারনেট নেটওয়ার্ক বিস্তৃত করার কাজে ব্যবহৃত হার্ডওয়্যার হলো—\ni. হাব\nii. সুইচ\niii.রাউটার\nনিচের কোনটি সঠিক ?";
            q[1].A = "i ও ii";
            q[1].B = "i ও iii";
            q[1].C = "ii ও iii";
            q[1].D = "i, ii ও ii";
            q[1].Ans = "i, ii ও ii";



            q[2].quse = "প্রশ্ন:নিচের কোনটি আউটপুট যন্ত্র?";
            q[2].A = "কী-বোর্ড";
            q[2].B = "প্রিন্টার";
            q[2].C = "মাউস";
            q[2].D = "মডেম";
            q[2].Ans = "প্রিন্টার";


            q[3].quse = "প্রশ্ন:কম্পিউটার ভাইরাস কী?";
            q[3].A = "এক ধরনের কম্পিউটার প্রোগ্রাম";
            q[3].B = "এক ধরনের হার্ডওয়্যার";
            q[3].C = "এক ধরনের নেটওয়ার্ক";
            q[3].D = "এক ধরনের অপারেটিং সিস্টেম";
            q[3].Ans = "এক ধরনের কম্পিউটার প্রোগ্রাম";


            q[4].quse = "প্রশ্ন:ইন্টারনেটে যে ধরনের বেচাকেনা হয় তার নাম কী?";
            q[4].A = "ই-বাজার";
            q[4].B = "ই-কমার্স";
            q[4].C = "ই-বিজনেস্";
            q[4].D = "ই-মেল এন্ড বাই";
            q[4].Ans = "ই-কমার্স";

            q[5].quse = "প্রশ্ন:বিনামূল্যে পাওয়া যায় এমন অপারেটিং সিস্টেমের নাম কী?";
            q[5].A = "ম্যাক";
            q[5].B = "উইন্ডোজ";
            q[5].C = "লিনাক্স";
            q[5].D = "ইউনিক্স";
            q[5].Ans = "লিনাক্স";

            q[6].quse = "প্রশ্ন:তুহিন কম্পিউটারে ইন্টারনেট থেকে কিছু বই এবং ছবি ডাউনলোড করল। পরে সে দেখল তার কম্পিউটার ভাইরাস দ্বারা আক্রান্ত হয়েছে। এবং এটি ঠিকভাবে কাজ করছে না। তুহিনের কম্পিউটারে কীসের মাধ্যমে ভাইরাস আক্রান্ত হয়েছে?";
            q[6].A = "সফটওয়্যার";
            q[6].B = "পেনড্রাইভ";
            q[6].C = "সিডি";
            q[6].D = "কম্পিউটার নেটওয়ার্ক";
            q[6].Ans = "কম্পিউটার নেটওয়ার্ক";


            q[7].quse = "প্রশ্ন:বিজ্ঞান ও গবেষণায় সবচেয়ে বেশি কী ব্যবহৃত হয়?";
            q[7].A = "রেডিও";
            q[7].B = "টেলিভিশন";
            q[7].C = "আইসিটি";
            q[7].D = "ইন্টারনেট";
            q[7].Ans = "ইন্টারনেট";


            q[8].quse = "প্রশ্ন:মাদারবোর্ডের কোন ডিভাইসটির ওপর ফ্যান লাগানো থাকে?";
            q[8].A = "র্যাম";
            q[8].B = "প্রসেসর";
            q[8].C = "সাউন্ড কার্ড";
            q[8].D = "ভিজিএ কার্ড";
            q[8].Ans = "প্রসেসর";

            q[9].quse = "প্রশ্ন:বর্তমান পৃথিবীতে তথ্য কী হিসেবে কাজ করে?";
            q[9].A = "শক্তি";
            q[9].B = "পদার্থ";
            q[9].C = "কাজের কেন্দ্রবিন্দু";
            q[9].D = "ভরসা";
            q[9].Ans = "শক্তি";


            q[10].quse = "প্রশ্ন:ওয়ার্ড প্রসেসরে লেখা হাতে লেখার চেয়ে এত সুবিধাজনক হওয়ার কারণ হলো- \ni. ওয়ার্ড প্রসেসরে লেখা স্পষ্ট হয় \nii. সহজে এডিট করে ভুল সংশোধন করা যায় \niii. ছবি সংযোজন করা যায় \nনিচের কোনটি সঠিক ?";
            q[10].A = "i ও ii";
            q[10].B = "i ও iii";
            q[10].C = "ii ও iii";
            q[10].D = "i, ii ও iii";
            q[10].Ans = "i, ii ও iii";


            q[11].quse = "প্রশ্ন:সাগরের ঝড় বৃষ্টি হলে খুব তাড়াতাড়ি খবর পাওয়া যায় কোন মাধ্যমে?";
            q[11].A = "মোবাইলে";
            q[11].B = "কম্পিউটারে";
            q[11].C = "রেডিওতে";
            q[11].D = "সংবাদপত্রে";
            q[11].Ans = "রেডিওতে";




            q[12].quse = "প্রশ্ন:ইন্টারনেটের এই লক্ষ কোটি নেটওয়ার্ক সংযুক্ত করে রেখেছে কে?";
            q[12].A = "সুইচ";
            q[12].B = "হাব";
            q[12].C = "রাউটার";
            q[12].D = "মডেম";
            q[12].Ans = "রাউটার";


            q[13].quse = "প্রশ্ন:মুক্ত বা ওপেন সোর্স কম্পিউটারে কোনটি তৈরি হয় না?";
            q[13].A = "ব্যাকটেরিয়া";
            q[13].B = "ভাইরাস";
            q[13].C = "সফটওয়্যার";
            q[13].D = "হার্ডওয়্যার";
            q[13].Ans = "ভাইরাস";


            q[14].quse = "প্রশ্ন:কম্পিউটার ছোট হয়ে পরিণত হয়েছে- \ni. নোটবুকে\nii. ট্যাবলেটে \niii. স্মার্টফোনে \nনিচের কোনটি সঠিক ?";
            q[14].A = "i ও ii";
            q[14].B = "i ও iii";
            q[14].C = "ii ও iii";
            q[14].D = "i, ii ও iii";
            q[14].Ans = "i, ii ও iii";



            label4.Text = mark.ToString();

            label4.Visible = true;


            if (number == 15)
            {


                MessageBox.Show("Your Mark Is :" + mark);

                this.Dispose();

            }


            else
            {


                this.label2.Text = q[number].quse;
                this.button1.Text = q[number].A;
                this.button2.Text = q[number].B;
                this.button3.Text = q[number].C;
                this.button4.Text = q[number].D;
                this.label3.Text = q[number].Ans;
                number++;

            }

        }

        public void quiz2()
        {


            qus[] q = new qus[30];
            q[0] = new qus();
            q[1] = new qus();
            q[2] = new qus();
            q[3] = new qus();
            q[4] = new qus();
            q[5] = new qus();
            q[6] = new qus();
            q[7] = new qus();
            q[8] = new qus();
            q[9] = new qus();
            q[10] = new qus();
            q[11] = new qus();
            q[12] = new qus();
            q[13] = new qus();
            q[14] = new qus();
            q[0] = new qus();

            q[0].quse = "প্রশ্ন:সংখ্যা ও সংখ্যা চিহ্ন এন্ট্রি করার জন্য কি-বোর্ডের কোন অংশ ব্যবহৃত হয়?";
            q[0].A = "অ্যারো কি";
            q[0].B = "নিউম্যারিক কি-প্যাড";
            q[0].C = "এন্টার কি";
            q[0].D = "কন্ট্রোল কি";
            q[0].Ans ="নিউম্যারিক কি-প্যাড";



            q[1].quse = "প্রশ্ন:File কম্পিউটারের কোথায় সংরক্ষিত থাকে?";
            q[1].A = "হার্ডড্রাইভে";
            q[1].B = "র্যামে";
            q[1].C = "রমে";
            q[1].D = "ফ্লাশ মেমোরিতে";
            q[1].Ans = "হার্ডড্রাইভে";



            q[2].quse = "প্রশ্ন:ইন্টারনেট ব্যবহারের কারণ কী?";
            q[2].A = "তথ্য প্রক্রিয়াকরণ";
            q[2].B = "তথ্য স্টোর";
            q[2].C = "তথ্য বিনিময়";
            q[2].D = "তথ্য বিকৃতি";
            q[2].Ans = "তথ্য বিনিময়";  
          

            q[3].quse = "প্রশ্ন:ছোট শিশুদের কম্পিউটারে অতিরিক্ত গেম খেলা উচিত নয় কারণ এতে শিশুরা- \ni. মানসিকভাবে অসুস্থ হতে পারে \nii. বোবা হয়ে যেতে পারে\niii. গেমে আসক্ত হতে পারে \nনিচের কোনটি সঠিক ?";
            q[3].A = "i ও ii";
            q[3].B = "i ও iii";
            q[3].C = "ii ও iii";
            q[3].D = "i, ii ও iii";
            q[3].Ans = "i ও iii";


            q[4].quse = "প্রশ্ন:নতুন ফাইল খুলতে কোথায় ক্লিক করতে হয়?";
            q[4].A = "New";
            q[4].B = "File";
            q[4].C = "Save";
            q[4].D = "Text";
            q[4].Ans = "New";


            q[5].quse = "প্রশ্ন:বর্তমানে আমরা যে মাউসগুলো ব্যবহার করি, সেগুলোর নাম কী?";
            q[5].A = "বল মাউস";
            q[5].B = "লাইট মাউস";
            q[5].C = "প্যাডলেস মাউস";
            q[5].D = "অপটিক্যাল মাউস";
            q[5].Ans = "অপটিক্যাল মাউস";





            q[6].quse = "প্রশ্ন:নিচের কোন ওয়েবসাইটের সাহায্যে যেকোনো এলাকার ম্যাপ দেখা যায়? ";
            q[6].A = "http://www.nasa.gov/";
            q[6].B = "http://www.ask.com";
            q[6].C = "http://maps.google.com";
            q[6].D = "http://maps.google.org";
            q[6].Ans = "http://maps.google.com";


            q[7].quse = "প্রশ্ন:কম্পিউটার গেম তৈরি করতে কী ধরনের সফটওয়্যার ব্যবহৃত হয়?";
            q[7].A = "প্যাকেজ";
            q[7].B = "কাস্টমাইজড";
            q[7].C = "অপারেটিং";
            q[7].D = "সিস্টেম ইউটিলিটি";
            q[7].Ans = "প্যাকেজ";


            q[8].quse = "প্রশ্ন:স্যাটেলাইট কী?";
            q[8].A = "তথ্য আদান-প্রদান করার যন্ত্র";
            q[8].B = "গান শোনার যন্ত্র";
            q[8].C = "গোলাগুলি করার যন্ত্র";
            q[8].D = "লেখালেখি করার যন্ত্র";
            q[8].Ans = "তথ্য আদান-প্রদান করার যন্ত্র";


            q[9].quse = "প্রশ্ন:যখন কোনো তথ্য খোঁজা দরকার হয় তখন আমরা কোন সফটওয়্যার ব্যবহার করি?";
            q[9].A = "মাইক্রোসফট ওয়ার্ড";
            q[9].B = "সার্চ ইঞ্জিন";
            q[9].C = "ওয়েবসাইট";
            q[9].D = "গুগল আর্থ";
            q[9].Ans = "সার্চ ইঞ্জিন";









            q[10].quse = "প্রশ্ন:কম্পিউটার ভাইরাস থেকে কম্পিউটারকে রক্ষা করার জন্য কী ব্যবহার করতে হবে?";
            q[10].A = "ভালো ভাইরাস";
            q[10].B = "এন্টিভাইরাস";
            q[10].C = "ভাইরাসযুক্ত পেনড্রাইভ";
            q[10].D = "ভাইরাসযুক্ত সিডি";
            q[10].Ans = "এন্টিভাইরাস";

      

            q[11].quse = " প্রশ্ন:কারা কাগজ আবিষ্কার করে?";
            q[11].A = "চীনারা";
            q[11].B = "মিসরীয়রা";
            q[11].C = "গ্রীকরা";
            q[11].D = "রোমানরা";
            q[11].Ans = "চীনারা";


            q[12].quse = "  প্রশ্ন:OS-এর পূর্ণরূপ কী?";
            q[12].A = "Open system";
            q[12].B = "Operating system";
            q[12].C = "Open softwoare";
            q[12].D = "On switch";
            q[12].Ans = "Operating system";


            q[13].quse = "প্রশ্ন:ইন্টারনেট শব্দটি এসেছে কোন কথাটা থেকে?";
            q[13].A = "Intercontinent Network";
            q[13].B = "Interconnected Network";
            q[13].C = "Interactive Network";
            q[13].D = "Interchanging Network";
            q[13].Ans = "Interconnected Network";






            q[14].quse = "প্রশ্ন:মাইক্রোসফট ওয়ার্ড ও ওপেন অফিস রাইটারের মধ্যে মিল কোন ক্ষেত্রে?";
            q[14].A = "উভয়ই ছবি সম্পাদনার সফটওয়্যার";
            q[14].B = "উভয়ই লেখালেখির সফটওয়্যার";
            q[14].C = "উভয়ই গান শোনার সফটওয়্যার";
            q[14].D = "উভয়ই ছবি দেখার সফটওয়্যার";
            q[14].Ans = "উভয়ই লেখালেখির সফটওয়্যার";


            label4.Text = mark.ToString();

            label4.Visible = true;


            if (number == 15)
            {


                MessageBox.Show("Your Mark Is :" + mark);

                this.Dispose();

            }


            else
            {


                this.label2.Text = q[number].quse;
                this.button1.Text = q[number].A;
                this.button2.Text = q[number].B;
                this.button3.Text = q[number].C;
                this.button4.Text = q[number].D;
                this.label3.Text = q[number].Ans;
                number++;

            }
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (label3.Text == button4.Text)
            {
                mark++;

            }
            if (track == 0)
            { quiz1(); }
            else { quiz2(); }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == button1.Text)
            {
                mark++;
                
            }


            if (track == 0)
            { quiz1(); }
            else { quiz2(); }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label3.Text == button2.Text)
            {
                mark++;

            }
            if (track == 0)
            { quiz1(); }
            else { quiz2(); }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == button3.Text)
            {
                mark++;

            }
            
            
            if (track == 0)
            { quiz1(); }
            else { quiz2(); }
          




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
