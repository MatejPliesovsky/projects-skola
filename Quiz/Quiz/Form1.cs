using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {          
           InitializeComponent();
           label8.Visible= false;
        }
         
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string Answer1 = "arpanet";
        private string user1;
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();
            if (date == "1.1.1970")
            {
                count++;
                
            }
            else
            {
                count = 0;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked == true)
            {
                 if (radioButton1.Checked == true)
                {
                    count=0;
                }
                else
                {
                    count++;
                }
            }
            else 
            if (radioButton2.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    count++;
                }
                else
                {
                    count=0;
                }
            }
            else if (radioButton3.Checked == false)
            {
                if (radioButton1.Checked == true)
                {
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    count++;
                }
                else
                {
                    count=0;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    count++;
                }
                else
                {
                    count=0;
                }
            }
            else if (checkBox2.Checked == true)
            {
                if (checkBox2.Checked == true)
                {
                    count = 0;
                }
                else
                {
                    count=0;
                }
            }
            else
            if (checkBox3.Checked == true)
            {
                if (checkBox3.Checked == true)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            else
            if (checkBox4.Checked == true)
            {
                
                    count=0;
                }
                else
                {
                    count=0;
                }
           
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
                        
        label8.Visible = true;
            
            label8.Text = "Correct answers: " + count;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Equals("Hviezdicova"))
            {
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String str = "arpanet";
            if (textBox1.Text.ToLower().Trim() == str)
            {                
                count++;
            }

            else
            {
                count=0;
            }
        }
    }

}


 
