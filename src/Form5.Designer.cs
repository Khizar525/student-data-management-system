namespace Student_Data_Management_System
{
    partial class Form5
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
            enrLbl = new Label();
            logoutBtn = new Button();
            cp_lbl = new Label();
            cf_lbl = new Label();
            ap_lbl = new Label();
            cal_lbl = new Label();
            eng_lbl = new Label();
            ohs_lbl = new Label();
            obt_Lbl = new Label();
            grade_Lbl = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Navy;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(-1, -6);
            label4.Name = "label4";
            label4.Size = new Size(536, 64);
            label4.TabIndex = 9;
            label4.Text = "Bahria University";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enrLbl
            // 
            enrLbl.Anchor = AnchorStyles.None;
            enrLbl.AutoSize = true;
            enrLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            enrLbl.Location = new Point(103, 83);
            enrLbl.Name = "enrLbl";
            enrLbl.Size = new Size(332, 25);
            enrLbl.TabIndex = 10;
            enrLbl.Text = "Welcome Student : XX-XXXXXX-XXX";
            // 
            // logoutBtn
            // 
            logoutBtn.Anchor = AnchorStyles.None;
            logoutBtn.Location = new Point(12, 381);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 23);
            logoutBtn.TabIndex = 30;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // cp_lbl
            // 
            cp_lbl.Anchor = AnchorStyles.None;
            cp_lbl.BackColor = SystemColors.ControlLight;
            cp_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cp_lbl.Location = new Point(42, 205);
            cp_lbl.Name = "cp_lbl";
            cp_lbl.Size = new Size(79, 22);
            cp_lbl.TabIndex = 31;
            cp_lbl.Text = "Cp: XX";
            cp_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cf_lbl
            // 
            cf_lbl.Anchor = AnchorStyles.None;
            cf_lbl.BackColor = SystemColors.ControlLight;
            cf_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cf_lbl.Location = new Point(42, 269);
            cf_lbl.Name = "cf_lbl";
            cf_lbl.Size = new Size(79, 22);
            cf_lbl.TabIndex = 32;
            cf_lbl.Text = "CF: XX";
            cf_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ap_lbl
            // 
            ap_lbl.Anchor = AnchorStyles.None;
            ap_lbl.BackColor = SystemColors.ControlLight;
            ap_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ap_lbl.Location = new Point(216, 205);
            ap_lbl.Name = "ap_lbl";
            ap_lbl.Size = new Size(79, 22);
            ap_lbl.TabIndex = 33;
            ap_lbl.Text = "Ap: XX";
            ap_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cal_lbl
            // 
            cal_lbl.Anchor = AnchorStyles.None;
            cal_lbl.BackColor = SystemColors.ControlLight;
            cal_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cal_lbl.Location = new Point(216, 269);
            cal_lbl.Name = "cal_lbl";
            cal_lbl.Size = new Size(79, 22);
            cal_lbl.TabIndex = 34;
            cal_lbl.Text = "Calc: XX";
            cal_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eng_lbl
            // 
            eng_lbl.Anchor = AnchorStyles.None;
            eng_lbl.BackColor = SystemColors.ControlLight;
            eng_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eng_lbl.Location = new Point(394, 205);
            eng_lbl.Name = "eng_lbl";
            eng_lbl.Size = new Size(79, 22);
            eng_lbl.TabIndex = 35;
            eng_lbl.Text = "Eng: XX";
            eng_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ohs_lbl
            // 
            ohs_lbl.Anchor = AnchorStyles.None;
            ohs_lbl.BackColor = SystemColors.ControlLight;
            ohs_lbl.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ohs_lbl.Location = new Point(394, 269);
            ohs_lbl.Name = "ohs_lbl";
            ohs_lbl.Size = new Size(79, 22);
            ohs_lbl.TabIndex = 36;
            ohs_lbl.Text = "Ohs: XX";
            ohs_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // obt_Lbl
            // 
            obt_Lbl.Anchor = AnchorStyles.None;
            obt_Lbl.AutoSize = true;
            obt_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            obt_Lbl.Location = new Point(241, 331);
            obt_Lbl.Name = "obt_Lbl";
            obt_Lbl.Size = new Size(220, 25);
            obt_Lbl.TabIndex = 37;
            obt_Lbl.Text = "Obtained Numbers:  XX";
            // 
            // grade_Lbl
            // 
            grade_Lbl.Anchor = AnchorStyles.None;
            grade_Lbl.AutoSize = true;
            grade_Lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grade_Lbl.Location = new Point(269, 367);
            grade_Lbl.Name = "grade_Lbl";
            grade_Lbl.Size = new Size(192, 25);
            grade_Lbl.TabIndex = 38;
            grade_Lbl.Text = "Obtained Grade:  XX";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = SystemColors.Control;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(165, 134);
            label8.Name = "label8";
            label8.Size = new Size(191, 23);
            label8.TabIndex = 39;
            label8.Text = "Here's Your Mid Result";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 416);
            Controls.Add(label8);
            Controls.Add(grade_Lbl);
            Controls.Add(obt_Lbl);
            Controls.Add(ohs_lbl);
            Controls.Add(eng_lbl);
            Controls.Add(cal_lbl);
            Controls.Add(ap_lbl);
            Controls.Add(cf_lbl);
            Controls.Add(cp_lbl);
            Controls.Add(logoutBtn);
            Controls.Add(enrLbl);
            Controls.Add(label4);
            Name = "Form5";
            Text = "Result";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label enrLbl;
        private Button logoutBtn;
        private Label cp_lbl;
        private Label cf_lbl;
        private Label ap_lbl;
        private Label cal_lbl;
        private Label eng_lbl;
        private Label ohs_lbl;
        private Label obt_Lbl;
        private Label grade_Lbl;
        private Label label8;
    }
}