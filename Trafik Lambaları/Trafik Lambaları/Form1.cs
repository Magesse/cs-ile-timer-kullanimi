using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 70;
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            label6.Text = Convert.ToString(s);
            s--;
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Second.ToString();
            if (s>=40)
            {
                
               
                    button1.BackColor = Color.Red;
                    label7.Text = "Bekle";
                
                
            }
            if (s<=39 && s>=30)
            {
                
                    button2.BackColor = Color.Yellow;
                    button1.BackColor = Color.White;
                     label8.Text = "Hazırlan";
                     label7.Text = "";


            }
            if (s<=30 && s>= 0)
            {
                
                
                    button3.BackColor = Color.Green;
                    button2.BackColor = Color.White;
                     button1.BackColor = Color.White;
                      label9.Text = "Geç";
                      label8.Text = "";


            }
            if (s==0)
            {
                s=70;
                button3.BackColor = Color.White;
                label9.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
