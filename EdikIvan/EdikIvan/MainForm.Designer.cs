namespace EdikIvan
{
    partial class MainForm
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
            RandomBtn = new Button();
            ChooseBtn = new Button();
            PicRand = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicRand).BeginInit();
            SuspendLayout();
            // 
            // RandomBtn
            // 
            RandomBtn.AutoSize = true;
            RandomBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RandomBtn.Location = new Point(74, 484);
            RandomBtn.Name = "RandomBtn";
            RandomBtn.Size = new Size(280, 47);
            RandomBtn.TabIndex = 0;
            RandomBtn.Text = "Случайная картинка";
            RandomBtn.UseVisualStyleBackColor = true;
            RandomBtn.Click += RandomBtn_Click;
            // 
            // ChooseBtn
            // 
            ChooseBtn.AutoSize = true;
            ChooseBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ChooseBtn.Location = new Point(458, 484);
            ChooseBtn.Name = "ChooseBtn";
            ChooseBtn.Size = new Size(280, 47);
            ChooseBtn.TabIndex = 1;
            ChooseBtn.Text = "Выбор картинки-->";
            ChooseBtn.UseVisualStyleBackColor = true;
            ChooseBtn.Click += ChooseBtn_Click;
            // 
            // PicRand
            // 
            PicRand.Location = new Point(109, 44);
            PicRand.Name = "PicRand";
            PicRand.Size = new Size(600, 400);
            PicRand.TabIndex = 2;
            PicRand.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            ClientSize = new Size(784, 561);
            Controls.Add(PicRand);
            Controls.Add(ChooseBtn);
            Controls.Add(RandomBtn);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)PicRand).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RandomBtn;
        private Button ChooseBtn;
        private PictureBox PicRand;
    }
}