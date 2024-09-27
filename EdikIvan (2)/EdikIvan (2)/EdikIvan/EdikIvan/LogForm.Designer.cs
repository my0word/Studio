namespace EdikIvan
{
    partial class LogForm
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
            components = new System.ComponentModel.Container();
            logLab = new Label();
            passLab = new Label();
            logtext = new TextBox();
            passtext = new TextBox();
            logBtn = new Button();
            regBtn = new Button();
            loadingProgressBar = new ProgressBar();
            AnimationTimer = new System.Windows.Forms.Timer(components);
            showPasswordBtn = new Button();
            confirmPasstext = new TextBox();
            confirmPassLab = new Label();
            confirmShowPasswordBtn = new Button();
            newPasstext = new TextBox();
            confirmNewPasstext = new TextBox();
            currentPasstext = new TextBox();
            changePasswordBtn = new Button();
            currentPassLab = new Label();
            newPassLab = new Label();
            confirmNewPassLab = new Label();
            SuspendLayout();
            // 
            // logLab
            // 
            logLab.AutoSize = true;
            logLab.Location = new Point(52, 224);
            logLab.Name = "logLab";
            logLab.Size = new Size(40, 15);
            logLab.TabIndex = 0;
            logLab.Text = "логин";
            // 
            // passLab
            // 
            passLab.AutoSize = true;
            passLab.Location = new Point(52, 296);
            passLab.Name = "passLab";
            passLab.Size = new Size(47, 15);
            passLab.TabIndex = 1;
            passLab.Text = "пароль";
            // 
            // logtext
            // 
            logtext.Location = new Point(52, 259);
            logtext.Name = "logtext";
            logtext.Size = new Size(209, 23);
            logtext.TabIndex = 2;
            // 
            // passtext
            // 
            passtext.Location = new Point(52, 329);
            passtext.Name = "passtext";
            passtext.Size = new Size(209, 23);
            passtext.TabIndex = 3;
            // 
            // logBtn
            // 
            logBtn.AutoSize = true;
            logBtn.Location = new Point(346, 460);
            logBtn.Name = "logBtn";
            logBtn.Size = new Size(86, 25);
            logBtn.TabIndex = 4;
            logBtn.Text = "вход";
            logBtn.UseVisualStyleBackColor = true;
            logBtn.Click += logBtn_Click;
            // 
            // regBtn
            // 
            regBtn.AutoSize = true;
            regBtn.Location = new Point(82, 460);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(86, 25);
            regBtn.TabIndex = 5;
            regBtn.Text = "регистрация";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // loadingProgressBar
            // 
            loadingProgressBar.Location = new Point(24, 431);
            loadingProgressBar.Name = "loadingProgressBar";
            loadingProgressBar.Size = new Size(737, 23);
            loadingProgressBar.Style = ProgressBarStyle.Marquee;
            loadingProgressBar.TabIndex = 7;
            loadingProgressBar.Visible = false;
            // 
            // showPasswordBtn
            // 
            showPasswordBtn.AutoSize = true;
            showPasswordBtn.Location = new Point(284, 329);
            showPasswordBtn.Name = "showPasswordBtn";
            showPasswordBtn.Size = new Size(58, 25);
            showPasswordBtn.TabIndex = 8;
            showPasswordBtn.Text = "Скрыть";
            showPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // confirmPasstext
            // 
            confirmPasstext.Location = new Point(52, 380);
            confirmPasstext.Name = "confirmPasstext";
            confirmPasstext.Size = new Size(209, 23);
            confirmPasstext.TabIndex = 9;
            // 
            // confirmPassLab
            // 
            confirmPassLab.AutoSize = true;
            confirmPassLab.Location = new Point(52, 362);
            confirmPassLab.Name = "confirmPassLab";
            confirmPassLab.Size = new Size(148, 15);
            confirmPassLab.TabIndex = 10;
            confirmPassLab.Text = "Введите пароль павторно";
            // 
            // confirmShowPasswordBtn
            // 
            confirmShowPasswordBtn.AutoSize = true;
            confirmShowPasswordBtn.Location = new Point(284, 378);
            confirmShowPasswordBtn.Name = "confirmShowPasswordBtn";
            confirmShowPasswordBtn.Size = new Size(58, 25);
            confirmShowPasswordBtn.TabIndex = 11;
            confirmShowPasswordBtn.Text = "Скрыть";
            confirmShowPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // newPasstext
            // 
            newPasstext.Location = new Point(480, 331);
            newPasstext.Name = "newPasstext";
            newPasstext.Size = new Size(209, 23);
            newPasstext.TabIndex = 12;
            // 
            // confirmNewPasstext
            // 
            confirmNewPasstext.Location = new Point(480, 380);
            confirmNewPasstext.Name = "confirmNewPasstext";
            confirmNewPasstext.Size = new Size(209, 23);
            confirmNewPasstext.TabIndex = 13;
            // 
            // currentPasstext
            // 
            currentPasstext.Location = new Point(480, 259);
            currentPasstext.Name = "currentPasstext";
            currentPasstext.Size = new Size(209, 23);
            currentPasstext.TabIndex = 14;
            // 
            // changePasswordBtn
            // 
            changePasswordBtn.AutoSize = true;
            changePasswordBtn.Location = new Point(543, 460);
            changePasswordBtn.Name = "changePasswordBtn";
            changePasswordBtn.Size = new Size(112, 25);
            changePasswordBtn.TabIndex = 15;
            changePasswordBtn.Text = "изменить пароль";
            changePasswordBtn.UseVisualStyleBackColor = true;
            // 
            // currentPassLab
            // 
            currentPassLab.AutoSize = true;
            currentPassLab.Location = new Point(480, 224);
            currentPassLab.Name = "currentPassLab";
            currentPassLab.Size = new Size(92, 15);
            currentPassLab.TabIndex = 16;
            currentPassLab.Text = "Старый пароль";
            // 
            // newPassLab
            // 
            newPassLab.AutoSize = true;
            newPassLab.Location = new Point(480, 296);
            newPassLab.Name = "newPassLab";
            newPassLab.Size = new Size(88, 15);
            newPassLab.TabIndex = 17;
            newPassLab.Text = "Новый пароль";
            // 
            // confirmNewPassLab
            // 
            confirmNewPassLab.AutoSize = true;
            confirmNewPassLab.Location = new Point(480, 362);
            confirmNewPassLab.Name = "confirmNewPassLab";
            confirmNewPassLab.Size = new Size(149, 15);
            confirmNewPassLab.TabIndex = 18;
            confirmNewPassLab.Text = "Введите пароль повторно";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(confirmNewPassLab);
            Controls.Add(newPassLab);
            Controls.Add(currentPassLab);
            Controls.Add(changePasswordBtn);
            Controls.Add(currentPasstext);
            Controls.Add(confirmNewPasstext);
            Controls.Add(newPasstext);
            Controls.Add(confirmShowPasswordBtn);
            Controls.Add(confirmPassLab);
            Controls.Add(confirmPasstext);
            Controls.Add(showPasswordBtn);
            Controls.Add(loadingProgressBar);
            Controls.Add(regBtn);
            Controls.Add(logBtn);
            Controls.Add(passtext);
            Controls.Add(logtext);
            Controls.Add(passLab);
            Controls.Add(logLab);
            Name = "LogForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label logLab;
        private Label passLab;
        private TextBox logtext;
        private TextBox passtext;
        private Button logBtn;
        private Button regBtn;
        private ProgressBar loadingProgressBar;
        private System.Windows.Forms.Timer AnimationTimer;
        private Button showPasswordBtn;
        private TextBox confirmPasstext;
        private Label confirmPassLab;
        private Button confirmShowPasswordBtn;
        private TextBox newPasstext;
        private TextBox confirmNewPasstext;
        private TextBox currentPasstext;
        private Button changePasswordBtn;
        private Label currentPassLab;
        private Label newPassLab;
        private Label confirmNewPassLab;
    }
}