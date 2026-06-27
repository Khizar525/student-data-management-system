namespace Student_Data_Management_System
{
    partial class Form3
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
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            enrTxt = new TextBox();
            textBox2 = new TextBox();
            back_btn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-2, 0);
            label4.Name = "label4";
            label4.Size = new Size(502, 64);
            label4.TabIndex = 9;
            label4.Text = "Bahria University";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 110);
            label2.Name = "label2";
            label2.Size = new Size(252, 70);
            label2.TabIndex = 12;
            label2.Text = "Enrollment";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 238);
            label1.Name = "label1";
            label1.Size = new Size(252, 70);
            label1.TabIndex = 13;
            label1.Text = "Password:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(286, 325);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 15;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // enrTxt
            // 
            enrTxt.Anchor = AnchorStyles.None;
            enrTxt.Location = new Point(184, 134);
            enrTxt.Name = "enrTxt";
            enrTxt.Size = new Size(100, 23);
            enrTxt.TabIndex = 16;
            enrTxt.TextChanged += enrTxt_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(184, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
            textBox2.UseSystemPasswordChar = true;
            // 
            // back_btn
            // 
            back_btn.Anchor = AnchorStyles.None;
            back_btn.BackColor = SystemColors.ButtonHighlight;
            back_btn.Location = new Point(109, 325);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 18;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 397);
            Controls.Add(back_btn);
            Controls.Add(textBox2);
            Controls.Add(enrTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "Form3";
            Text = "Student_Login";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox enrTxt;
        private TextBox textBox2;
        private Button back_btn;
    }
}