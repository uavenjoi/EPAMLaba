using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (Revers.Checked)
            {
                Revers.Text = "Revers Stroki: Chekced";
            }
            else
            {
                Revers.Text = "Revers Stroki:";
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(ToUpper.Checked)
            {
                ToUpper.Text = "Stroka to Upper: Chekced";
            } 
            else
            {
                ToUpper.Text = "Stroka to Upper";
            }
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Space.Checked)
            {
                Space.Text = "PasteSpace: Chekced";
            }
            else
            {
                Space.Text = "PasteSpace";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VivodStr.Text = VvodStr.Text;
            string str = VvodStr.Text;
            if(Revers.Checked)
            {
                str = RevStr.StrRev(str);// с использованием дополнительного класса
                //str = new String(str.Reverse().ToArray());//без использования дополнительного класса
            }
            if (ToUpper.Checked)
            {
                str = str.ToUpper();
            }
            if(Space.Checked)
            {
                str = PasteSpace.PastSp(str);
            }
            VivodStr.Text = str;          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}