namespace TASKMANAGER
{
    partial class registrationForm
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
            this.groupBoxRegistration = new System.Windows.Forms.GroupBox();
            this.labelRegFName = new System.Windows.Forms.Label();
            this.textBoxRegFName = new System.Windows.Forms.TextBox();
            this.labelRegSName = new System.Windows.Forms.Label();
            this.textBoxRegSName = new System.Windows.Forms.TextBox();
            this.labelRegSurname = new System.Windows.Forms.Label();
            this.textBoxRegSurname = new System.Windows.Forms.TextBox();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.labelRegPass = new System.Windows.Forms.Label();
            this.labelRegLogin = new System.Windows.Forms.Label();
            this.textBoxRegPass = new System.Windows.Forms.TextBox();
            this.textBoxRegLogin = new System.Windows.Forms.TextBox();
            this.groupBoxRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRegistration
            // 
            this.groupBoxRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRegistration.AutoSize = true;
            this.groupBoxRegistration.Controls.Add(this.labelRegFName);
            this.groupBoxRegistration.Controls.Add(this.textBoxRegFName);
            this.groupBoxRegistration.Controls.Add(this.labelRegSName);
            this.groupBoxRegistration.Controls.Add(this.textBoxRegSName);
            this.groupBoxRegistration.Controls.Add(this.labelRegSurname);
            this.groupBoxRegistration.Controls.Add(this.textBoxRegSurname);
            this.groupBoxRegistration.Controls.Add(this.buttonRegistration);
            this.groupBoxRegistration.Controls.Add(this.labelRegPass);
            this.groupBoxRegistration.Controls.Add(this.labelRegLogin);
            this.groupBoxRegistration.Controls.Add(this.textBoxRegPass);
            this.groupBoxRegistration.Controls.Add(this.textBoxRegLogin);
            this.groupBoxRegistration.Location = new System.Drawing.Point(109, 47);
            this.groupBoxRegistration.Name = "groupBoxRegistration";
            this.groupBoxRegistration.Size = new System.Drawing.Size(446, 359);
            this.groupBoxRegistration.TabIndex = 1;
            this.groupBoxRegistration.TabStop = false;
            // 
            // labelRegFName
            // 
            this.labelRegFName.AutoSize = true;
            this.labelRegFName.Location = new System.Drawing.Point(209, 49);
            this.labelRegFName.Name = "labelRegFName";
            this.labelRegFName.Size = new System.Drawing.Size(29, 13);
            this.labelRegFName.TabIndex = 10;
            this.labelRegFName.Text = "Имя";
            // 
            // textBoxRegFName
            // 
            this.textBoxRegFName.Location = new System.Drawing.Point(134, 65);
            this.textBoxRegFName.Name = "textBoxRegFName";
            this.textBoxRegFName.Size = new System.Drawing.Size(179, 20);
            this.textBoxRegFName.TabIndex = 9;
            // 
            // labelRegSName
            // 
            this.labelRegSName.AutoSize = true;
            this.labelRegSName.Location = new System.Drawing.Point(195, 88);
            this.labelRegSName.Name = "labelRegSName";
            this.labelRegSName.Size = new System.Drawing.Size(56, 13);
            this.labelRegSName.TabIndex = 8;
            this.labelRegSName.Text = "Фамилия";
            // 
            // textBoxRegSName
            // 
            this.textBoxRegSName.Location = new System.Drawing.Point(134, 104);
            this.textBoxRegSName.Name = "textBoxRegSName";
            this.textBoxRegSName.Size = new System.Drawing.Size(179, 20);
            this.textBoxRegSName.TabIndex = 7;
            // 
            // labelRegSurname
            // 
            this.labelRegSurname.AutoSize = true;
            this.labelRegSurname.Location = new System.Drawing.Point(196, 127);
            this.labelRegSurname.Name = "labelRegSurname";
            this.labelRegSurname.Size = new System.Drawing.Size(54, 13);
            this.labelRegSurname.TabIndex = 6;
            this.labelRegSurname.Text = "Отчество";
            // 
            // textBoxRegSurname
            // 
            this.textBoxRegSurname.Location = new System.Drawing.Point(134, 143);
            this.textBoxRegSurname.Name = "textBoxRegSurname";
            this.textBoxRegSurname.Size = new System.Drawing.Size(179, 20);
            this.textBoxRegSurname.TabIndex = 5;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Location = new System.Drawing.Point(158, 265);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(130, 23);
            this.buttonRegistration.TabIndex = 4;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // labelRegPass
            // 
            this.labelRegPass.AutoSize = true;
            this.labelRegPass.Location = new System.Drawing.Point(201, 205);
            this.labelRegPass.Name = "labelRegPass";
            this.labelRegPass.Size = new System.Drawing.Size(45, 13);
            this.labelRegPass.TabIndex = 3;
            this.labelRegPass.Text = "Пароль";
            // 
            // labelRegLogin
            // 
            this.labelRegLogin.AutoSize = true;
            this.labelRegLogin.Location = new System.Drawing.Point(204, 166);
            this.labelRegLogin.Name = "labelRegLogin";
            this.labelRegLogin.Size = new System.Drawing.Size(38, 13);
            this.labelRegLogin.TabIndex = 2;
            this.labelRegLogin.Text = "Логин";
            // 
            // textBoxRegPass
            // 
            this.textBoxRegPass.Location = new System.Drawing.Point(134, 224);
            this.textBoxRegPass.Name = "textBoxRegPass";
            this.textBoxRegPass.Size = new System.Drawing.Size(179, 20);
            this.textBoxRegPass.TabIndex = 1;
            // 
            // textBoxRegLogin
            // 
            this.textBoxRegLogin.Location = new System.Drawing.Point(134, 182);
            this.textBoxRegLogin.Name = "textBoxRegLogin";
            this.textBoxRegLogin.Size = new System.Drawing.Size(179, 20);
            this.textBoxRegLogin.TabIndex = 0;
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBoxRegistration);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "registrationForm";
            this.Text = "registrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registrationForm_FormClosing);
            this.groupBoxRegistration.ResumeLayout(false);
            this.groupBoxRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistration;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Label labelRegPass;
        private System.Windows.Forms.Label labelRegLogin;
        private System.Windows.Forms.TextBox textBoxRegPass;
        private System.Windows.Forms.TextBox textBoxRegLogin;
        private System.Windows.Forms.Label labelRegFName;
        private System.Windows.Forms.TextBox textBoxRegFName;
        private System.Windows.Forms.Label labelRegSName;
        private System.Windows.Forms.TextBox textBoxRegSName;
        private System.Windows.Forms.Label labelRegSurname;
        private System.Windows.Forms.TextBox textBoxRegSurname;
    }
}