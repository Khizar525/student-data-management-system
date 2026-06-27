namespace Student_Data_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Teacher = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // Teacher
            // 
            Teacher.Anchor = AnchorStyles.None;
            Teacher.BackColor = SystemColors.ButtonHighlight;
            Teacher.Location = new Point(89, 251);
            Teacher.Name = "Teacher";
            Teacher.Size = new Size(75, 23);
            Teacher.TabIndex = 0;
            Teacher.Text = "Sign In";
            Teacher.UseVisualStyleBackColor = false;
            Teacher.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 31);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(-3, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(486, 19);
            textBox1.TabIndex = 3;
            textBox1.Text = "PLease Choose \r\nYour Respective\r\n Field";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 154);
            label2.Name = "label2";
            label2.Size = new Size(179, 132);
            label2.TabIndex = 4;
            label2.Text = "Admin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(257, 154);
            label3.Name = "label3";
            label3.Size = new Size(172, 132);
            label3.TabIndex = 5;
            label3.Text = "Student";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-3, -5);
            label4.Name = "label4";
            label4.Size = new Size(486, 64);
            label4.TabIndex = 7;
            label4.Text = "Bahria University";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(305, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // exit_btn
            // 
            exit_btn.Anchor = AnchorStyles.None;
            exit_btn.Location = new Point(198, 332);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 23);
            exit_btn.TabIndex = 9;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(481, 390);
            Controls.Add(exit_btn);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Teacher);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Student Data Management System For Mids Result";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Teacher;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button exit_btn;
    }
}