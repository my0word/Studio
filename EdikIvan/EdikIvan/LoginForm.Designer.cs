namespace EdikIvan
{
    partial class LoginForm
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
            logbtn = new Button();
            passtext = new TextBox();
            logtext = new TextBox();
            loglab = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // logbtn
            // 
            logbtn.AutoSize = true;
            logbtn.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logbtn.Location = new Point(294, 464);
            logbtn.Name = "logbtn";
            logbtn.RightToLeft = RightToLeft.No;
            logbtn.Size = new Size(222, 60);
            logbtn.TabIndex = 0;
            logbtn.Text = "Вход";
            logbtn.UseVisualStyleBackColor = true;
            logbtn.Click += logbtn_Click;
            // 
            // passtext
            // 
            passtext.Location = new Point(294, 358);
            passtext.Name = "passtext";
            passtext.Size = new Size(205, 23);
            passtext.TabIndex = 1;
            // 
            // logtext
            // 
            logtext.Location = new Point(294, 262);
            logtext.Name = "logtext";
            logtext.Size = new Size(205, 23);
            logtext.TabIndex = 2;
            // 
            // loglab
            // 
            loglab.AutoSize = true;
            loglab.Location = new Point(304, 230);
            loglab.Name = "loglab";
            loglab.Size = new Size(41, 15);
            loglab.TabIndex = 3;
            loglab.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 331);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(label2);
            Controls.Add(loglab);
            Controls.Add(logtext);
            Controls.Add(passtext);
            Controls.Add(logbtn);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logbtn;
        private TextBox passtext;
        private TextBox logtext;
        private Label loglab;
        private Label label2;
    }
}