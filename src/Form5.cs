using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Student_Data_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // enrLbl.Text = ("Enrollment Number: " + text);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
            this.Close();
        }
        public string enrollment { get; set; }
        public string Cp { get; set; }
        public string Cf { get; set; }
        public string Ap { get; set; }
        public string Eng { get; set; }
        public string Ohs { get; set; }
        public string Calc { get; set; }
        public string Sum { get; set; }
        public string Grade { get; set; }

        private void Form5_Load(object sender, EventArgs e)
        {
            enrLbl.Text = ("Welcome Student : " + enrollment);
            cp_lbl.Text = ("Cp: " + Cp);
            cf_lbl.Text = ("Cf: " + Cf);
            ap_lbl.Text = ("Ap: " + Ap);
            eng_lbl.Text = ("Eng: " + Eng);
            ohs_lbl.Text = ("Ohs: " + Ohs);
            cal_lbl.Text = ("Calc: " + Calc);
            obt_Lbl.Text = ("Obtained Numbers: " + Sum);
            grade_Lbl.Text = ("Obtained Grade: " + Grade);
        }
    }
}
