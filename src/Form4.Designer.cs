namespace Student_Data_Management_System
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            studentLbl = new Label();
            cpTxt = new TextBox();
            engTxt = new TextBox();
            calTxt = new TextBox();
            label2 = new Label();
            label4 = new Label();
            cfTxt = new TextBox();
            apTxt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            calculate = new Button();
            obtLbl = new Label();
            gradeLbl = new Label();
            enrTxt = new TextBox();
            label8 = new Label();
            saveBtn = new Button();
            logoutBtn = new Button();
            label9 = new Label();
            ohsTxt = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(135, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(71, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(219, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // studentLbl
            // 
            studentLbl.Anchor = AnchorStyles.None;
            studentLbl.AutoSize = true;
            studentLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentLbl.Location = new Point(517, 94);
            studentLbl.Name = "studentLbl";
            studentLbl.Size = new Size(214, 25);
            studentLbl.TabIndex = 2;
            studentLbl.Text = "Student Number : Null";
            studentLbl.Click += studentLbl_Click;
            // 
            // cpTxt
            // 
            cpTxt.Anchor = AnchorStyles.None;
            cpTxt.Location = new Point(130, 236);
            cpTxt.Name = "cpTxt";
            cpTxt.Size = new Size(66, 23);
            cpTxt.TabIndex = 3;
            // 
            // engTxt
            // 
            engTxt.Anchor = AnchorStyles.None;
            engTxt.Location = new Point(551, 238);
            engTxt.Name = "engTxt";
            engTxt.Size = new Size(66, 23);
            engTxt.TabIndex = 4;
            // 
            // calTxt
            // 
            calTxt.Anchor = AnchorStyles.None;
            calTxt.Location = new Point(341, 238);
            calTxt.Name = "calTxt";
            calTxt.Size = new Size(66, 23);
            calTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(278, 61);
            label2.TabIndex = 12;
            label2.Text = "Total Students";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-1, -1);
            label4.Name = "label4";
            label4.Size = new Size(744, 69);
            label4.TabIndex = 13;
            label4.Text = "Bahria University";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cfTxt
            // 
            cfTxt.Anchor = AnchorStyles.None;
            cfTxt.Location = new Point(130, 289);
            cfTxt.Name = "cfTxt";
            cfTxt.Size = new Size(66, 23);
            cfTxt.TabIndex = 14;
            // 
            // apTxt
            // 
            apTxt.Anchor = AnchorStyles.None;
            apTxt.Location = new Point(341, 288);
            apTxt.Name = "apTxt";
            apTxt.Size = new Size(66, 23);
            apTxt.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 238);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 18;
            label1.Text = "Cp";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 286);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 19;
            label3.Text = "Cf";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(231, 236);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 20;
            label5.Text = "Calculus";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = SystemColors.ControlLight;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(461, 238);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 21;
            label6.Text = "Eng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(231, 286);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 22;
            label7.Text = "Ap";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            calculate.Anchor = AnchorStyles.None;
            calculate.Location = new Point(656, 259);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 23;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += button3_Click;
            // 
            // obtLbl
            // 
            obtLbl.Anchor = AnchorStyles.None;
            obtLbl.AutoSize = true;
            obtLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            obtLbl.Location = new Point(231, 347);
            obtLbl.Name = "obtLbl";
            obtLbl.Size = new Size(191, 25);
            obtLbl.TabIndex = 24;
            obtLbl.Text = "Obtained Numbers: ";
            // 
            // gradeLbl
            // 
            gradeLbl.Anchor = AnchorStyles.None;
            gradeLbl.AutoSize = true;
            gradeLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            gradeLbl.Location = new Point(259, 382);
            gradeLbl.Name = "gradeLbl";
            gradeLbl.Size = new Size(163, 25);
            gradeLbl.TabIndex = 25;
            gradeLbl.Text = "Obtained Grade: ";
            // 
            // enrTxt
            // 
            enrTxt.Anchor = AnchorStyles.None;
            enrTxt.Location = new Point(395, 176);
            enrTxt.Name = "enrTxt";
            enrTxt.PlaceholderText = "00-000000-000";
            enrTxt.Size = new Size(94, 23);
            enrTxt.TabIndex = 26;
            enrTxt.TextAlign = HorizontalAlignment.Center;
            enrTxt.TextChanged += enrTxt_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = SystemColors.ControlLight;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(271, 176);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 27;
            label8.Text = "Enrollment";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.None;
            saveBtn.Location = new Point(656, 412);
            saveBtn.Name = "saveBtn";
            saveBtn.RightToLeft = RightToLeft.No;
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 28;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.None;
            logoutBtn.Location = new Point(12, 412);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 23);
            logoutBtn.TabIndex = 29;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.BackColor = SystemColors.ControlLight;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(461, 289);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 31;
            label9.Text = "Ohs";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ohsTxt
            // 
            ohsTxt.Anchor = AnchorStyles.None;
            ohsTxt.Location = new Point(551, 289);
            ohsTxt.Name = "ohsTxt";
            ohsTxt.Size = new Size(66, 23);
            ohsTxt.TabIndex = 30;
            ohsTxt.TextChanged += ohsTxt_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 447);
            Controls.Add(label9);
            Controls.Add(ohsTxt);
            Controls.Add(logoutBtn);
            Controls.Add(saveBtn);
            Controls.Add(enrTxt);
            Controls.Add(gradeLbl);
            Controls.Add(obtLbl);
            Controls.Add(calculate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(apTxt);
            Controls.Add(cfTxt);
            Controls.Add(label4);
            Controls.Add(calTxt);
            Controls.Add(engTxt);
            Controls.Add(cpTxt);
            Controls.Add(studentLbl);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label8);
            Name = "Form4";
            Text = "Students_DataBase";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label studentLbl;
        private TextBox cpTxt;
        private TextBox engTxt;
        private TextBox calTxt;
        private Label label2;
        private Label label4;
        private TextBox cfTxt;
        private TextBox apTxt;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button calculate;
        private Label obtLbl;
        private Label gradeLbl;
        private TextBox enrTxt;
        private Label label8;
        private Button saveBtn;
        private Button logoutBtn;
        private Label label9;
        private TextBox ohsTxt;
    }
}