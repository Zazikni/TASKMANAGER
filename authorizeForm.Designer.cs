namespace TASKMANAGER
{
    partial class authorizeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxAuthorize = new System.Windows.Forms.GroupBox();
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.labelAuthPass = new System.Windows.Forms.Label();
            this.labelAuthLogin = new System.Windows.Forms.Label();
            this.textBoxAuthPass = new System.Windows.Forms.TextBox();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.groupBoxAuthorize.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAuthorize
            // 
            this.groupBoxAuthorize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAuthorize.Controls.Add(this.buttonAuthorize);
            this.groupBoxAuthorize.Controls.Add(this.labelAuthPass);
            this.groupBoxAuthorize.Controls.Add(this.labelAuthLogin);
            this.groupBoxAuthorize.Controls.Add(this.textBoxAuthPass);
            this.groupBoxAuthorize.Controls.Add(this.textBoxAuthLogin);
            this.groupBoxAuthorize.Location = new System.Drawing.Point(293, 104);
            this.groupBoxAuthorize.Name = "groupBoxAuthorize";
            this.groupBoxAuthorize.Size = new System.Drawing.Size(378, 321);
            this.groupBoxAuthorize.TabIndex = 0;
            this.groupBoxAuthorize.TabStop = false;
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(156, 204);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(75, 23);
            this.buttonAuthorize.TabIndex = 4;
            this.buttonAuthorize.Text = "Войти";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAuthorize_Click);
            // 
            // labelAuthPass
            // 
            this.labelAuthPass.AutoSize = true;
            this.labelAuthPass.Location = new System.Drawing.Point(173, 145);
            this.labelAuthPass.Name = "labelAuthPass";
            this.labelAuthPass.Size = new System.Drawing.Size(45, 13);
            this.labelAuthPass.TabIndex = 3;
            this.labelAuthPass.Text = "Пароль";
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Location = new System.Drawing.Point(173, 95);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(38, 13);
            this.labelAuthLogin.TabIndex = 2;
            this.labelAuthLogin.Text = "Логин";
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.Location = new System.Drawing.Point(102, 161);
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.Size = new System.Drawing.Size(179, 20);
            this.textBoxAuthPass.TabIndex = 1;
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Location = new System.Drawing.Point(103, 111);
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(179, 20);
            this.textBoxAuthLogin.TabIndex = 0;
            // 
            // authorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.groupBoxAuthorize);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "authorizeForm";
            this.Text = "authorizeForm";
            this.groupBoxAuthorize.ResumeLayout(false);
            this.groupBoxAuthorize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAuthorize;
        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Label labelAuthPass;
        private System.Windows.Forms.Label labelAuthLogin;
        private System.Windows.Forms.TextBox textBoxAuthPass;
        private System.Windows.Forms.TextBox textBoxAuthLogin;
    }
}

