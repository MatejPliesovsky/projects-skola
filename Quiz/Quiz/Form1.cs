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
         
        public int count = 0;

        private System.DateTime rightDate = new System.DateTime(1970, 1, 1, 0, 0, 0);

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           System.DateTime date = new System.DateTime();
            date = dateTimePicker1.Value;
            if (date.Equals(rightDate))
            {
                count++;
                
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
            if (radioButton2.Checked == true)
            {
                count++;
                }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            if (radioButton5.Checked == true)
            {
                count++;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox4.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                count++;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            count = 0;
            groupBox1_Enter(button1, null);
            groupBox2_Enter(button1, null);
            groupBox3_Enter(button1, null);
            comboBox1_SelectedIndexChanged(button1, null);
            textBox1_TextChanged(button1, null);
            dateTimePicker1_ValueChanged(button1, null);

            label8.Visible = true;
            
            label8.Text = "Correct answers: " + count;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text.Equals("Hviezdicova"))
            {
                count++;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String str = "arpanet";
            if (textBox1.Text.ToLower().Trim() == str)
            {                
                count++;
            }

        }
    }

}


 
