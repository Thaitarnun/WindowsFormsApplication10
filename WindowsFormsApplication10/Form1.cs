using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str, op2, op3, op4, op5, op6, op7, op8;
            //เพศ
            if (optMale.Checked == true)
            {
                str = "ชาย";
            }
            else
            {
                str = "หญิง";
            }
            // อายุ
            if (opt3.Checked == true)
            {
                op2 = "น้อยกว่า 20 ปี";
            }
            else if (opt4.Checked == true)
            {
                op2 = "20-30 ปี";
            }
            else if (opt5.Checked == true)
            {
                op2 = "30-40 ปี";
            }
            else
            {
                op2 = "มากกว่า 40 ปี";
            }
            //ทำงานมากี่ปี
            if (opt7.Checked == true)
            {
                op3 = "ต่ำกว่า 5 ปี";
            }
            else if (opt8.Checked == true)
            {
                op3 = "5 - 10 ปี";
            }
            else
            {
                op3 = "มากกว่า 10 ปี";
            }
            //คุณตรวจสุขภาพบ่อยแค่ไหน
            if (opt10.Checked == true)
            {
                op4 = "บ่อยมาก";
            }
            else if (opt11.Checked == true)
            {
                op4 = "บ่อย";
            }
            else if (opt12.Checked == true)
            {
                op4 = "พอสมควร";
            }
            else if (opt13.Checked == true)
            {
                op4 = "น้อย";
            }
            else
            {
                op4 = "ไม่เคยตรวจ";
            }
            // คุณป่วยบ่อยแค่ไหน
            if (opt15.Checked == true)
            {
                op5 = "ประจำ";
            }
            else if (opt16.Checked == true)
            {
                op5 = "เป็นบางครั้ง";
            }
            else if (opt17.Checked == true)
            {
                op5 = "นาน ๆ ครั้ง";
            }
            else
            {
                op5 = "ไม่เคยป่วย";
            }
            //วิธีการตรวจสุขภาพของคุณ
            if (opt19.Checked == true)
            {
                op6 = "เข้าคลีนิก";
            }
            else if (opt20.Checked == true)
            {
                op6 = "ตรวจที่โรงพยาบาล";
            }
            else if (opt21.Checked == true)
            {
                op6 = "อนามัย";
            }
            else
            {
                op6 = "ไม่เคยตรวจ";
            }
            //วิธีรักษาสุขภาพของคุณ
            if (opt23.Checked == true)
            {
                op7 = "กินอาหารที่มีประโยชน์";
            }
            else if (opt24.Checked == true)
            {
                op7 = "ออกกำลังกาย";
            }
            else if (opt25.Checked == true)
            {
                op7 = "ทานอาหารเสริม";
            }
            else if (opt26.Checked == true)
            {
                op7 = "นอนพักผ่อนมากมาก";
            }
            else
            {
                op7 = "อยู่ที่อากาศบริสุทธิ์";
            }
            //คุณใส่ใจกับการตรวจสุขภาพมากแค่ไหน
            if (opt28.Checked == true)
            {
                op8 = "มากที่สุด";
            }
            else if (opt29.Checked == true)
            {
                op8 = "มาก";
            }
            else if (opt30.Checked == true)
            {
                op8 = "พอสมควร";
            }
            else if (opt31.Checked == true)
            {
                op8 = "น้อย";
            }
            else
            {
                op8 = "ไม่เคยใส่ใจ";
            }
            Form2 frm = new Form2(str, op2, op3, op4, op5, op6, op7, op8);
            frm.Show();
        }
    }
}
