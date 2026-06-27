namespace Student_Data_Management_System
{
    partial class Form2
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
            userTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            passTxt = new TextBox();
            button1 = new Button();
            back_btn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-31, -1);
            label4.Name = "label4";
            label4.Size = new Size(521, 64);
            label4.TabIndex = 8;
            label4.Text = "Bahria University";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userTxt
            // 
            userTxt.Anchor = AnchorStyles.None;
            userTxt.Location = new Point(182, 138);
            userTxt.Name = "userTxt";
            userTxt.Size = new Size(100, 23);
            userTxt.TabIndex = 9;
            userTxt.TextChanged += userTxt_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 108);
            label2.Name = "label2";
            label2.Size = new Size(252, 70);
            label2.TabIndex = 11;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(103, 221);
            label1.Name = "label1";
            label1.Size = new Size(252, 70);
            label1.TabIndex = 12;
            label1.Text = "Password:";
            // 
            // passTxt
            // 
            passTxt.Anchor = AnchorStyles.None;
            passTxt.Location = new Point(182, 251);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(100, 23);
            passTxt.TabIndex = 13;
            passTxt.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(103, 316);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // back_btn
            // 
            back_btn.Anchor = AnchorStyles.None;
            back_btn.BackColor = SystemColors.ButtonHighlight;
            back_btn.Location = new Point(280, 316);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(75, 23);
            back_btn.TabIndex = 16;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 361);
            Controls.Add(back_btn);
            Controls.Add(button1);
            Controls.Add(passTxt);
            Controls.Add(userTxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Admin_Login";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox userTxt;
        private Label label2;
        private Label label1;
        private TextBox passTxt;
        private Button button1;
        private Button back_btn;
    }
}