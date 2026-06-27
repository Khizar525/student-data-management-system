using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Data_Management_System
{
    public partial class Form4 : Form
    {
        int studentno = 1;
        string path = @"C:\Users\USER\Desktop\Student_Data-Management_System\bin\Debug\net6.0-windows\Student.txt";
        string grade;
        int limit;
        int sum;
        public Form4()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Select The Numbers Of Student First");
            }
            else
            {

                int x = int.Parse(textBox1.Text);
                string[] students = new string[x];
                studentLbl.Text = ("Student Number: " + studentno.ToString());
                limit = x;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Select The Numbers Of Student First");
            }
            else if (string.IsNullOrWhiteSpace(enrTxt.Text) || string.IsNullOrWhiteSpace(cpTxt.Text) || string.IsNullOrWhiteSpace(cfTxt.Text) || string.IsNullOrWhiteSpace(apTxt.Text) || string.IsNullOrWhiteSpace(calTxt.Text) || string.IsNullOrWhiteSpace(calTxt.Text) || string.IsNullOrWhiteSpace(ohsTxt.Text))
            {
                MessageBox.Show("Enter Data In All The Fields First ");
            }
            else if (int.Parse(cpTxt.Text) > 20 || int.Parse(cfTxt.Text) > 20 || int.Parse(apTxt.Text) > 20 || int.Parse(calTxt.Text) > 20 || int.Parse(calTxt.Text) > 20 || int.Parse(ohsTxt.Text) > 20)
            {
                MessageBox.Show("Numbers can't be Greater that 20");
            }
            else if (int.Parse(cpTxt.Text) < 0 || int.Parse(cfTxt.Text) < 0 || int.Parse(apTxt.Text) < 0 || int.Parse(calTxt.Text) < 0 || int.Parse(engTxt.Text) < 0 || int.Parse(ohsTxt.Text) < 0)
            {
                MessageBox.Show("One or more Numbers are Invalid");
            }
            else if (int.Parse(cpTxt.Text) >= 0 || int.Parse(cfTxt.Text) >= 0 || int.Parse(apTxt.Text) >= 0 || int.Parse(calTxt.Text) >= 0 || int.Parse(engTxt.Text) >= 0 || int.Parse(ohsTxt.Text) >= 0)
            {
                sum = int.Parse(cpTxt.Text) + int.Parse(cfTxt.Text) + int.Parse(apTxt.Text) + int.Parse(calTxt.Text) + int.Parse(engTxt.Text) + int.Parse(ohsTxt.Text);
                obtLbl.Text = "Obtained numbers: " + sum.ToString();

                if (sum > 150)
                {
                    grade = "Invalid Value";
                }
                else if (sum > 102)
                {
                    grade = "A+";
                }
                else if (sum >= 96)
                {
                    grade = "A-";
                }
                else if (sum >= 90)
                {
                    grade = "B+";
                }
                else if (sum >= 84)
                {
                    grade = "B";
                }
                else if (sum >= 78)
                {
                    grade = "B-";
                }
                else if (sum >= 72)
                {
                    grade = "C+";
                }
                else if (sum >= 69.6)
                {
                    grade = "C";
                }
                else if (sum >= 66)
                {
                    grade = "C-";
                }
                else if (sum >= 60)
                {
                    grade = "D";
                }
                else if (sum < 60 && sum >= 0)
                {
                    grade = "F";
                }
                else if (sum < 0)
                {
                    grade = "Invalid Grade";
                }
                gradeLbl.Text = "Obtained Grade: " + grade;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void enrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Select The Numbers Of Student First");
            }
            else if (sum == 0)

            {
                MessageBox.Show("You need to Calculate Before Save");
            }
            else
            {
                studentno++;
                if (studentno <= limit + 1)
                {
                    studentLbl.Text = ("Student : " + studentno.ToString());
                    var enrollment = enrTxt.Text;
                    var cp = cpTxt.Text;
                    var cf = cfTxt.Text;
                    var ap = apTxt.Text;
                    var eng = engTxt.Text;
                    var cal = calTxt.Text;
                    var ohs = ohsTxt.Text;
                    string[] student = { "\n" + enrollment + " \t\t" + cp + " \t" + cf + " \t" + ap + " \t" + eng + " \t" + ohs + " \t" + cal + " \t" + sum + " \t" + grade };
                    foreach (var item in student)
                    {
                        File.AppendAllText(path, item);
                    }
                    enrTxt.Text = "";
                    cpTxt.Text = "";
                    cfTxt.Text = "";
                    apTxt.Text = "";
                    engTxt.Text = "";
                    calTxt.Text = "";
                    ohsTxt.Text = "";
                    obtLbl.Text = "Obtained numbers: ";
                    gradeLbl.Text = "Obtained Grade: ";
                }
                else { MessageBox.Show("student limit reached"); }
            }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }

        private void studentLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ohsTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

