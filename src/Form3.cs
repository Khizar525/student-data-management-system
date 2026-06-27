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
    public partial class Form3 : Form
    {
        string path = @"C:\Users\USER\Desktop\Student_Data-Management_System\bin\Debug\net6.0-windows\Student.txt";
        bool found = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            foreach (string line in lines)
            {
                int indexOfSpace = line.IndexOf(' ');
                if (indexOfSpace != -1)
                {
                    string dataBeforeSpace = line.Substring(0, indexOfSpace);
                    if (enrTxt.Text == dataBeforeSpace)
                    {
                        found = true;

                        string[] parts = line.Split(' ');

                        string Cp = parts[1];
                        string Cf = parts[2];
                        string Ap = parts[3];
                        string Eng = parts[4];
                        string Ohs = parts[5];
                        string Calc = parts[6];
                        string Sum = parts[7];
                        string Grade = parts[8];


                        using (var f5 = new Form5())
                        {
                            f5.enrollment = enrTxt.Text;
                            f5.Cp = Cp;
                            f5.Cf = Cf;
                            f5.Ap = Ap;
                            f5.Eng = Eng;
                            f5.Ohs = Ohs;
                            f5.Calc = Calc;
                            f5.Sum = Sum;
                            f5.Grade = Grade;

                            this.Hide();
                            this.Close();
                            f5.ShowDialog();
                        }
                        break;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Student Not Found");
            }
        }
        private void enrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }
    }
}
