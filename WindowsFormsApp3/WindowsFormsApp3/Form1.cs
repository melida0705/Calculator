using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        bool operacija = false;
        double prvi;
        String operand;
        String jednako;


        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "0";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacija = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
           
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "1";
                }
                else
                {
                    this.textBox1.Text += 1;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "2";
                }
                else
                {
                    this.textBox1.Text += 2;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "3";
                }
                else
                {
                    this.textBox1.Text += 3;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "4";
                }
                else
                {
                    this.textBox1.Text += 4;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "5";
                }
                else
                {
                    this.textBox1.Text += 5;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "6";
                }
                else
                {
                    this.textBox1.Text += 6;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "7";
                }
                else
                {
                    this.textBox1.Text += 7;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "8";
                }
                else
                {
                    this.textBox1.Text += 8;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            String tekst = this.textBox1.Text;
            if (!operacija)
            {
                if (tekst == "0")
                {
                    this.textBox1.Text = "9";
                }
                else
                {
                    this.textBox1.Text += 9;
                }

            }
            else
            {
                operacija = false;
                this.textBox1.Text = "9";
            }
        }

        

        private void btnDiv_Click_1(object sender, EventArgs e)
        {
            operacija = true;

            prvi = Convert.ToDouble(this.textBox1.Text);
            operand = "/";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operacija = true;
            prvi = Convert.ToDouble(this.textBox1.Text);
            operand = "+";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacija = true;
            prvi = Convert.ToDouble(this.textBox1.Text);
            operand = "*";
        }

        private void btnEqu_Click(object sender, EventArgs e)
        { 
            double drugi;
            double rezultat;
            drugi = Convert.ToDouble(this.textBox1.Text);
           
            if (operand=="+")
            {
                rezultat = (prvi + drugi);
                this.textBox1.Text = Convert.ToString(rezultat);
                prvi = rezultat;
            
            }
           
           
            if (operand == "/")
            {
                if (drugi==0)
                {
                    this.textBox1.Text = "Error";
                }
                else
                {
                    rezultat = (prvi / drugi);
                    this.textBox1.Text = Convert.ToString(rezultat);
                    prvi = rezultat;
                }
            }
            if (operand == "-")
            {
                rezultat = (prvi - drugi);
                this.textBox1.Text = Convert.ToString(rezultat);
                prvi = rezultat;
            }
            if(operand=="*")
            {   
                
                    rezultat = (prvi * drugi);
                    this.textBox1.Text = Convert.ToString(rezultat);
                    prvi = rezultat;
                
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            operacija = true;
            prvi = Convert.ToDouble(this.textBox1.Text);
            operand = "-";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text!="0")
            { this.textBox1.Text += "0"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ".";
         
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            
        }
    }
}
