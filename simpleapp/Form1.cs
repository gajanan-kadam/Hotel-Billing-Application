using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            checkBox1.Checked = false;
            textBox1.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v = 20;
            double p = 20;
            double i = 30;
            double b = 30;
            double bh = 40;
            double pani = 15;
            double q1 = Convert.ToDouble(textBox1.Text)*v;
            double q2 = Convert.ToDouble(textBox3.Text)*p;
            double q3 = Convert.ToDouble(textBox4.Text)*i;
            double q4 = Convert.ToDouble(textBox5.Text)*b;
            double q5 = Convert.ToDouble(textBox6.Text)*bh;
            double q6 = Convert.ToDouble(textBox7.Text)*pani;
            double total = q1+q2+q3+q4+q5+q6;
            textBox2.Text = Convert.ToString(total);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {

                textBox1.Text = "0";
                textBox1.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {

                textBox3.Text = "0";
                textBox3.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {

                textBox4.Text = "0";
                textBox4.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {

                textBox5.Text = "0";
                textBox5.Enabled = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {

                textBox6.Text = "0";
                textBox6.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {

                textBox7.Text = "0";
                textBox7.Enabled = false;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText("        Gajanan Hotel"+Environment.NewLine);            
            richTextBox1.AppendText("----------------------------------------------" + Environment.NewLine);
            if (checkBox1.Checked == true) { richTextBox1.AppendText("VADA_PAW : " + textBox1.Text  + Environment.NewLine); }
            if (checkBox2.Checked == true) { richTextBox1.AppendText("POHA : " + textBox3.Text  + Environment.NewLine); }
            if (checkBox3.Checked == true) { richTextBox1.AppendText("IDLI : " + textBox4.Text  + Environment.NewLine); }
            if (checkBox4.Checked == true) { richTextBox1.AppendText("BHEL : " + textBox5.Text  + Environment.NewLine); }
            if (checkBox5.Checked == true) { richTextBox1.AppendText("BHAJI : " + textBox6.Text  + Environment.NewLine); }
            if (checkBox6.Checked == true) { richTextBox1.AppendText("PANI PURI: " + textBox7.Text  + Environment.NewLine); }
            richTextBox1.AppendText("----------------------------------------------"+Environment.NewLine);
            if (textBox2.Text != "0") { richTextBox1.AppendText("Total Amount "+textBox2.Text + " RS"+Environment.NewLine); }
            
            richTextBox1.AppendText("----------------------------------------------"+Environment.NewLine);
            richTextBox1.AppendText(label6.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void Printer_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }
    }
}
