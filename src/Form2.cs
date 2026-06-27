using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Data_Management_System
{
    public partial class Form2 : Form
    {
        string path = @"C:\Users\USER\Desktop\Student_Data-Management_System\bin\Debug\net6.0-windows\Admin.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string username = sr.ReadLine();
                string password = sr.ReadLine();
                if (userTxt.Text == username && passTxt.Text == password)
                {
                    Form4 form = new Form4();
                    this.Close();
                    form.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
