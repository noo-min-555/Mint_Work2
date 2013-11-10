using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string set1,set2,set3,set4 ;
           
            //เพศ
            if (radioButton1.Checked == true)
            {
                set1 = " ชาย" ;
            }
            else
              set1= " หญิง";
            //ความเครียดส่งผลต่อชีวิตประจำวันมากหรือไม่
            if (radioButton3.Checked == true)
            {
                set2 = " มาก" ;
            }
            else if (radioButton4.Checked == true)
            {
                set2= " ปานกลาง" ;
            }
            else if (radioButton5.Checked == true)
            {
                set2= " น้อย";
            }
            else if (radioButton6.Checked == true)
            {
                set2 = " ไม่ส่งผลเลย"  ;
            }
            else if (radioButton7.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    set2= " อื่น ๆ : กรุณกรอกข้อมูล"  ;
                }
                else
                {
                    set2= " อื่น ๆ : "  ;
                }
            }
            else
            {
                set2= " มาก"  ;
            }
    //ท่านมีความเครียดด้านใดบ้าง
            if (radioButton8.Checked == true)
            {
                set3= " ครอบครัว"  ;
            }
            else if (radioButton9.Checked == true)
            {
                set3= " เพื่อน"  ;
            }
            else if (radioButton10.Checked == true)
            {
                set3= " การเมือง"  ;
            }
            else if (radioButton11.Checked == true)
            {
                set3 = " การเรียน"  ;
            }
            else if (radioButton12.Checked == true)
            {
                set3= " ความรัก"  ;
            }
            else if (radioButton13.Checked == true)
            {
                set3 =  " สภาพอากาศ"  ;
            }
            else if (radioButton14.Checked == true)
            {
                set3 =  " การเงิน"  ;
            }
            else if (radioButton15.Checked == true)
            {
                if (textBox2.Text == "")
                {
                    set3= " อื่น ๆ : กรุณากรอกข้อมูล"  ;
                }
                else
                {
                   set3= " อื่น ๆ :" + textBox2.Text ;
                }
            }
            else
            {
                set3= "  ครอบครัว"  ;
            }
            //มีวิธีแก้ปัญหาความเครียดอย่างไร
            if (radioButton16.Checked == true)
            {
                set4 = " ปรึกษาเพือน" ;
            }
            else if (radioButton17.Checked == true)
            {
                set4= " ปรึกษาครอบครัว";
            }
            else if (radioButton18.Checked == true)
            {
                set4= " ปรึกษาครูบาร์อาจารย์" ;
            }
            else if (radioButton19.Checked == true)
            {
                set4= " ปรึกษาจิตแพทย์" ;
            }
            else if (radioButton20.Checked == true)
            {
               set4= " เก็บไว้คนเดียว" ;
            }
            else if (radioButton21 .Checked == true )
            {
                if (textBox3 .Text =="")
                {
                   set4 = " อื่น ๆ : กรุณากรอกข้อมูล"  ;
                }
                else 
                {
                    set4= " อื่น ๆ : " + textBox3.Text  ;
                }
            }
            else 
            {
              set4 = " ปรึกษาเพือน"  ;
            }

            Form2 frm = new Form2(set1,set2,set3,set4 );
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
